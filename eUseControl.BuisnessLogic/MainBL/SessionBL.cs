using eUseControl.BuisnessLogic.Core;
using eUseControl.BuisnessLogic.Interfaces;
using eUseControl.Domain.Entities.Response;
using eUseControl.Domain.Entities.User;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BuisnessLogic.MainBL
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
    }
}
