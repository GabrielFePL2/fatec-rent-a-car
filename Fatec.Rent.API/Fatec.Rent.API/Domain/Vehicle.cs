namespace Fatec.Rent.API.Domain
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Model { get; set; }
        public int Passengers { get; set; }
        public string Fuel { get; set; }
        public decimal Price { get; set; }
    }
}