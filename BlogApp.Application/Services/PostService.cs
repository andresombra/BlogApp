using BlogApp.Application.Interfaces;
using BlogApp.Domain.Entities;
using BlogApp.Domain.Interfaces;
using BlogApp.Domain.Interfaces.BlogApp.Domain.Interfaces;

namespace BlogApp.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _postRepository.GetAllAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _postRepository.GetByIdAsync(id);
        }

        public async Task<Post> CreatePost(Post post)
        {
            await _postRepository.AddAsync(post);
            await _postRepository.SaveChangesAsync();

            return post;
        }

        public async Task<Post> UpdatePost(Post post)
        {
            _postRepository.Update(post);
            await _postRepository.SaveChangesAsync();
            return post;
        }

        public async Task DeletePost(int id)
        {
            var post = await _postRepository.GetByIdAsync(id);
            if (post != null)
            {
                _postRepository.Remove(post);
                await _postRepository.SaveChangesAsync();
            }
        }
    }
}
