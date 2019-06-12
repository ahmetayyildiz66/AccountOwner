using AccountOwnerServer.Common.Contracts;
using AccountOwnerServer.Common.ResponseMessages;
using AccountOwnerServer.Data.Entities;
using AutoMapper;
using System;

namespace AccountOwnerServer.Business
{
    public class BusinessEngineBase: Profile
    {
        protected IMapper Mapper;
        public BusinessEngineBase()
        {
            CreateMap<Owner, OwnerResponse>();
        }

        protected T ExecuteWithExceptionHandledOperation<T>(Func<T> func)
        {
            try
            {
                var result = func.Invoke();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ExecuteWithExceptionHandledOperation(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
            }
        }
    }
}
