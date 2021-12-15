using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    [Authorize(Policy = "Cook")]
    public class CookPanelController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        public CookPanelController(Data.RestaurantManagementOrderContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var orders = _context.OrderItem
                .Include(oi => oi.MenuItem)
                .Include(oi => oi.Order)
                .Where(oi => oi.Status == Models.OrderItemStatus.NotReady || oi.Status == Models.OrderItemStatus.Preparing)
                .ToList();
            return View(orders);
        }

        [HttpPost]
        public IActionResult SetStatus(string compoundId, string newStatus)
        {
            var parts = compoundId.Split('-');
            var orderId = Convert.ToInt32(parts[0]);
            var menuItemId = Convert.ToInt32(parts[1]);
            var orderItem = _context.OrderItem.First(oi => oi.OrderId == orderId && oi.MenuItemId == menuItemId);

            orderItem.Status = Enum.Parse<Models.OrderItemStatus>(newStatus);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
