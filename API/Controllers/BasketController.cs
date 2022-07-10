using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository basketRepository;
        private readonly IMapper mapper;
        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await this.basketRepository.GetBasketAsync(id);
            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = this.mapper.Map<CustomerBasketDto, CustomerBasket>(basket);
            var updateBasket = this.basketRepository.UpdateBasketAsync(customerBasket);
            return Ok(updateBasket);
        }

        [HttpDelete]

        public async Task DeleteBasketAsync(string id)
        {
            await this.basketRepository.DeleteBasketAsync(id);
        }
    }
}