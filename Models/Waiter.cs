using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public class Waiter : IUser
    {
        public int WaiterId { get; set; }
        [NotMapped]
        public int UserId
        {
            get => WaiterId;
            set => WaiterId = value;
        }
        public UserType Type => UserType.Waiter;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Order> Orders { get; set; }
    }
}
