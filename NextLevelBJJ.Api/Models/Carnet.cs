using System;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Api.Models
{
    public class Carnet
    {
        public Guid CarnetId { get; set; }

        public string Name { get; set; }

        public int EntrenceAmount { get; set; }

        public int LeftEntrences { get; set; }

        public DateTime LastTraining { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}