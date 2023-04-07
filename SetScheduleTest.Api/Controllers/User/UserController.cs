using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SetScheduleTest.Models.Models;
using SetScheduleTest.Service.User.Interface;

namespace SetScheduleTest.Api.Controllers.User
{
    [Route("api/user")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("getUserInfo")]
        public async Task<UserInfo> GetUserInfo()
        {
            try
            {
                var userInfo = await _userService.getUserInfo();
                return userInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("saveUserInfo")]
        public async Task<IActionResult> saveUserInfo([FromBody] UserInfo userInfo)
        {
            var result = await _userService.saveUserInfo(userInfo);
            return Ok(result);
        }
    }
}