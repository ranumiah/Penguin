using Penguin.Contracts;
using Penguin.Entities;
using Penguin.Entities.Models;

namespace Penguin.Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
