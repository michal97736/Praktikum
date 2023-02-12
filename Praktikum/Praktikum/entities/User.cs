using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Repository.entities
{
  
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TZ { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; } 
        public string HMO { get; set; }

    }
}
