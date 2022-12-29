using AutoGermanaBackEnd.Application.Contracts;
using AutoGermanaBackEnd.Domain.Contracts;
using AutoGermanaBackEnd.DTOs;
using AutoGermanaBackEnd.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Application
{
    public class ProductoAppService : IProductoSaveAppService, IProductoGetAppService
    {
        private readonly IProductosSaveDomainService _productosSaveDomainService;
        private readonly IProductoGetDomainService  _productoGetDomainService;
        private readonly IMapper mapper;

        public ProductoAppService(IProductosSaveDomainService productosSaveDomainService,
                                  IMapper mapper,
                                  IProductoGetDomainService productoGetDomainService)
        {
            _productosSaveDomainService = productosSaveDomainService;
            this.mapper = mapper;
            _productoGetDomainService = productoGetDomainService;
        }

        public List<ProductoWCatDTO> GetAll()
        {
            List<ProductoWCatDTO> productos = mapper.Map<List<producto>,List<ProductoWCatDTO>>(_productoGetDomainService.GetAll().ToList());
            return productos;
        }

        public List<ProductoWCatDTO> GetByCategory(Guid idCategory)
        {
            List<ProductoWCatDTO> productos = mapper.Map<List<producto>, List<ProductoWCatDTO>>(_productoGetDomainService.GetByCategory(idCategory).ToList());
            return productos;
        }

        public producto GetById(Guid idProducto)
        {
            return _productoGetDomainService.GetByID(idProducto);
        }

        public ProductoStock GetProductStock(Guid idProducto)
        {
            ProductoStock stock = mapper.Map<producto, ProductoStock>(_productoGetDomainService.GetProductStock(idProducto));
            return stock;
        }

        public string SaveOrUpdate(ProductInDTO productInDTO)
        {
            try
            {
                producto producto = mapper.Map<ProductInDTO, producto>(productInDTO);
                if (productInDTO.idproducto.HasValue)
                {
                    _productosSaveDomainService.Update(producto);
                    return "El producto se ha actualizado correctamente";
                }
                _productosSaveDomainService.Save(producto);
                return "El producto se ha creado correctamente";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void updateState(Guid idProducto)
        {
            producto producto = _productoGetDomainService.GetByID(idProducto);
            producto.estado = !producto.estado;
            _productosSaveDomainService.Update(producto);
        }
    }
}
