using eUseControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public interface ISession
    {
        LoginResult UserLogin(ULoginData loginData);
    }

    public class LoginResult
    {
        public bool Status { get; set; }
        public string StatusMsg { get; set; }
        
    }
}
