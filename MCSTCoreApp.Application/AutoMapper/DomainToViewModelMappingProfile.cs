using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MCSTCoreApp.Application.ViewModels.Product;
using MCSTCoreApp.Data.Entities;

namespace MCSTCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
