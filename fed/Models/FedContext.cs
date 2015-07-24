using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace fed.Models
{
    public class FedContext : DbContext
    {
        public FedContext()
            : base("name=FedContext")
        { }
        
        public DbSet<Siteuser> Siteusers { get; set; }
    }
}