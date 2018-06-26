using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.InputModels
{
    public class CompetitionInput
    {
        public Guid CompetitionId { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string CompetitionType { get; set; }
    }
}
