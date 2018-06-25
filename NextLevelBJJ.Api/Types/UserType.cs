using GraphQL.Types;
using NextLevelBJJ.Api.Mappers;
using NextLevelBJJ.Api.Models;
using NextLevelBJJ.Core.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NextLevelBJJ.Api.Types
{
    public class UserType : ObjectGraphType<User>
    {
        Mapper mapper;
        public UserType(ICarnetRepository carnetRepository, ICarnetTypeRepository carnetTypeRepository, IUserCompetitionsRepository userCompetitionRepository, ICompetitionRepository competitionRepository)
        {
            mapper = new Mapper();

            Name = "user";
            Description = "Student in the Next Level BJJ club";
            Field(u => u.UserId, type: typeof(IdGraphType)).Description("Guid of the user");
            Field(u => u.Name).Description("Name of the user");
            Field(u => u.Surname).Description("Surname of the user");
            Field(u => u.CarnetId, type: typeof(IdGraphType)).Description("Id of an users carnet");
            Field<CarnetType>(
                "carnet",
                description: "Get carnet assigned to the user",
                arguments: new QueryArguments
                {
                    new QueryArgument<NonNullGraphType<StringGraphType>>{Name = "carnetGuid", Description = "Guid of the users carnet"}
                },
                resolve: ctx =>
                {
                    var guid = ctx.GetArgument<string>("carnetGuid");
                    var carnet = carnetRepository.GetUserCarnet(guid).Result;
                    var carnetType = carnetTypeRepository.Get(carnet.CarnetTypeId).Result;

                    var mapped = mapper.Map(carnet, carnetType);

                    return mapped;
                    
                }
            );
            Field<ListGraphType<CompetitionType>>(
                "competitions",
                description: "Get competitions which user has been assigned to",
                arguments: new QueryArguments
                {
                    new QueryArgument<NonNullGraphType<StringGraphType>>{Name = "userGuid", Description = "Guid of the user"}
                },
                resolve: ctx =>
                {
                    var guid = ctx.GetArgument<string>("userGuid");
                    var competitionsToUser = userCompetitionRepository.GetUserCompetitions(guid).Result;

                    var competitions = competitionsToUser.Select(cg =>
                    {
                        return competitionRepository.Get(cg.CompetitionId).Result;
                    }).ToList();

                    var mapped = mapper.Map(competitions, competitionsToUser);

                    return mapped;
                    
                }
            );
        }
    }
}