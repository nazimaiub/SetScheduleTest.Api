using SetScheduleTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SetScheduleTest.Service.User.Interface
{
    public interface IUserService
    { 
        Task<UserInfo> getUserInfo();
        Task<bool> saveUserInfo(UserInfo userInfo);
    }
}
