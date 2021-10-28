using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFR_MVC_.Data
{
    public class MFRContext : DbContext
    {
        public MFRContext(DbContextOptions<MFRContext> options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }

        
    }
}
