using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Domain.Contracts
{
    public interface ICategoriaSaveDomainService
    {
        void Save(categoria categoria);
        void Update(categoria categoria);
    }
}
