using SetScheduleTest.Models.Context;
using SetScheduleTest.Models.Models;
using SetScheduleTest.Repository.User.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetScheduleTest.Repository.User.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly SetSchedule_Test_DBContext _context;
        public UserRepository(SetSchedule_Test_DBContext context)
        {
            _context = context;
        }

        public async Task<UserInfo> getUserInfo()
        {
            try
            {
                return _context.UserInfos.OrderByDescending(x=>x.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> saveUserInfo(UserInfo userInfo)
        {
            try
            {
                _context.UserInfos.Add(userInfo);
                var result = await _context.SaveChangesAsync() > 0;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
