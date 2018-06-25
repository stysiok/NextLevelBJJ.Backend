using GraphQL.Types;
using NextLevelBJJ.Api.Models;

namespace NextLevelBJJ.Api.Types
{
    public class CarnetType : ObjectGraphType<Carnet>
    {
        public CarnetType()
        {
            Name = "carnet";
            Description = "Carnet bought the Next Level BJJ club";            
            Field(c => c.CarnetId, type: typeof(IdGraphType)).Description("Guid of the carnet");
            Field(c => c.Name).Description("Name of the carnet type");
            Field(c => c.EntrenceAmount).Description("Left amount of trainging entrence");
            Field(c => c.LastTraining).Description("Date of the last appearance on the mat");
            Field(c => c.ExpirationDate).Description("Date of the carnet expiration");
            Field(c => c.LeftEntrences).Description("Left entrences on carnet");
        }
    }
}