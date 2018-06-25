using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface ICompetitionRepository
    {
        Task<Competition> Get(string competitionGuid);

        Task<List<Competition>> GetCompetitionsForDate(string date);

    }
}