using System.Data.Entity;
using RealTimeWebHookApp.Models;

namespace RealTimeWebHookApp.Persistance
{
    public class ActivityContext : DbContext
    {
        public ActivityContext() : base("name=ActivityDBConnectionString")
        {
            
        }
        public DbSet<ActivityModel> ActivityTrackers { get; set; }
    }
}