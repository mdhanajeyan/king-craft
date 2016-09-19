using KingCraft.Contracts.Account;
using KingCraft.Contracts.Persistence.Entities;
using System.Collections.Generic;
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

        [HttpGet, Route("")]
        public IEnumerable<UserRole> GetAllUserRoles()
        {
            return _accountActions.GetAllUserRles();
        }
    }
}