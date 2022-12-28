using AutoGermanaBackEnd.Application.Contracts;
using AutoGermanaBackEnd.DTOs;
using AutoGermanaBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaSaveAppService _categoriaSaveAppService;
        private readonly ICategoriaGetAppService _categoriaGetAppService;

        public CategoriaController(ICategoriaSaveAppService categoriaSaveAppService, ICategoriaGetAppService categoriaGetAppService)
        {
            _categoriaSaveAppService = categoriaSaveAppService;
            _categoriaGetAppService = categoriaGetAppService;
        }

        [HttpPost]
        [Route(nameof(CategoriaController.SaveOrUpdateCategoria))]
        public string SaveOrUpdateCategoria(CategoriaInDTO categoriaInDTO)
        {
            return _categoriaSaveAppService.SaveOrUpdate(categoriaInDTO);
        }


        [HttpGet]
        [Route(nameof(ProductoController.GetAll))]
        public List<categoria> GetAll()
        {
            return _categoriaGetAppService.GetAll();
        }

        [HttpGet]
        [Route(nameof(ProductoController.GetById))]
        public categoria GetById(Guid idCategoria)
        {
            return _categoriaGetAppService.GetById(idCategoria);
        }
    }
}
