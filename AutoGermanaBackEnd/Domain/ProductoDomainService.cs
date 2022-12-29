using AutoGermanaBackEnd.Domain.Contracts;
using AutoGermanaBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain
{
    public class ProductoDomainService: IProductosSaveDomainService, IProductoGetDomainService
    {
        private readonly dbproductosContext Context;
        public ProductoDomainService(dbproductosContext context)
        {
            Context = context;
        }

        public IEnumerable<producto> GetAll()
        {
            return Context.productos
                .Include(x => x.Categoria);
        }

        public IEnumerable<producto> GetByCategory(Guid idCategory)
        {
            return Context.productos.Where(x => x.idcategoria.Equals(idCategory));
        }

        public producto GetByID(Guid idProducto)
        {
            return Context.productos.FirstOrDefault(x => x.idproducto.Equals(idProducto));
        }

        public producto GetProductStock(Guid idProducto)
        {
            return Context.productos.FirstOrDefault(x => x.idproducto.Equals(idProducto));
        }

        public void Save(producto producto)
        {
            Context.Add(producto);
            Context.SaveChanges();
        }

        public void Update(producto producto)
        {
            Context.Update(producto);
            Context.SaveChanges();
        }
    }
}
