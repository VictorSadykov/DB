using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Contracts.Views;

namespace WebApplication1.Contracts.Responses.Car
{
    public class GetCarsResponse
    {
        public int CarsAmount { get; set; }
        public CarView[] Cars { get; set; }
    }
}
