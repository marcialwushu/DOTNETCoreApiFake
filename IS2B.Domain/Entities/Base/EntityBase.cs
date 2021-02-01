using System;
using System.Collections.Generic;
using System.Text;

namespace IS2B.Domain.Entities.Base
{
    public abstract class EntityBase 
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }
    }
}
