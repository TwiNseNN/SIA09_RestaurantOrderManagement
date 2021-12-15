using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Controllers
{
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

        //[HttpPost]
        //public IActionResult SetStatus([Bind(Prefix = "id")] string compositeId, string newStatus)
        //{

        //}
    }
}
