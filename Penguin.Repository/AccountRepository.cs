using System;
using System.Collections.Generic;
using Penguin.Contracts;
using Penguin.Entities;
using Penguin.Entities.Models;

namespace Penguin.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId));
        }
    }
}