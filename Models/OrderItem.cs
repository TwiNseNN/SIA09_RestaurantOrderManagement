using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public OrderItemStatus Status { get; set; }
        public bool IsReverted { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

    }

    public enum OrderItemStatus
    {
        NotReady,
        Preparing,
        ReadyToServe,
        Served
    }
}
