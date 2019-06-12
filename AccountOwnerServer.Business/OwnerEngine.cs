using AccountOwnerServer.Business.Contracts;
using AccountOwnerServer.Common.ResponseMessages;
using AccountOwnerServer.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccountOwnerServer.Business
{
    public class OwnerEngine : BusinessEngineBase, IOwnerEngine
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerEngine(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public Task<OwnerResponse> GetAsync(Guid id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var owner = await _ownerRepository.GetAsync(id);
                OwnerResponse ownerResponse = new OwnerResponse(owner.Id, owner.Name, owner.DateOfBirth, owner.Address);
                return ownerResponse;
                
            });
        }
    }
}
