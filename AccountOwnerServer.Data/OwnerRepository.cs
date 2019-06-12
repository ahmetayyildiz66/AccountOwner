using AccountOwnerServer.Data.Contracts;
using AccountOwnerServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Data
{
    public class OwnerRepository: RepositoryBase<Owner, Guid>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {

        }
    }
}
