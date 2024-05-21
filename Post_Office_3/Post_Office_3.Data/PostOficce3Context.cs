using Post_Office_3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Office_3.Data
{
   
    public class AppDbContext : DbContext
    {
        public DbSet<Parcel> Parcels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql("server=Localhost;user=root;password=445566778899N;database=post_office_3", serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<Parcel>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP()")
                .ValueGeneratedOnAddOrUpdate();



        }
    }

}
