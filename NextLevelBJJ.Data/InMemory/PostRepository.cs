using System;
using System.Collections.Generic;
using NextLevelBJJ.Core.Models;
using NextLevelBJJ.Core.Logic;
using System.Threading.Tasks;
using System.Linq;

namespace NextLevelBJJ.Data.InMemory
{
    public class PostRepository : IPostRepository
    {
        private List<Post> posts = new List<Post>()
        {
            new Post
            {
                PostId = Guid.Parse("42332b41-5dac-4b07-bf76-09b0a4b31896"),
                Author = "Paweł T.",
                CreationDate = DateTime.Now.AddDays(-4),
                Title = "Przywozimy medale z mistrzostw",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "https://scontent-frt3-2.xx.fbcdn.net/v/t1.0-9/32078280_1090516034431166_8441412746003611648_n.jpg?_nc_cat=0&oh=7f5091e5de19d7261f8fb92d393a0df4&oe=5C10B101"

            },
            new Post
            {
                PostId = Guid.Parse("2a893994-b6eb-4cac-9db0-1398d45817a0"),
                Author = "Grzegorz",
                CreationDate = DateTime.Now.AddDays(-3),
                Title = "Next Level Cup już wkrótce",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Porta non pulvinar neque laoreet. Et tortor consequat id porta nibh. Amet tellus cras adipiscing enim eu turpis. Dui vivamus arcu felis bibendum ut. Vel pharetra vel turpis nunc eget.",
                Image = "https://scontent-frt3-2.xx.fbcdn.net/v/t1.0-9/36732407_1137356256413810_8780381976004657152_o.jpg?_nc_cat=0&oh=bf046b6c08061d4ddaeb407e4fdda085&oe=5BC618F3"
            },
            new Post
            {
                PostId = Guid.Parse("5701d6c9-9fbc-4321-8fed-e03c798d48ce"),
                Author = "Paweł K.",
                CreationDate = DateTime.Now.AddDays(-1),
                Title = "Nowy nabór do grup początkujących",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ullamcorper malesuada proin libero nunc consequat interdum varius sit. Varius vel pharetra vel turpis. Consectetur adipiscing elit pellentesque habitant morbi tristique senectus.",
                Image = "https://scontent-frt3-2.xx.fbcdn.net/v/t1.0-9/36698222_1136165039866265_4707314341446156288_n.jpg?_nc_cat=0&oh=aaab40131df6722974e17586598890d7&oe=5BD066F8"
            },
        };

        public Task<Post> Get(string postGuid)
        {
            Guid providedGuid;

            try
            {
                providedGuid = Guid.Parse(postGuid);
            }
            catch (Exception)
            {
                throw;
            }

            return Task.FromResult(posts.FirstOrDefault(p => p.PostId.Equals(providedGuid)));
        }

        public Task<List<Post>> GetAll()
        {
            return Task.FromResult(posts);
        }
    }
}