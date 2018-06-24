using System;

namespace NextLevelBJJ.Api.Models
{
    public class Competition
    {
        public Guid CompetitionId { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public DateTime DateAndTime { get; set; }

        public string CompetitionType { get; set; }

        public int NumberOfSignedUsers { get; set; }
    }
}