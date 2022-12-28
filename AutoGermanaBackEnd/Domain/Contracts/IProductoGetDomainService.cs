
using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain.Contracts
{
    public interface IProductoGetDomainService
    {
        IEnumerable<producto> GetAll();
        IEnumerable<producto> GetByCategory(Guid guid);
        producto GetProductStock(Guid guid);
        producto GetByID(Guid guid);
    }
}
