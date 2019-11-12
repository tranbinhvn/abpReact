using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abpReact.EntityFrameworkCore
{
    public static class abpReactDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<abpReactDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<abpReactDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
