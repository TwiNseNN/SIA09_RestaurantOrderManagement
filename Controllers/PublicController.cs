using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    public class PublicController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        public PublicController(Data.RestaurantManagementOrderContext context)
        {
            _context = context;
            StripeConfiguration.ApiKey = "sk_test_51MnnT8LHaiBiYlE1uvA3tLRDXjy25gBkTLrXe0s82GWJzUvtWSc3N1WLnmBB5a3bfOfS2u4mMONzp7Csrp3p7ft5009Oomavhx";
        }
        public IActionResult Menu()
        {
            var menuItems = _context.MenuItem.Where(mi => !mi.Hidden).ToList();
            var categories = menuItems.Select(mi => mi.Category).Distinct();
            var menuItemsCategorized = categories
                .Select(cat => KeyValuePair.Create(cat, menuItems.Where(mi => mi.Category == cat).ToList()))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            return View(menuItemsCategorized);
        }

        public async Task<IActionResult> Table(int id)
        {
            var order = await _context.Order
                .Include(or => or.OrderItems.Where(oi => !oi.IsReverted))
                .ThenInclude(oi => oi.MenuItem)
                .FirstOrDefaultAsync(or => or.TableNumber == id && !or.IsPaid);
            return View(order);
        }

        public async Task<IActionResult> ProcessTablePayment(int id)
        {
            var order = await _context.Order
                .Include(or => or.OrderItems.Where(oi => !oi.IsReverted))
                .ThenInclude(oi => oi.MenuItem)
                .FirstOrDefaultAsync(or => or.OrderId == id);
            var url = Request.Scheme + "://" + Request.Host;
            Console.WriteLine(url);

            var options = new SessionCreateOptions
            {
                LineItems =
                  order.OrderItems.Select(oi => new SessionLineItemOptions
                  {
                      Quantity = oi.Quantity,
                      PriceData = new SessionLineItemPriceDataOptions
                      {
                          UnitAmount = oi.MenuItem.Price,
                          Currency = "ron",
                          ProductData = new SessionLineItemPriceDataProductDataOptions
                          {
                              Name = oi.MenuItem.Name,
                              Description = oi.MenuItem.PrettifiedCategory,
                          }
                      }
                  }).ToList(),
                Mode = "payment",
                SuccessUrl = url + "/Public/StripeSuccess?orderId=" + order.OrderId,
                CancelUrl = url + "/Public/Table/" + order.TableNumber + "?error=paymentCanceled",
            };

            var service = new SessionService();

            Session session = service.Create(options);
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        public async Task<IActionResult> StripeSuccess(int orderId)
        {
            var order = await _context.Order
                .FirstOrDefaultAsync(o => o.OrderId == orderId);
            if (order == null)
            {
                return NotFound();
            }
            order.IsPaid = true;
            _context.SaveChanges();
            return View("PaymentResult", true);
        }
    }
}
