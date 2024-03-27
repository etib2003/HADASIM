using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corona_System.Models;

namespace Corona_System.Data
{
    public class Corona_SystemContext : DbContext
    {
        public Corona_SystemContext (DbContextOptions<Corona_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<Corona_System.Models.Member> Member { get; set; } = default!;
    }
}
