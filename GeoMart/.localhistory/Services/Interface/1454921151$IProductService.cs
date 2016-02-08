using GlobalMart_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProductService
    {
         IEnumerable<Product> GetProducts();
        void Add(Product productObj);
        Product GetProductById(int id);
        void RemoveProduct(int id);

    }
}
