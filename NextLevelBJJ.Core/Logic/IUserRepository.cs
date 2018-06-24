using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface IUserRepository
    {
        Task<User> GetUserByGuid(string userGuid);
    }
}