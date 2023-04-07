using SetScheduleTest.Models.Models;
using SetScheduleTest.Repository.User.Interface;
using SetScheduleTest.Service.User.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SetScheduleTest.Service.User.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public Task<UserInfo> getUserInfo()
        {
            try
            {
                return _userRepository.getUserInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> saveUserInfo(UserInfo userInfo)
        {
            try
            {
                return _userRepository.saveUserInfo(userInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
