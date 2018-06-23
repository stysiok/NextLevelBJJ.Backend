using System;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Api
{
    public class Carnet
    {
        public Guid CarnetId { get; set; }

        public CarnetType CarnetType { get; set; }

        public int LeftEntrences { get; set; }

        public DateTime LastTraining { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}