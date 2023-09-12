using Mini_self.Data;
using Mini_self.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_self.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserDataProvider _userDataProvider;
        public AuthService(UserDataProvider userDataProvider)
        {
            _userDataProvider = userDataProvider;
        }
        public UserModel GetUserDetail(UserViewModel login)
        {
            UserModel user = null;
            user = _userDataProvider.GetUserDetail(login);
            return user;
        }
    }
}
