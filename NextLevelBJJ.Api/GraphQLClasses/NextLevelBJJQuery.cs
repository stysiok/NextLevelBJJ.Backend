using System;
using GraphQL;
using GraphQL.Types;
using NextLevelBJJ.Api.Types;
using NextLevelBJJ.Core.Logic;
using NextLevelBJJ.Api.Mappers;
using NextLevelBJJ.Api.Models;

namespace NextLevelBJJ.Api.GraphQLClasses
{
    public class NextLevelBJJQuery : ObjectGraphType
    {
        Mapper mapper;
        public NextLevelBJJQuery(IUserRepository userRepository)
        {
            mapper = new Mapper();
            Name = "Query";
            Field<UserType>(
                "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "guid", Description = "Guid of the user" }
                ),
                resolve: ctx => {
                    var stringGuid = ctx.GetArgument<string>("guid");
                    var user = userRepository.GetUserByGuid(stringGuid);
                    
                    var mapped = mapper.Map(user.Result);

                    return mapped;
                }
            );
        }
    }
}