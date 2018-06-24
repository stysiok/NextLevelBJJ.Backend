using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface IUserCompetitionRepository
    {
        Task<List<Competition>> GetUserCompetitions(string userGuid);
    }
}