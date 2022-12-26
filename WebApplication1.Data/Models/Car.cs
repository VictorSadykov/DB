using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    [Table("Cars")]
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Firm { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
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
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
