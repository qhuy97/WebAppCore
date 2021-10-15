using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Application.ViewModels.Product;
using WebAppCore.Data.Entities;

namespace WebAppCore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
