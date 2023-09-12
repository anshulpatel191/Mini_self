using Mini_self.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_self.Data
{
    public interface IUserdataProvider
    {
        public UserModel GetUserDetail(UserViewModel login);
    }
}
