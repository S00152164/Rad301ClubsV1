using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rad301ClubsV1.Models
{
    public class LibContext : DbContext
    {
        public LibContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Class1> Books { get; set; }

    }
}