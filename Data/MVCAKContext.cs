using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAK.Models;

namespace MVCAK.Data
{
    public class MVCAKContext : DbContext
    {
        public MVCAKContext (DbContextOptions<MVCAKContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAK.Models.Actor> Actor { get; set; }

        public DbSet<MVCAK.Models.Movie> Movie { get; set; }
    }
}
