using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain.Contracts
{
    public interface IProductosSaveDomainService
    {
        void Save(producto producto);
        void Update(producto producto);
    }
}
