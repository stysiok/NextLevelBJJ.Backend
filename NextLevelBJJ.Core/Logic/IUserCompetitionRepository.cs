using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface IUserCompetitionsRepository
    {
        Task<List<UserCompetitions>> GetUserCompetitions(string userGuid);
    }
}