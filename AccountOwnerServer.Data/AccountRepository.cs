using AccountOwnerServer.Data.Contracts;
using AccountOwnerServer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Data
{
    public class AccountRepository: RepositoryBase<Account, Guid>, IAccountRepository
    {
        public AccountRepository(RepositoryContext context): base(context)
        {

        }
    }
}
