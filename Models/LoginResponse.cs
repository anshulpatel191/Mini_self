using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_self.Models
{
    public class LoginResponse
    {
        public string token { get; set; }
        public string User_Id { get; set; }
        public bool Role { get; set; }
    }
}
