using SetScheduleTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SetScheduleTest.Repository.User.Interface
{
    public interface IUserRepository
    {
        Task<UserInfo> getUserInfo();
        Task<bool> saveUserInfo(UserInfo userInfo);
    }
}
