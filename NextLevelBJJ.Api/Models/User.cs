using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Api.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Guid CarnetId { get; set; }

        public Carnet Carnet { get; set; }

        public IEnumerable<Competition> Competitions { get; set; }
    }
}