using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP_Base.EntityFrameworkCore
{
    public static class ABP_BaseDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABP_BaseDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABP_BaseDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
