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
    public class ProductoController : ControllerBase
    {
        private readonly IProductoSaveAppService _productoSaveAppService;
        private readonly IProductoGetAppService _productoGetAppService;

        public ProductoController(IProductoSaveAppService productoSaveAppService, IProductoGetAppService productoGetAppService)
        {
            _productoSaveAppService = productoSaveAppService;
            _productoGetAppService = productoGetAppService;
        }

        [HttpPost]
        [Route(nameof(ProductoController.SaveOrUpdateProducto))]
        public string SaveOrUpdateProducto(ProductInDTO productInDTO)
        {
            return _productoSaveAppService.SaveOrUpdate(productInDTO);
        }

        [HttpGet]
        [Route(nameof(ProductoController.GetAll))]
        public List<producto> GetAll()
        {
            return _productoGetAppService.GetAll();
        }

        [HttpGet]
        [Route(nameof(ProductoController.GetStock))]
        public ProductoStock GetStock(Guid idProducto)
        {
            return _productoGetAppService.GetProductStock(idProducto);
        }

        [HttpGet]
        [Route(nameof(ProductoController.GetByCategory))]
        public List<producto> GetByCategory(Guid idCategory)
        {
            return _productoGetAppService.GetByCategory(idCategory);
        }

        [HttpGet]
        [Route(nameof(ProductoController.GetById))]
        public producto GetById(Guid idProducto)
        {
            return _productoGetAppService.GetById(idProducto);
        }

    }
}
