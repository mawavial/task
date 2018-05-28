using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThreeAPIs.Models;

namespace ThreeAPIs.Models
{
    public class ThreeAPIsContext : DbContext
    {
        public ThreeAPIsContext (DbContextOptions<ThreeAPIsContext> options)
            : base(options)
        {
        }

        public DbSet<ThreeAPIs.Models.CieloAPI> CieloAPI { get; set; }

        public DbSet<ThreeAPIs.Models.ClearSecuAPI> ClearSecuAPI { get; set; }

        public DbSet<ThreeAPIs.Models.StoneAPI> StoneAPI { get; set; }
    }
}
