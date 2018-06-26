using GraphQL.Types;
using NextLevelBJJ.Api.GraphQLExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.InputTypes
{
    public class CompetitionInputType : InputObjectGraphType
    {
        public CompetitionInputType()
        {
            Name = "CompetitionInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("town");
            Field<NonNullGraphType<OriginalDateGraphType>>("date");
            Field<NonNullGraphType<OriginalDateGraphType>>("time");
            Field<NonNullGraphType<StringGraphType>>("competitionType");
        }
    }
}
