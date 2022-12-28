using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain.Contracts
{
    public interface ICategoriaGetDomainService
    {
        IEnumerable<categoria> GetAll();
        categoria GetById(Guid guid);
    }
}
