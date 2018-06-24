using System;
using GraphQL;
using GraphQL.Types;

namespace NextLevelBJJ.Api.GraphQLClasses
{
    public class NextLevelBJJSchema : Schema
    {
        public NextLevelBJJSchema(Func<Type, GraphType> resolve) : base(resolve)
        {
            Query = (NextLevelBJJQuery)resolve(typeof(NextLevelBJJQuery));
        }
    }
}