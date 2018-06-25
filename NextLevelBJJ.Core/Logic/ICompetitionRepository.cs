using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;
using System;

namespace NextLevelBJJ.Core.Logic
{
    public interface ICompetitionRepository
    {
        Task<Competition> Get(string competitionGuid);

        Task<Competition> Get(Guid competitionGuid);

        Task<List<Competition>> GetAll();

        Task<List<Competition>> GetCompetitionsForDate(DateTime? date);

    }
}