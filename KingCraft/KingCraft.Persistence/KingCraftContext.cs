using KingCraft.Contracts.Persistence.Entities;
using System.Data.Entity;

namespace KingCraft.Persistence
{
    public class KingCraftContext : DbContext
    {
        public KingCraftContext() : base("KingCraftConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KingCraftContext, Migrations.Configuration>("KingCraftConnection"));
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}