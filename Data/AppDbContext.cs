using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupContest> GroupContestss { get; set; }
        public DbSet<GroupParticipant> GroupParticipants { get; set; }
    }
}
