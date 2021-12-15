using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public class Admin : IUser
    {
        public int AdminId { get; set; }
        [NotMapped]
        public int UserId
        {
            get => AdminId;
            set => AdminId = value;
        }
        public UserType Type => UserType.Admin;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
