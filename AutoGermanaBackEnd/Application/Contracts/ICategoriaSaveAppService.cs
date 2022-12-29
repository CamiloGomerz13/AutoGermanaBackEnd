using AutoGermanaBackEnd.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Application.Contracts
{
    public interface ICategoriaSaveAppService
    {
        string SaveOrUpdate(CategoriaInDTO categoria);
        void UpdateState(Guid guid);
    }
}
