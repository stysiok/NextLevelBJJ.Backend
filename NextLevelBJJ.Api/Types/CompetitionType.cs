using GraphQL.Types;
using NextLevelBJJ.Api.GraphQLExtensions;
using NextLevelBJJ.Api.Models;

namespace NextLevelBJJ.Api.Types
{
    public class CompetitionType : ObjectGraphType<Competition>
    {
        public CompetitionType()
        {
            Name = "competitions";
            Description = "Upcomming BJJ competitions";            
            Field(c => c.CompetitionId, type: typeof(IdGraphType)).Description("Guid of the competition");
            Field(c => c.Name).Description("Name of the competition");
            Field(c => c.CompetitionType).Description("Type of the competition");
            Field(c => c.Town).Description("Town where the competition will be held");
            Field(c => c.DateAndTime, type: typeof(OriginalDateGraphType)).Description("Date and Time of the competition");
            Field(c => c.SingingInDate).Description("Date of signing in to the competition");
        }
    }
}