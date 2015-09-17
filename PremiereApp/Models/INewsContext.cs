using System.Data.Entity;

namespace PremiereApp.Models
{
    public interface INewsContext  
    {
        IDbSet<Category> Categories { get; set; }
        IDbSet<Subscriber> Subscribers { get; set; }
    }
}