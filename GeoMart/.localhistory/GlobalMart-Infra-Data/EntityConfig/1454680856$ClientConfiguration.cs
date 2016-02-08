using GlobalMart_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart_Infra_Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(s => s.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(150);
            Property(c => c.Email).IsRequired();
        }

    }
}
