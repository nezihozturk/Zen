using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zen.Entities.Concrete;
using Zen.Mvc.Models;

namespace Zen.Mvc.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<Product, ProductListViewModel>()
            //    .ForMember(dest=>dest.CategoryName, opt =>
            //    {
            //        opt.MapFrom(src=>src.CategoryId.ToString());
            //    });
        }

        
    }
}
