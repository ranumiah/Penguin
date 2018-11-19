using System;
using System.Collections.Generic;
using Penguin.Entities.ExtendedModels;
using Penguin.Entities.Models;

namespace Penguin.Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(Guid ownerId);
        OwnerExtended GetOwnerWithDetails(Guid ownerId);
        void CreateOwner(Owner owner);
    }
}