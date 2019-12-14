using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GroupContest : EntityWithId<int>
    {
        [ForeignKey(nameof(Group))]
        public int GroupId
        {
            get;
            set;
        }

        public int ContestId
        {
            get;
            set;
        }

        public virtual Group Group { get; set; }
    }
}
