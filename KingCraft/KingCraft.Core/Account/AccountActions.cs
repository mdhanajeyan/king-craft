using KingCraft.Contracts.Account;
using KingCraft.Contracts.Persistence.Entities;
using KingCraft.Contracts.Persistence.Repositories;
using System.Collections.Generic;

namespace KingCraft.Core.Account
{
    public class AccountActions : IAccountActions
    {
        private readonly IRepository<UserRole> _userRole;

        public AccountActions(IRepository<UserRole> userRole)
        {
            _userRole = userRole;
        }

        public IEnumerable<UserRole> GetAllUserRles()
        {
            return _userRole.GetAll();
        }
    }
}