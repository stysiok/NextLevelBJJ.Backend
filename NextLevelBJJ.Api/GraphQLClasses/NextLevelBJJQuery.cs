using System;
using GraphQL;
using GraphQL.Types;
using NextLevelBJJ.Api.Types;
using NextLevelBJJ.Core.Logic;
using NextLevelBJJ.Api.Mappers;
using NextLevelBJJ.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using NextLevelBJJ.Api.GraphQLExtensions;

namespace NextLevelBJJ.Api.GraphQLClasses
{
    public class NextLevelBJJQuery : ObjectGraphType
    {
        Mapper _mapper;
        JwtFactory _jwtFactory;
        public NextLevelBJJQuery(IUserRepository userRepository, IPostRepository postRepository, ICompetitionRepository competitionRepository)
        {
            _mapper = new Mapper();

            Name = "Query";

            Field<BooleanGraphType>(
                "isTokenValid",
                description: "asd das das",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "token", Description = "Your token" }
                ),
                resolve: ctx =>
                {
                    var ob = new JsonWebToken { JsonWebTokenId = Guid.NewGuid(), Token = "adsadsdaSDasd" };

                    return ob;
                });

            Field<UserType>(
                "user",
                description: "Get student in the Next Level BJJ club by his guid",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userGuid", Description = "Guid of the user" }
                ),
                resolve: ctx =>
                {
                    var stringGuid = ctx.GetArgument<string>("userGuid");
                    var user = userRepository.GetUserByGuid(stringGuid);

                    var mapped = _mapper.Map(user.Result);

                    return mapped;
                }
            );

            Field<PostType>(
                "post",
                description: "Get post by its guid",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "postGuid", Description = "Guid of the post" }
                ),
                resolve: ctx =>
                {
                    var stringGuid = ctx.GetArgument<string>("postGuid");

                    var post = postRepository.Get(stringGuid);

                    var mapped = _mapper.Map(post.Result);

                    return mapped;

                }
            );

            Field<ListGraphType<PostType>>(
                "posts",
                description: "Get all posts",
                resolve: ctx =>
                {
                    var posts = postRepository.GetAll();

                    var mapped = _mapper.Map(posts.Result);

                    return mapped;

                });

            Field<ListGraphType<CompetitionType>>(
                "competitions",
                description: "Get all competitions",
                arguments: new QueryArguments(
                    new QueryArgument<OriginalDateGraphType>() { Name = "competitionDate", Description = "Starting date of the competition" }
                ),
                resolve: ctx =>
                {
                    Task<List<Core.Models.Competition>> competitions;
                    var date = ctx.GetArgument<DateTime?>("competitionDate", null);

                    if (date != null)
                    {
                        competitions = competitionRepository.GetCompetitionsForDate(date);
                    }
                    else
                    {
                        competitions = competitionRepository.GetAll();
                    }

                    var mapped = _mapper.Map(competitions.Result);

                    return mapped;
                });
        }
    }
}