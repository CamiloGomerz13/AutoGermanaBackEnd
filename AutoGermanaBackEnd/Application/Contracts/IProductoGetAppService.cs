using AutoGermanaBackEnd.DTOs;
using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Application.Contracts
{
    public interface IProductoGetAppService
    {
        ProductoStock GetProductStock(Guid guid); 
        List<producto> GetByCategory(Guid guid);
        List<producto> GetAll();
        producto GetById(Guid guid);
    }
}
