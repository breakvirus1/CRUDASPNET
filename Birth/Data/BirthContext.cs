using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Birth.Models;

namespace Birth.Data
{
    public class BirthContext : DbContext
    {
        public BirthContext (DbContextOptions<BirthContext> options)
            : base(options)
        {
        }

        public DbSet<Birth.Models.People> People { get; set; }
    }
}
