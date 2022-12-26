using System;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class Car
    {
        public string Firm { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public double EngineVolume { get; set; }
        public int EnginePower { get; set; }
        public FuelType FuelType { get; set; }
        public Enums.DriveType DriveType { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public string SaleCity { get; set; }
        public string Description { get; set; }
        public CarColor Color { get; set; }
        public User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
