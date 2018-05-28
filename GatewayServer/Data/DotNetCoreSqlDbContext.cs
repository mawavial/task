using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Models
{
    public class DotNetCoreSqlDbContext : DbContext
    {
        public DotNetCoreSqlDbContext (DbContextOptions<DotNetCoreSqlDbContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreSqlDb.Models.Cielo> Cielo { get; set; }
    }
}
