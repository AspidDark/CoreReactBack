using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiReact.Entity.Entities;

namespace WebApiReact.Entity
{
    public class WraDbContext : DbContext
    {
        public WraDbContext(DbContextOptions<WraDbContext> options) : base (options)
        {

        }

        public DbSet<DCandidate> DcCandidates { get; set; }
    }
}
