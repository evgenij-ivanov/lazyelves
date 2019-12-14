using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class GroupParticipant : EntityWithId<int>
    {
        [ForeignKey(nameof(Group))]
        public int GroupId
        {
            get;
            set;
        }

        public string Handle
        {
            get;
            set;
        }

        public virtual Group Group { get; set;}
    }
}
