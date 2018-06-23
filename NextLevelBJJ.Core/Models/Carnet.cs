using System;

namespace NextLevelBJJ.Core.Models
{
    public class Carnet
    {
        public Guid CarnetId { get; set; }

        public int CarnetTypeId { get; set; }

        public int LeftEntrences { get; set; }

        public DateTime LastTraining { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}