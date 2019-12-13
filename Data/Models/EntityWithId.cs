using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models.Interfaces;

namespace Data.Models
{
    public class EntityWithId<TId> : IEntityWithId<TId>
    {
        public TId Id
        {
            get;
            set;
        }
    }
}
