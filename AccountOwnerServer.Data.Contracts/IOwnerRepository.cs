using AccountOwnerServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Data.Contracts
{
    public interface IOwnerRepository: IRepository<Owner,Guid>
    {
    }
}
