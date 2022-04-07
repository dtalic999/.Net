using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string? Id { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}