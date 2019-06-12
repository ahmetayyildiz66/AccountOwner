using System;
using System.Collections.Generic;
using System.Text;

namespace AccountOwnerServer.Data.Entities
{
    public abstract class EntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
