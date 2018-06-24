using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class PostsRepository
    {
        private List<Post> posts = new List<Post>()
        {
            new Post
            {
                PostId = Guid.Parse("42332b41-5dac-4b07-bf76-09b0a4b31896"),
                CreationDate = DateTime.Now.AddDays(-4),
                Title = "Przywozimy medale z mistrzostw",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            },
            new Post
            {
                PostId = Guid.Parse("2a893994-b6eb-4cac-9db0-1398d45817a0"),
                CreationDate = DateTime.Now.AddDays(-3),
                Title = "Next Level Cup już wkrótce",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Porta non pulvinar neque laoreet. Et tortor consequat id porta nibh. Amet tellus cras adipiscing enim eu turpis. Dui vivamus arcu felis bibendum ut. Vel pharetra vel turpis nunc eget.",
            },
            new Post
            {
                PostId = Guid.Parse("5701d6c9-9fbc-4321-8fed-e03c798d48ce"),
                CreationDate = DateTime.Now.AddDays(-1),
                Title = "Nowy nabór do grup początkujących",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ullamcorper malesuada proin libero nunc consequat interdum varius sit. Varius vel pharetra vel turpis. Consectetur adipiscing elit pellentesque habitant morbi tristique senectus.",
            },
        };

    }
}