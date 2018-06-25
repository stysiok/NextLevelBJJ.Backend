using NextLevelBJJ.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.Mappers
{
    public class Mapper
    {
        public User Map(Core.Models.User user)
        {
            return new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Surname = user.Surname,
                CarnetId = user.CarnetId
            };
        }

        public Carnet Map(Core.Models.Carnet carnet, Core.Models.CarnetType carnetType)
        {
            return new Carnet
            {
                CarnetId = carnet.CarnetId,
                Name = carnetType.CarnetName,
                LeftEntrences = carnet.LeftEntrences,
                EntrenceAmount = carnetType.EntrenceAmount,
                ExpirationDate = carnet.ExpirationDate,
                LastTraining = carnet.LastTraining,

            };
        }
    }
}
