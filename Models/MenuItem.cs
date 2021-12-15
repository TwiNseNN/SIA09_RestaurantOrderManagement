using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public bool Hidden { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
