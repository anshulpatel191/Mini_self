using Mini_self.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_self.Services
{
    public interface IAuthService
    {
        public UserModel GetUserDetail(UserViewModel login);
    }
}
