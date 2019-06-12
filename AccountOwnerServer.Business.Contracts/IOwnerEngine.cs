using AccountOwnerServer.Common.ResponseMessages;
using System;
using System.Threading.Tasks;

namespace AccountOwnerServer.Business.Contracts
{
    public interface IOwnerEngine : IBusinessEngine
    {
        Task<OwnerResponse> GetAsync(Guid id);
    }
}
