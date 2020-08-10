using MySql.Data.EntityFramework;
using System.Data.Entity;
using WindowsFormEntityFrameworkStarter.Entities;
namespace WindowsFormEntityFrameworkStarter.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Item> Items
        {
            get;
            set;
        }
    }
}
