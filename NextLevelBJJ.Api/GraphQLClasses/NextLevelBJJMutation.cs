using GraphQL.Types;
using NextLevelBJJ.Api.InputModels;
using NextLevelBJJ.Api.InputTypes;
using NextLevelBJJ.Api.Mappers;
using NextLevelBJJ.Api.Models;
using NextLevelBJJ.Api.Types;
using NextLevelBJJ.Core.Logic;
using System.IdentityModel.Tokens.Jwt;
using System;
using NextLevelBJJ.Api.GraphQLExtensions;

namespace NextLevelBJJ.Api.GraphQLClasses
{
    public class NextLevelBJJMutation : ObjectGraphType
    {
        Mapper mapper;
        public NextLevelBJJMutation(ICompetitionRepository competitionRepository)
        {
            mapper = new Mapper();

            Name = "Mutation";
            Field<CompetitionType>(
                "createCompetition",
                description: "Create new competition",
                arguments: new QueryArguments(
                        new QueryArgument<NonNullGraphType<CompetitionInputType>> { Name = "competition", Description = "Competition you want to create" }
                    ),
                resolve: ctx =>
                {
                    var competitionInput = ctx.GetArgument<CompetitionInput>("competition");

                    var mappedInput = mapper.Map(competitionInput);

                    var addedValue = competitionRepository.Add(mappedInput).Result;

                    var mapped = mapper.Map(addedValue);

                    return mapped;
                }
             );
        }
    }
}
