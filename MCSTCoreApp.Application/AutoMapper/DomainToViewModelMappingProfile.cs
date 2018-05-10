using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using MCSTCoreApp.Application.ViewModels.Product;
using MCSTCoreApp.Application.ViewModels.System;
using MCSTCoreApp.Data.Entities;

namespace MCSTCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            CreateMap<Bill, BillViewModel>();
            CreateMap<BillDetail, BillDetailViewModel>();
            CreateMap<Color, ColorViewModel>();
            CreateMap<Size, SizeViewModel>();

        }
    }
}
