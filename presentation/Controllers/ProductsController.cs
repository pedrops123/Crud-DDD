using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities.Entities;
using Infrastructure.Configurations;
using Application.Interfaces;

namespace API_DDD_CRUD.Controllers
{
    [ApiController]
    public class ProductsController
    {

        private readonly ProductInterface _InterfaceProductApp;

        public ProductsController(ProductInterface InterfaceProductApp)
        {
            _InterfaceProductApp = InterfaceProductApp;
        }


        /// <summary>
        ///  EndPoint para coletar registros por Id 
        /// </summary>
        /// <param name="id"> Id do registro</param>
        /// <returns></returns>
        [HttpGet("GetById/{id}")]
        public async Task<Product> Get(int id)
        {
            return await _InterfaceProductApp.GetEntityById(id);
        }

        /// <summary>
        ///  EndPoint para coletar todos os registros da base
        /// </summary>
        [HttpGet]
        [Route("GetList")]
        public async Task<List<Product>> GetList()
        {
            return await _InterfaceProductApp.List();
        }

        /// <summary>
        /// EndPoint para cadastrar um novo registro
        /// </summary>
        /// <param name="product"> Parametro produto</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Post")]
        public async Task<Product> Post(Product product)
        {
            await _InterfaceProductApp.Add(product);
            return product;
        }

        /// <summary>
        /// Endpoint para atualizar um registro
        /// </summary>
        /// <param name="product">Parametro atualizacao</param>
        /// <returns></returns>
        [HttpPut]
        [Route("Put")]
        public async Task<Product> Put(Product product)
        {
            await _InterfaceProductApp.Update(product);
            return product;
        }

        /// <summary>
        /// EndPoint para deletar um registro
        /// </summary>
        /// <param name="id">Id do registro</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]
        public async Task<Product> Delete(int id)
        {
            var item = await _InterfaceProductApp.GetEntityById(id);
            await _InterfaceProductApp.Delete(item);
            return item;
        }

        
    }
}
