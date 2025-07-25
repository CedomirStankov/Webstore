﻿using Discount.Common.Data;
using Discount.Common.DTOs;
using Discount.Common.Repositories;
using Discount.Common.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Discount.Common.Extensions
{
    public static class DiscountCommonExtensions
    {
        public static void AddDiscountCommonServices(this IServiceCollection services)
        {
            services.AddScoped<ICouponContext, CouponContext>();
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddAutoMapper(typeof(DiscountMappingProfile));
        }
    }
}
