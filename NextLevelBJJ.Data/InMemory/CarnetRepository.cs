using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Logic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class CarnetRepository : ICarnetRepository
    {
        private List<Carnet> carnets = new List<Carnet>()
        {
            new Carnet
            {
                CarnetId = Guid.Parse("988a9a93-e9cc-41d6-9c86-3c3177cea5f1"),
                CarnetTypeId = 1,
                ExpirationDate = DateTime.Now.AddDays(10),
                LastTraining = DateTime.Now.AddDays(-5),
                LeftEntrences = 5
            },
            new Carnet
            {
                CarnetId = Guid.Parse("34418698-f406-49d7-87d2-c237ad865519"),
                CarnetTypeId = 2,
                ExpirationDate = DateTime.Now.AddDays(15),
                LastTraining = DateTime.Now.AddDays(-2),
                LeftEntrences = 95
            },
            new Carnet
            {
                CarnetId = Guid.Parse("e371d29a-f14e-4c01-8b9e-b54fe6d73b8d"),
                CarnetTypeId = 1,
                ExpirationDate = DateTime.Now.AddDays(3),
                LastTraining = DateTime.Now.AddDays(-10),
                LeftEntrences = 1
            },
            new Carnet
            {
                CarnetId = Guid.Parse("2c65a289-28e7-4e3f-b074-5d8089f2a349"),
                CarnetTypeId = 3,
                ExpirationDate = DateTime.Now.AddDays(6),
                LastTraining = DateTime.Now.AddDays(-1),
                LeftEntrences = 2
            },
        };

        public Task<Carnet> GetUserCarnet(string carnetGuid)
        {
            Guid providedGuid;

            try
            {
                providedGuid = Guid.Parse(carnetGuid);
            }
            catch(Exception ex)
            {
                
            }

            return Task.FromResult(carnets.FirstOrDefault(u => u.CarnetId.Equals(providedGuid)));
        }
    }
}