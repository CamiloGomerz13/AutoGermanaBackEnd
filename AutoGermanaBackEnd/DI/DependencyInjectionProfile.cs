using AutoGermanaBackEnd.Application;
using AutoGermanaBackEnd.Application.Contracts;
using AutoGermanaBackEnd.Domain;
using AutoGermanaBackEnd.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.DI
{
    public class DependencyInjectionProfile
    {
        public static void RegisterProfile(IServiceCollection services)
        {
            #region Domain

            services.AddScoped<IProductosSaveDomainService, ProductoDomainService>();
            services.AddScoped<ICategoriaSaveDomainService, CategoriaDomainService>();
            services.AddScoped<IProductoGetDomainService, ProductoDomainService>();
            services.AddScoped<ICategoriaGetDomainService, CategoriaDomainService>();

            #endregion

            #region

            services.AddScoped<IProductoSaveAppService, ProductoAppService>();
            services.AddScoped<ICategoriaSaveAppService, CategoriaAppService>();
            services.AddScoped<IProductoGetAppService, ProductoAppService>();
            services.AddScoped<ICategoriaGetAppService, CategoriaAppService>();

            #endregion
        }
    }
}
