using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiereApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

       public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}