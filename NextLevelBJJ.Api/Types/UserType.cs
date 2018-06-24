using GraphQL.Types;
using NextLevelBJJ.Api.Models;
using System;
using System.Collections.Generic;

namespace NextLevelBJJ.Api.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "user";
            Description = "Student in the Next Level BJJ club";
            Field(u => u.UserId, type: typeof(IdGraphType)).Description("Guid of the user");
            Field(u => u.Name).Description("Name of the user");
            Field(u => u.Surname).Description("Surname of the user");
            Field<CarnetType>(
                "carnet",
                resolve: ctx =>
                {
                    return null;
                }
            );
            Field<ListGraphType<CompetitionType>>(
                "competitions",
                resolve: ctx =>
                {
                    return null;
                }
            );
        }
    }
}