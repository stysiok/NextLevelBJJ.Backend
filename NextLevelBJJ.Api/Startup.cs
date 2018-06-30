using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NextLevelBJJ.Api.GraphQLClasses;
using NextLevelBJJ.Api.GraphQLExtensions;
using NextLevelBJJ.Api.InputTypes;
using NextLevelBJJ.Api.Types;
using NextLevelBJJ.Core.Logic;
using NextLevelBJJ.Data.InMemory;

namespace NextLevelBJJ.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //Main Graphql objs
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<GraphQLQuery>();
            services.AddSingleton<NextLevelBJJQuery>();
            services.AddSingleton<NextLevelBJJMutation>();

            //GraphQL extensions
            services.AddSingleton<OriginalDateGraphType>();

            //Repos
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<ICarnetRepository, CarnetRepository>();
            services.AddSingleton<ICarnetTypeRepository, CarnetTypeRepository>();
            services.AddSingleton<ICompetitionRepository, CompetitionRepository>();
            services.AddSingleton<IUserCompetitionsRepository, UserCompetitionsRepository>();
            services.AddSingleton<IPostRepository, PostRepository>();

            //Types
            services.AddSingleton<CarnetType>();
            services.AddSingleton<CompetitionType>();
            services.AddSingleton<PostType>();
            services.AddSingleton<UserType>();
            services.AddSingleton<JsonWebTokenType>();

            //Input types
            services.AddSingleton<CompetitionInputType>();

            //Schema
            services.AddSingleton<ISchema>(x => new NextLevelBJJSchema(type => (GraphType)x.GetService(type)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseGraphiQl();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}