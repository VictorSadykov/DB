using AutoMapper;
using WebApplication1.Contracts.Requests.Car;
using WebApplication1.Contracts.Views;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Models.Car, CarView>().ForMember(cv => cv.UserId, opt => opt.MapFrom(c => c.UserId));

            CreateMap<AddCarRequest, Data.Models.Car>();
            
        }
    }
}
