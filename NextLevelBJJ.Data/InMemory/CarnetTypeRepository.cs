using System.Collections.Generic;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Data.InMemory
{
    public class CarnetTypeRepository
    {
        private List<CarnetType> carnetTypes = new List<CarnetType>()
        {
            new CarnetType{ CarnetTypeId = 1, CarnetName = "Osiem wejść", EntrenceAmount = 8 },
            new CarnetType{ CarnetTypeId = 2, CarnetName = "Bez limitu wejść", EntrenceAmount = 100 },
            new CarnetType{ CarnetTypeId = 3, CarnetName = "Dziecięcy", EntrenceAmount = 8 }
        };

    }
}