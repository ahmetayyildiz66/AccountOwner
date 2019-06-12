using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Common.ResponseMessages
{
    public class OwnerResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public OwnerResponse(Guid id, string name, DateTime date, string address)
        {
            Id = id;
            Name = name;
            DateOfBirth = date;
            Address = address;
        }
    }
}
