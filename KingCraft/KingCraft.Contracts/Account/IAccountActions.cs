using KingCraft.Contracts.Persistence.Entities;
using System.Collections.Generic;

namespace KingCraft.Contracts.Account
{
    public interface IAccountActions
    {
        IEnumerable<UserRole> GetAllUserRles();
    }
}