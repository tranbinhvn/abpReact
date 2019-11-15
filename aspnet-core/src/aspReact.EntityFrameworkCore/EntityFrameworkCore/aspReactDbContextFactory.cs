using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using aspReact.Configuration;
using aspReact.Web;

namespace aspReact.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class aspReactDbContextFactory : IDesignTimeDbContextFactory<aspReactDbContext>
    {
        public aspReactDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<aspReactDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            aspReactDbContextConfigurer.Configure(builder, configuration.GetConnectionString(aspReactConsts.ConnectionStringName));

            return new aspReactDbContext(builder.Options);
        }
    }
}
