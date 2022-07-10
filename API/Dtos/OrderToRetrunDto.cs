using Core.Models.OrderAggregate;

namespace API.Dtos
{
    public class OrderToRetrunDto
    {
        public int Id { get; set; }
        public string? BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public Address ShipToAddress { get; set; }
        public string? DeliveryMethod { get; set; }
        public decimal ShippingPrice { get; set; }
        public IReadOnlyList<OrderItemDto> OrderItems { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string? Status { get; set; }
    }
}