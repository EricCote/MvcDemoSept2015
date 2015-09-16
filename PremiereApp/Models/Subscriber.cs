using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PremiereApp.Models
{
    public class Subscriber
    {
        public int SubscriberId { get; set; }
        [Display(Name="Nom")]
        [StringLength(20,MinimumLength = 3)]
        [Required()]
        public string Name { get; set; }
        [Display(Name = "Courriel")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Date Création")]
        [UIHint("DateVert")]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}