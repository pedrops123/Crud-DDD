using Application.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppProduct : ProductInterface
    {
        IProduct _Product;

        public AppProduct(IProduct product)
        {
            _Product = product;
        }

        public async Task Add(Product Objeto)
        {
           await _Product.Add(Objeto);
        }

        public async Task Delete(Product Objeto)
        {
            await _Product.Delete(Objeto);
        }

        public async Task<Product> GetEntityById(int id)
        {
            return await _Product.GetEntityById(id);
        }

        public async Task<List<Product>> List()
        {
            return await _Product.List();
        }

        public async Task Update(Product Objeto)
        {
            await _Product.Update(Objeto);
        }
    }
}
