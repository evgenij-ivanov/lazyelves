using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services.Interfaces
{
    public interface IGroupService
    {
        void CreateGroup();

        void DeleteGroup();

        void AddParticipant();

        void RemoveParticipant();

        void AddContest();

        void RemoveContest();
    }
}
