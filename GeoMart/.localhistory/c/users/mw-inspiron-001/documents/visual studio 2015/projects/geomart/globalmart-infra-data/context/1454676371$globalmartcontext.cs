using GlobalMart_Domain.Entities;
using System.Data.Entity;

namespace GlobalMart_Infra_Data.Context
{
    public class GlobalMartContext : DbContext
    {
        public GlobalMartContext(): base("GlobalMartModelConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
