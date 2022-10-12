using System;
using Microsoft.EntityFrameworkCore;
using Sunglasses_Assignment1_Ssoma.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sunglasses_Assignment1_Ssoma.Data
{
    public class MvcSunglassesContext : DbContext
    {
        public MvcSunglassesContext(DbContextOptions<MvcSunglassesContext> options)
           : base(options)
        {
        }
        public DbSet<Sunglasses> Sunglasses { get; set; }

    }
}
