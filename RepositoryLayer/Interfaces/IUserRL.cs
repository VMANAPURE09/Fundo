using CommonLayer.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IUserRL
    {
       
        void RegisterUser(UserPostModel userPostModel);
        public string loginUser(LoginModel loginModel);
        public bool ForgotPassword(string email);
    }
}
