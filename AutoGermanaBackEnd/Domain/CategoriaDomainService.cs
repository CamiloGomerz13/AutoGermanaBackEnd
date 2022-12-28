using AutoGermanaBackEnd.Domain.Contracts;
using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain
{
    public class CategoriaDomainService : ICategoriaSaveDomainService, ICategoriaGetDomainService
    {
        private readonly dbproductosContext Context;

        public CategoriaDomainService(dbproductosContext context)
        {
            Context = context;
        }

        public IEnumerable<categoria> GetAll()
        {
            return Context.categorias;
        }

        public categoria GetById(Guid idCategoria)
        {
            return Context.categorias.FirstOrDefault(x => x.idcategoria.Equals(idCategoria));
        }

        public void Save(categoria categoria)
        {
            Context.categorias.Add(categoria);
            Context.SaveChanges();
        }

        public void Update(categoria categoria)
        {
            Context.categorias.Update(categoria);
            Context.SaveChanges();
        }
    }
}
