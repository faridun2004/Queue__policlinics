using Queue.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.BaseEntities
{
    public abstract class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public UserRoles Roles { get; set; }

        public string? UserName { get; set; }
        public string? Password { get; set; }

        public string? RefreshToken {  get; set; }
    }
}
