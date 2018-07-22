using GraphQL.Types;
using NextLevelBJJ.Api.Models;

namespace NextLevelBJJ.Api.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Name = "Post";
            Description = "Post about our club";
            Field(p => p.PostId, type: typeof(IdGraphType)).Description("Guid of the post");
            Field(p => p.Author).Description("Author of the post");
            Field(p => p.Title).Description("Title of the post");
            Field(p => p.Text).Description("Text of the post");
            Field(p => p.CreationDate).Description("Date of the post creation");
            Field(p => p.Image).Description("Image of the post");
        }
    }
}