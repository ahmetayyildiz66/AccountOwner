using AccountOwnerServer.Common.ResponseMessages;
using AccountOwnerServer.Data.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Common.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerResponse>();
            
        }
    }
}
