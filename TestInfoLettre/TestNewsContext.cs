using PremiereApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestInfoLettre
{
    class TestNewsContext : INewsContext
    {
        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Subscriber> Subscribers { get; set; }
    }
}
