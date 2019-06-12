using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data.Contracts
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        Task SaveChangesAsync();
    }
}
