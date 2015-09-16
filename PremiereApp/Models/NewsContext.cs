using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PremiereApp.Models
{

    public class NewsContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

        public NewsContext() : base("NewsConn")
        {
        }

    }
}