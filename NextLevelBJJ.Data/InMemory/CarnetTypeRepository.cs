using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Logic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class CarnetTypeRepository : ICarnetTypeRepository
    {
        private List<CarnetType> carnetTypes = new List<CarnetType>()
        {
            new CarnetType{ CarnetTypeId = 1, CarnetName = "Osiem wejść", EntrenceAmount = 8 },
            new CarnetType{ CarnetTypeId = 2, CarnetName = "Bez limitu wejść", EntrenceAmount = 100 },
            new CarnetType{ CarnetTypeId = 3, CarnetName = "Dziecięcy", EntrenceAmount = 8 }
        };

        public Task<CarnetType> Get(int carnetTypeId)
        {
            return Task.FromResult(carnetTypes.FirstOrDefault(c => c.CarnetTypeId == carnetTypeId));
        }

        public Task<List<CarnetType>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}