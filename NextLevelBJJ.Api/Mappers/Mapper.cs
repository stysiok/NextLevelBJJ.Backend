using NextLevelBJJ.Api.Models;
using NextLevelBJJ.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.Mappers
{
    public class Mapper
    {
        public Models.User Map(Core.Models.User user)
        {
            return new Models.User()
            {
                UserId = user.UserId,
                Name = user.Name,
                Surname = user.Surname
            };
        }
    }
}
