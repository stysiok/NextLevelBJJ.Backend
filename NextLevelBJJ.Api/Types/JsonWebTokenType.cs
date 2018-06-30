using GraphQL.Types;
using NextLevelBJJ.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.Types
{
    public class JsonWebTokenType : ObjectGraphType<JsonWebToken>
    {
        public JsonWebTokenType()
        {
            Name = "JsonWebToken";
            Description = "Token to authorize operations";
            Field(x => x.Token).Description("Generated token");
        }
    }
}
