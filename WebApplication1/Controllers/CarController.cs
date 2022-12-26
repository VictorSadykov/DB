using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts.Requests.Car;
using WebApplication1.Contracts.Responses.Car;
using WebApplication1.Contracts.Views;
using WebApplication1.Data.Models;
using WebApplication1.Data.Repos.Interfaces;
using WebApplication1.Contracts.Exceptions;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private ICarRepository _carRepo;
        private IUserRepository _userRepo;
        private IMapper _mapper;
        //private Mapper _mapper;

        public CarController(ICarRepository carRepo, IMapper mapper)
        {
            _carRepo = carRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetCars()
        {
            var cars = await _carRepo.GetCars();

            var resp = new GetCarsResponse
            {
                CarsAmount = cars.Length,
                Cars = _mapper.Map<Car[], CarView[]>(cars)
            };

            return StatusCode(200, resp);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCarById([FromRoute] Guid id)
        {
            var car = await _carRepo.GetCarById(id);

            var resp = _mapper.Map<Car, CarView>(car);

            return StatusCode(200, resp);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Add(Guid userId, AddCarRequest carRequest)
        {

            try
            {
                var user = await _userRepo.GetUserById(userId);
                var newCar = _mapper.Map<AddCarRequest, Car>(carRequest);
                await _carRepo.SaveCar(newCar, user);

                return StatusCode(201, $"{carRequest.Firm} {carRequest.Model} {carRequest.Year} года добавлена на продажу! Идентификатор: {newCar.Id}");
            }
            catch (NullReferenceException)
            {
                return StatusCode(400, $"Пользователь по такому Id не найден. ({userId})");
            }    

            
        }
    }
}
