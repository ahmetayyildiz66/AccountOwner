using AccountOwnerServer.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Data
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _context;
        private IOwnerRepository _owner;
        private IAccountRepository _account;

        public IOwnerRepository Owner
        {
            get
            {
                if(_owner == null)
                {
                    _owner = new OwnerRepository(_context);
                }
                return _owner;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if(_account == null)
                {
                    _account = new AccountRepository(_context);
                }

                return _account;
            }
        }

        public RepositoryWrapper(RepositoryContext context)
        {
            _context = context;
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
