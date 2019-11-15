using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace aspReact.EntityFrameworkCore
{
    public static class aspReactDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<aspReactDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<aspReactDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
