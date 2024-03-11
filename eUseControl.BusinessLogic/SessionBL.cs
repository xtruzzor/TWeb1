using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eUseControl.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        // Implementarea metodei UserLogin din interfața ISession
        public LoginResult UserLogin(ULoginData loginData)
        {
           
            if (loginData.Credential == "admin" && loginData.Password == "password")
            {
                return new LoginResult { Status = true }; // Autentificare reușită
            }
            else
            {
                return new LoginResult { Status = false, StatusMsg = "Credențiale incorecte" }; // Autentificare eșuată
            }
        }
    }
}

