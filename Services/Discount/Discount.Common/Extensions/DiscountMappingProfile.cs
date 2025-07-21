using AutoMapper;
using Discount.Common.DTOs;
using Discount.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Common.Extensions
{
    public class DiscountMappingProfile : Profile
    {
        public DiscountMappingProfile()
        {
            CreateMap<CouponDTO, Coupon>().ReverseMap();
        }
    }

}
