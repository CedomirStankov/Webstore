﻿using Discount.Common.DTOs;
using Discount.Common.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Discount.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly ICouponRepository _repository;

        public DiscountController(ICouponRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{productName}")]
        [ProducesResponseType(typeof(CouponDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(void), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CouponDTO>> GetDiscount(string productName)
        {
            var coupon = await _repository.GetDiscount(productName);
            if(coupon == null)
            {
                return NotFound();
            }
            return Ok(coupon);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CouponDTO), StatusCodes.Status201Created)]
        public async Task<ActionResult<CouponDTO>> CreateDiscount([FromBody] CreateCouponDTO couponDto)
        {
            await _repository.CreateDiscount(couponDto);
            var coupon = await _repository.GetDiscount(couponDto.ProductName);
            return CreatedAtRoute("GetDiscount", new { productName = coupon.ProductName }, coupon);
        }

        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> UpdateDiscount([FromBody] UpdateCouponDTO coupon)
        {
            return Ok(await _repository.UpdateDiscount(coupon));
        }

        [HttpDelete("{productName}", Name = "DeleteDiscount")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> DeleteDiscount(string productName)
        {
            return Ok(await _repository.DeleteDiscount(productName));
        }

    }
}
