using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public enum UserType
    {
        Admin,
        Cook,
        Waiter
    }

    public interface IUser
    {
        public int UserId { get; set; }
        public UserType Type { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
