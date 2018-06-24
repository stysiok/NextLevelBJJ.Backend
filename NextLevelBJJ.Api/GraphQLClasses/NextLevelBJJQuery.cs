using System;
using GraphQL;
using GraphQL.Types;
using NextLevelBJJ.Api.Mappers;
using NextLevelBJJ.Api.Types;
using NextLevelBJJ.Core.Logic;

namespace NextLevelBJJ.Api.GraphQLClasses
{
    public class NextLevelBJJQuery : ObjectGraphType
    {
        public NextLevelBJJQuery(IUserRepository userRepository)
        {
            Name = "Query";
            Field<UserType>(
                "user",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "guid", Description = "Guid of the user" }
                ),
                resolve: ctx => {
                    var stringGuid = ctx.GetArgument<string>("guid");
                    var user = userRepository.GetUserByGuid(stringGuid);
                    var mapper = new Mapper();
                    var userMapped = mapper.Map(user.Result);

                    return userMapped;
                }
            );
        }
    }
}