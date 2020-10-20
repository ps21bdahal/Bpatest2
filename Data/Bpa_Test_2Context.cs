using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bpa_Test_2.Models;

namespace Bpa_Test_2.Data
{
    public class Bpa_Test_2Context : DbContext
    {
        public Bpa_Test_2Context (DbContextOptions<Bpa_Test_2Context> options)
            : base(options)
        {
        }

        public DbSet<Bpa_Test_2.Models.Restaurant> Restaurant { get; set; }
    }
}
