using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_TwitterSampleWithEFCore.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Vault> Vaults { get; set; }

        public DatabaseContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyPasswordBoxDB;Trusted_Connection=True");
            }

            base.OnConfiguring(optionsBuilder); 
        }
    }
}
