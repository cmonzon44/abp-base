using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABP_Base.Configuration;
using ABP_Base.Web;

namespace ABP_Base.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABP_BaseDbContextFactory : IDesignTimeDbContextFactory<ABP_BaseDbContext>
    {
        public ABP_BaseDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABP_BaseDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABP_BaseDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABP_BaseConsts.ConnectionStringName));

            return new ABP_BaseDbContext(builder.Options);
        }
    }
}
