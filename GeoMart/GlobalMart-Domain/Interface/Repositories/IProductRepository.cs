using GlobalMart_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart_Domain.Interface
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetProductByName(string name);

    }
}
