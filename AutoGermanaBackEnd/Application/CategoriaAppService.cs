using AutoGermanaBackEnd.Application.Contracts;
using AutoGermanaBackEnd.Domain.Contracts;
using AutoGermanaBackEnd.DTOs;
using AutoGermanaBackEnd.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Application
{
    public class CategoriaAppService : ICategoriaSaveAppService, ICategoriaGetAppService
    {
        private readonly ICategoriaSaveDomainService _categoriaSaveDomainService;
        private readonly IMapper mapper;
        private readonly ICategoriaGetDomainService _categoriaGetDomainService;
        public CategoriaAppService(ICategoriaSaveDomainService categoriaSaveDomainService,
                                   IMapper mapper,
                                   ICategoriaGetDomainService categoriaGetDomainService)
        {
            _categoriaSaveDomainService = categoriaSaveDomainService;
            this.mapper = mapper;
            _categoriaGetDomainService = categoriaGetDomainService;
        }

        public List<categoria> GetAll()
        {
            return _categoriaGetDomainService.GetAll().ToList();
        }

        public categoria GetById(Guid idCategoria)
        {
            return _categoriaGetDomainService.GetById(idCategoria);
        }

        public string SaveOrUpdate(CategoriaInDTO categoriaInDTO)
        {
            try
            {
                categoria categoria = mapper.Map<CategoriaInDTO, categoria>(categoriaInDTO);
                if (categoriaInDTO.idCategoria.HasValue)
                {
                    _categoriaSaveDomainService.Update(categoria);
                    return "La categoria se ha actualizado correctamente";
                }
                _categoriaSaveDomainService.Save(categoria);
                return "La categoria se ha creado correctamente";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
