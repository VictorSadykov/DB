using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repos.Interfaces
{
    public interface IUserRepository
    {
        Task<User[]> GetUsers();
        Task<User> GetUserById(Guid id);
    }
}
