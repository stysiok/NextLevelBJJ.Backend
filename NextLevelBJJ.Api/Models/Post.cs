using System;

namespace NextLevelBJJ.Api.Models
{
    public class Post
    {
        public Guid PostId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }
    }
}