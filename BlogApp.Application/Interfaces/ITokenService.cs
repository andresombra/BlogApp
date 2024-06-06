using BlogApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateToken(User user);
    }
}
