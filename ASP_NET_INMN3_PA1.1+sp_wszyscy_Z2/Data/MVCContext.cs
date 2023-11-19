using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Models;

namespace ASP_NET_INMN3_PA1_1_sp_wszyscy_Z2.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext (DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
