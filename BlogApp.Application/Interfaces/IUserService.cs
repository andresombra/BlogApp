using BlogApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> Register(User user);
        Task<User> Authenticate(string username, string password);
    }
}
