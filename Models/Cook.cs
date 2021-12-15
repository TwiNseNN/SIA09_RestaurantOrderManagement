using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementOrder.Models
{
    public class Cook : IUser
    {
        public int CookId { get; set; }
        [NotMapped]
        public int UserId
        {
            get => CookId;
            set => CookId = value;
        }
        public UserType Type => UserType.Cook;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
