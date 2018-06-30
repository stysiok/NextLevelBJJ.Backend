using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Core.Models;

namespace NextLevelBJJ.Core.Logic
{
    public interface ICarnetRepository
    {
        Task<Carnet> GetUserCarnet(Guid carnetGuid);
    }
}