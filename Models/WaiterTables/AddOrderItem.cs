using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models.WaiterTables
{
    public class AddOrderItem
    {
        public Dictionary<string, List<MenuItem>> MenuItems { get; set; }
        public string BeautifyCategory(string category)
        {
            var words = category.Split('_').ToList();
            words = words.Select(w => char.ToUpper(w[0]) + w.Substring(1)).ToList();
            return string.Join(' ', words);
        }
    }
}
