using System;
using System.Collections.Generic;
using Penguin.Contracts;
using Penguin.Entities;
using Penguin.Entities.ExtendedModels;
using Penguin.Entities.Models;

namespace Penguin.Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerById(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public OwnerExtended GetOwnerWithDetails(Guid ownerId)
        {
            throw new NotImplementedException();
        }

        public void CreateOwner(Owner owner)
        {
            owner.OwnerId = Guid.NewGuid();
            Create(owner);
            Save();
        }
    }
}
