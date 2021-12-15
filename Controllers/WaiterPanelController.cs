using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    [Authorize(Policy = "Waiter")]
    public class WaiterPanelController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        public WaiterPanelController(Data.RestaurantManagementOrderContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var orderTables = new List<Order>();
            var tableCount = Services.Constants.TableCount;
            for (int i = 1; i <= tableCount; i++)
            {
                var currentOrder = _context.Order
                    .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.MenuItem)
                    .FirstOrDefault(order => !order.IsPaid && order.TableNumber == i);
                orderTables.Add(currentOrder);
            }
            var index = new Models.WaiterTables.Index();
            index.TableOrders = orderTables;
            return View(index);
        }

        public IActionResult Table([Bind(Prefix = "id")] int tableNumber)
        {
            var order = _context.Order
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .FirstOrDefault(o => o.TableNumber == tableNumber && !o.IsPaid);
            if (order == null)
            {
                order = new Order()
                {
                    TableNumber = tableNumber,
                    IsPaid = false,
                    WaiterId = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == "userId").Value),
                    OrderItems = new List<OrderItem>()
                };
                _context.Add(order);
                _context.SaveChanges();
            }
            return View(order);
        }

        public IActionResult AddOrderItem([Bind(Prefix = "id")] int tableNumber)
        {
            var menuItems = _context.MenuItem.Where(mi => !mi.Hidden).ToList();
            var categories = menuItems.Select(mi => mi.Category).Distinct();
            var menuItemsCategorized = categories
                .Select(cat => KeyValuePair.Create(cat, menuItems.Where(mi => mi.Category == cat).ToList()))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            var view = new Models.WaiterTables.AddOrderItem()
            { MenuItems = menuItemsCategorized };
            return View(view);
        }

        [HttpPost, ActionName("AddOrderItem")]
        public IActionResult AddOrderItemPost([Bind(Prefix = "id")] int tableNumber, int quantity, int menuItemId)
        {
            var order = _context.Order
                .Include(o => o.OrderItems)
                .First(o => o.TableNumber == tableNumber && !o.IsPaid);
            var orderItem = order.OrderItems.FirstOrDefault(oi => oi.MenuItemId == menuItemId && oi.OrderId == order.OrderId);
            if (orderItem == null)
            {
                orderItem = new OrderItem()
                {
                    IsReverted = false,
                    MenuItemId = menuItemId,
                    OrderId = order.OrderId,
                    Quantity = 0,
                    Status = OrderItemStatus.NotReady
                };
                order.OrderItems.Add(orderItem);
            }
            orderItem.Quantity += quantity;
            _context.SaveChanges();
            return RedirectToAction(nameof(Table), new { id = tableNumber });
        }

        [HttpPost]
        public IActionResult ToggleRevert([Bind(Prefix = "id")] string compoundId, int returnToTable)
        {
            var parts = compoundId.Split('-');
            var orderId = Convert.ToInt32(parts[0]);
            var menuItemId = Convert.ToInt32(parts[1]);
            var orderItem = _context.OrderItem.First(oi => oi.OrderId == orderId && oi.MenuItemId == menuItemId);
            orderItem.IsReverted = !orderItem.IsReverted;
            _context.SaveChanges();
            return RedirectToAction(nameof(Table), new { id = returnToTable });
        }

        [HttpPost]
        public IActionResult MarkAsServed([Bind(Prefix = "id")] string compoundId, int returnToTable)
        {
            var parts = compoundId.Split('-');
            var orderId = Convert.ToInt32(parts[0]);
            var menuItemId = Convert.ToInt32(parts[1]);
            var orderItem = _context.OrderItem
                .First(oi => oi.OrderId == orderId && oi.MenuItemId == menuItemId);

            if (orderItem.Status == OrderItemStatus.ReadyToServe)
                orderItem.Status = OrderItemStatus.Served;
            _context.SaveChanges();
            return RedirectToAction(nameof(Table), new { id = returnToTable });
        }

        [HttpPost]
        public IActionResult EndOrder(int orderId, string paymentMethod)
        {
            var order = _context.Order.Find(orderId);
            order.PaymentMethod = Enum.Parse<OrderPaymentMethod>(paymentMethod);
            order.IsPaid = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
