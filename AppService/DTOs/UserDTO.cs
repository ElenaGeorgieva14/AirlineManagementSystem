using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public DateTime? BirthDate { get; set; }
        public double Salary { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

       
        public bool Validate()
        {
            return !String.IsNullOrEmpty(Name);
        }
    }
}
