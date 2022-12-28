using AutoGermanaBackEnd.DTOs;
using AutoGermanaBackEnd.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            FromProductoToProductoInDTO();
            FromCategoriaToCategoriaInDTO();
            FromProductoToProductoStock();
            FromCategroiaToCategoriaOutDTO();
        }

        private void FromProductoToProductoInDTO()
        {
            CreateMap<ProductInDTO, producto>()
                .ForMember(target => target.idproducto, opt => opt.MapFrom((source, target) =>
                {
                    if (source.idProducto.HasValue)
                    {
                        return source.idProducto.Value;
                    }
                    return Guid.NewGuid();
                }
                ))
                .ForMember(target => target.idcategoria, opt => opt.MapFrom(source => source.idCategoria))
                .ForMember(target => target.estado , opt => opt.MapFrom(source => source.estado))
                .ForMember(target => target.codigo, opt => opt.MapFrom(source => source.codigo))
                .ForMember(target => target.descripcion, opt => opt.MapFrom(source => source.descripcion))
                .ForMember(target => target.nombre, opt => opt.MapFrom(source => source.nombre))
                .ForMember(target => target.precio_venta, opt => opt.MapFrom(source => source.precio))
                .ForMember(target => target.stock, opt => opt.MapFrom(source => source.stock));
        }

        private void FromCategoriaToCategoriaInDTO()
        {
            CreateMap<CategoriaInDTO, categoria>()
            .ForMember(target => target.idcategoria, opt => opt.MapFrom((source, target) =>
            {
                if (source.idCategoria.HasValue)
                {
                    return source.idCategoria.Value;
                }
                return Guid.NewGuid();
            }
            ))
            .ForMember(target => target.descripcion, opt => opt.MapFrom(source => source.descripcion))
            .ForMember(target => target.estado, opt => opt.MapFrom(source => source.estado))
            .ForMember(target => target.nombre, opt => opt.MapFrom(source => source.nombre));
        }

        private void FromProductoToProductoStock()
        {
            CreateMap<producto, ProductoStock>()
                .ForMember(target => target.nombreProducto, opt => opt.MapFrom(source => source.nombre))
                .ForMember(target => target.stock, opt => opt.MapFrom(source => source.stock));
        }

        private void FromCategroiaToCategoriaOutDTO()
        {
            CreateMap<categoria, CategoriaOutDTO>()
                .ForMember(target => target.idCategoria, opt => opt.MapFrom(source => source.idcategoria))
                .ForMember(target => target.nombre, opt => opt.MapFrom(source => source.nombre));
        }
    }
}
