using GraphQL.Types;
using NextLevelBJJ.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.Types
{
    public class DinnerType : ObjectGraphType<Dinner>
    {
        public DinnerType()
        {
            Name = "Dinner";
            Description = "sdansdlaskdnalkdnas";
            Field(c => c.dinnerid, type: typeof(IdGraphType));
            Field(c => c.meal);
            Field(c => c.nealcount);
            Field(c => c.owner);
        }
    }
}
