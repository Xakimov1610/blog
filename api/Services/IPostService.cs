using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using api.Entities;

namespace api.Services
{
    public interface IPostService
    {
        Task<(bool IsSucces, Exception Exception)> InsertPostAsync(Post post);
        Task<List<Post>> GetPostsAsync();
        Task<Post> GetPostByIdAsync(Guid id);
        Task<(bool IsSucces, Exception Exception)> UpdatePostAsync(Post post);
    }
}