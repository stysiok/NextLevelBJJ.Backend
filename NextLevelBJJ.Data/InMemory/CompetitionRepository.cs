using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;
using NextLevelBJJ.Core.Logic;
using System.Threading.Tasks;
using System.Linq;

namespace NextLevelBJJ.Data.InMemory
{
    public class CompetitionRepository : ICompetitionRepository
    {
        private List<Competition> competitions = new List<Competition>()
        {
            new Competition
            {
              CompetitionId = Guid.Parse("648aa7d3-caf5-4428-8dac-131b1ff4c415"),
              CompetitionType = "Gi",
              Name = "Mistrzostwa Polski Gi Luboń 2018",
              Town = "Luboń",
              DateAndTime = new DateTime(2018, 07, 28, 15, 00, 00)
            },
            new Competition
            {
              CompetitionId = Guid.Parse("95274656-71e6-47a4-9c6c-a0f71ff807bf"),
              CompetitionType = "Adcc",
              Name = "Mistrzostwa Polski Adcc",
              Town = "Warszawa",
              DateAndTime = new DateTime(2018, 07, 15, 10, 00, 00)
            },
            new Competition
            {
              CompetitionId = Guid.Parse("895bd674-bc1a-4085-ba78-27a71a35f178"),
              CompetitionType = "No-Gi",
              Name = "Mistrzostwa Polski No-Gi Luboń 2018",
              Town = "Luboń",
              DateAndTime = new DateTime(2018, 07, 26, 12, 00, 00)
            },
            new Competition
            {
              CompetitionId = Guid.Parse("e32dc5c9-6a4b-40f5-bdc1-cb72474bb812"),
              CompetitionType = "Gi i No-Gi",
              Name = "Next Level Cup",
              Town = "Opole",
              DateAndTime = new DateTime(2018, 07, 15, 09, 30, 00)
            },
            new Competition
            {
              CompetitionId = Guid.Parse("e0488748-7cf6-4524-8c23-b696f390ab51"),
              CompetitionType = "Gi",
              Name = "Mistrzostwa Akademickie",
              Town = "Poznań",
              DateAndTime = new DateTime(2018, 07, 06, 11, 00, 00)
            },
        };

        public Task<Competition> Add(Competition competition)
        {
            competition.CompetitionId = Guid.NewGuid();

            competitions.Add(competition);

            return Task.FromResult(competition);
        }

        public Task<Competition> Get(string competitionGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Competition> Get(Guid competitionGuid)
        {
            return Task.FromResult(competitions.FirstOrDefault(c => c.CompetitionId.Equals(competitionGuid)));
        }

        public Task<List<Competition>> GetAll()
        {
            return Task.FromResult(competitions);
        }

        public Task<List<Competition>> GetCompetitionsForDate(DateTime? date)
        {
            return Task.FromResult(competitions.Where(c => c.DateAndTime.Date == date?.Date).ToList());
        }

        
    }
}