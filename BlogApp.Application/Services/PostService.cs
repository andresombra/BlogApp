using BlogApp.Application.Interfaces;
using BlogApp.Domain.Entities;
using BlogApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.SignalR;

namespace BlogApp.Application.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;
        //private readonly IHubContext<NotificationHub> _hubContext;

        //public PostService(ApplicationDbContext context, IHubContext<NotificationHub> hubContext)
        //{
        //    _context = context;
        //    _hubContext = hubContext;
        //}

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _context.Posts.Include(p => p.User).ToListAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _context.Posts.Include(p => p.User).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Post> CreatePost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            //await _hubContext.Clients.All.SendAsync("ReceiveNotification", "New post created");

            return post;
        }

        public async Task<Post> UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
            }
        }
    }
}
