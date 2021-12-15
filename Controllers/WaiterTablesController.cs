using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
    public class WaiterTablesController : Controller
    {
        protected Data.RestaurantManagementOrderContext _context;
        public WaiterTablesController(Data.RestaurantManagementOrderContext context)
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
                    WaiterId = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == "userId").Value)
                };
                _context.Add(order);
                _context.SaveChanges();
            }
            return View(order);
        }
    }
}
