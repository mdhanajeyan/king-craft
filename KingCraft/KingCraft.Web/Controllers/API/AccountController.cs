using KingCraft.Contracts.Account;
using System.Web.Http;

namespace KingCraft.Web.Controllers.API
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        private readonly IAccountActions _accountActions;
        public AccountController(IAccountActions accountActions)
        {
            _accountActions = accountActions;
        }

       
    }
}
