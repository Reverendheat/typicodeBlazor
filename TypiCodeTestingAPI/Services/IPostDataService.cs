using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TypiCodeTestingAPI.Data;

namespace TypiCodeTestingAPI.Services
{
    public interface IPostDataService
    {
        Task<IEnumerable<Post>> GetAllPosts();
    }
}
