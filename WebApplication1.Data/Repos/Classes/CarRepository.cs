using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using WebApplication1.Data.Models;
using WebApplication1.Data.Repos.Interfaces;

namespace WebApplication1.Data.Repos.Classes
{
    public class CarRepository : ICarRepository
    {
        private readonly DataBaseContext _context;

        public CarRepository(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Car[]> GetCars()
        {
            return await _context.Cars
                .Include(c => c.User)
                .ToArrayAsync();
        }

        public async Task<Car> GetCarById(Guid id)
        {
            return await _context.Cars
                .Include(c => c.User)
                .FirstOrDefaultAsync(car => car.Id == id);
                
        }

        public async Task<Car[]> GetCarsByUserId(Guid id)
        {
            return await _context.Cars
                .Include(c => c.User)
                .Where(c => c.User.Id == id)
                .ToArrayAsync();
        }

        public async Task SaveCar(Car car, User user)
        {
            car.UserId = user.Id;
            car.User = user;

            var entry = _context.Entry(car);
            if (entry.State == EntityState.Detached)
            {
                await _context.Cars.AddAsync(car);
            }

            await _context.SaveChangesAsync();
        }
    }
}
