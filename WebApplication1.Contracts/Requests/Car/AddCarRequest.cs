using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Contracts.Requests.Car
{
    public class AddCarRequest
    {
        public string Firm { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public double EngineVolume { get; set; }
        public int EnginePower { get; set; }
        public string FuelType { get; set; }
        public string DriveType { get; set; }
        public string TransmissionType { get; set; }
        public string SaleCity { get; set; }
        public string? Description { get; set; }
        public string Color { get; set; }
    }
}
