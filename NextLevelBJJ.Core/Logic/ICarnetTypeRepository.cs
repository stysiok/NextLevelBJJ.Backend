using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface ICarnetTypeRepository
    {
        Task<CarnetType> Get(int carnetTypeId);

        Task<List<CarnetType>> GetAll();
    }
}