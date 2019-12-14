using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Group : EntityWithId<int>
    {
        public string Name
        {
            get;
            set;
        }
    }
}
