using GlobalMart_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart_Infra_Data.EntityConfig
{
   public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(s => s.ProductId);
            Property(c => c.Name).IsRequired().HasMaxLength(150);
            Property(c => c.Cost).IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }
    }
}
