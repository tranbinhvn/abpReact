using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abpReact.Configuration;
using abpReact.Web;

namespace abpReact.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class abpReactDbContextFactory : IDesignTimeDbContextFactory<abpReactDbContext>
    {
        public abpReactDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<abpReactDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            abpReactDbContextConfigurer.Configure(builder, configuration.GetConnectionString(abpReactConsts.ConnectionStringName));

            return new abpReactDbContext(builder.Options);
        }
    }
}
