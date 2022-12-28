using AutoGermanaBackEnd.Models;
using System;
using System.Collections.Generic;

namespace AutoGermanaBackEnd.Application.Contracts
{
    public interface ICategoriaGetAppService
    {
        List<categoria> GetAll();
        categoria GetById(Guid guid);
    }
}
