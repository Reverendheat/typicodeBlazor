using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using TypiCodeTestingAPI.Data;

namespace TypiCodeTestingAPI.Services
{
    public class PostDataService : IPostDataService
    {
        public readonly HttpClient _httpClient;


        public PostDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Post>>
                (await _httpClient.GetStreamAsync($"posts"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
