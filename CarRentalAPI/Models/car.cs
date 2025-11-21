namespace CarRentalAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Transmission { get; set; }
        public decimal PricePerDay { get; set; }
        public string? ImageUrl { get; set; }
    }
}
