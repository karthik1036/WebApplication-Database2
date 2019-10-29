using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Database2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department{ get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
    }
}
