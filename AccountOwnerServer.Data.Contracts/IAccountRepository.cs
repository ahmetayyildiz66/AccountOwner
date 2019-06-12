using AccountOwnerServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Data.Contracts
{
    public interface IAccountRepository: IRepository<Account,Guid>
    {
    }
}
