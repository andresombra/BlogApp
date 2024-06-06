using BlogApp.Domain.Entities;
using BlogApp.Domain.Interfaces;
using BlogApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
        }
    }
}
