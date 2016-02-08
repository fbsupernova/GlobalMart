using GlobalMart_Domain.Entities;
using GlobalMart_Infra_Data.Repositories;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public IEnumerable<Product> GetProducts()
        {
            var repoStudies = _productRepository.GetAll();
            return repoStudies;
        }

        public void Add(Product productObj)
        {
            _productRepository.Add(productObj);

        }


    }
}
