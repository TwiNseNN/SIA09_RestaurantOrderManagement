using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementOrder.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int WaiterId { get; set; }
        public int TableNumber { get; set; }
        public OrderPaymentMethod? PaymentMethod { get; set; }
        public bool IsPaid { get; set; }

        public Waiter Waiter { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        [NotMapped]
        public int Total {
            get => OrderItems
                .Where(oi => !oi.IsReverted)
                .Sum(oi => oi.MenuItem.Price * oi.Quantity);
        }
    }

    public enum OrderPaymentMethod
    {
        Card,
        Cash
    }
}
