using BusinessLayer.Interface;
using CommonLayer.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace FundoNote.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        private IConfiguration _config;

        public UserController(IUserBL userBL, IConfiguration _config)
        {
            this.userBL = userBL;
            this._config = _config;
        }

        [HttpPost("RegisterUser")]

        public IActionResult RegisterUser(UserPostModel userPostModel)
        {
            try
            {
                this.userBL.RegisterUser(userPostModel);
                return this.Ok(new { sucess = true, status = 200, message = $"Registration sucessful for {userPostModel.Email}" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost("LoginUser")]
        public IActionResult LoginUser(LoginModel loginModel)
        {
            try
            {
                this.userBL.LoginUser(loginModel);
                return this.Ok(new { success = true, status = 200, message = $"login successful for {loginModel.Email}" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
