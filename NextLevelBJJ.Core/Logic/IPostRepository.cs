using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface IPostRepository
    {
        Task<Post> Get(string postGuid);
        Task<List<Post>> GetAll();
    }
}