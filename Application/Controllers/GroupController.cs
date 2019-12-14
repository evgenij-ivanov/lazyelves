using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Services.Interfaces;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    public class GroupController : Controller
    {
        private IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet("[action]")]
        public void CreateGroup()
        {
            _groupService.CreateGroup();
        }

        [HttpGet("[action]")]
        public void DeleteGroup()
        {
            _groupService.DeleteGroup();
        }

        [HttpGet("[action]")]
        public void AddParticipant()
        {
            _groupService.AddParticipant();
        }

        [HttpGet("[action]")]
        public void RemoveParticipant()
        {
            _groupService.RemoveParticipant();
        }

        [HttpGet("[action]")]
        public void AddContest()
        {
            _groupService.AddContest();
        }

        [HttpGet("[action]")]
        public void RemoveContest()
        {
            _groupService.RemoveContest();
        }

    }
}
