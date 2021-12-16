using Microsoft.AspNetCore.Mvc;
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
    }
}
