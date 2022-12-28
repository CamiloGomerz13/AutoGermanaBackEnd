using AutoGermanaBackEnd.Domain.Contracts;
using AutoGermanaBackEnd.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Application.Contracts
{
    public interface IProductoSaveAppService
    {
        string SaveOrUpdate(ProductInDTO productInDTO);

    }
}
