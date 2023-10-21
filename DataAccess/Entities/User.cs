using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; } = 0;
        public bool Status { get; set; } = true;
        public bool IsManager { get; set; } = false;
        public bool IsSuperUser { get; set; } = false;
    }
}
