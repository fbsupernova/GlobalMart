using GlobalMart_Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace GlobalMart_Infra_Data.Context
{
    public class GlobalMartContext : DbContext
    {
        public GlobalMartContext(): base("GlobalMartModelConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.ReflectedType.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>().
                Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().
               Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<string>().
               Configure(p => p.HasColumnType("varchar"));
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry=>entry.Entity.GetType().GetProperty("CreatedOn") !=null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges(); 
        }
    }
}
