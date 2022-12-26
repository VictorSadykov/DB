using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    [Table("Photos")]
    public class Photo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Path { get; set; }
        public Guid CarId { get; set; }
        public Car Car { get; set; }
    }
}
