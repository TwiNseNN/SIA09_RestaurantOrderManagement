using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models.WaiterTables
{
    public class AddOrderItem
    {
        public Dictionary<string, List<MenuItem>> MenuItems { get; set; }
    }
}
