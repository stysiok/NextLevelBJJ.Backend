using System;

namespace NextLevelBJJ.Core.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Guid CarnetId { get; set; }
    }
}