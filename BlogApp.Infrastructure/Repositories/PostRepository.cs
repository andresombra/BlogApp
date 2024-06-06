using BlogApp.Domain.Entities;
using BlogApp.Domain.Interfaces;
using BlogApp.Domain.Interfaces.BlogApp.Domain.Interfaces;
using BlogApp.Infrastructure.Data;

namespace BlogApp.Infrastructure.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
