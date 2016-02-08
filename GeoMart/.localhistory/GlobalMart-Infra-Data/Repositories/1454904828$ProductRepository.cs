using GlobalMart_Domain.Entities;
using GlobalMart_Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMart_Infra_Data.Repositories
{
    public class ProductRepository : RespositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
