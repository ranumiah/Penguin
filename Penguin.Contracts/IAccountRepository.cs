using System;
using System.Collections.Generic;
using Penguin.Entities.Models;

namespace Penguin.Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}