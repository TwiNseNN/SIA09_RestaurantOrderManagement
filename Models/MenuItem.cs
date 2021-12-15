using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string PrettifiedCategory
        {
            get
            {
                var words = Category.Split('_').ToList();
                words = words.Select(w => char.ToUpper(w[0]) + w.Substring(1)).ToList();
                return string.Join(' ', words);
            }
        }
    }
}
