using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data.Models;
using WebApplication1.Data.Repos.Interfaces;

namespace WebApplication1.Data.Repos.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;

        public UserRepository(DataBaseContext context)
        {
            _context = context;

        }

        public async Task<User> GetUserById(Guid id)
        {
            return await _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<User[]> GetUsers()
        {
            return await _context.Users
                .ToArrayAsync();
        }
    }
}
