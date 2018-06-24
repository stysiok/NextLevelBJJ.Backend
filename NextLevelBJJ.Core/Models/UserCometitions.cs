using System;

namespace NextLevelBJJ.Core.Models
{
    public class UserCompetitions
    {
        public Guid UserId { get; set; }

        public Guid CompetitionId { get; set; }

        public DateTime SigningDate { get; set; }
    }
}