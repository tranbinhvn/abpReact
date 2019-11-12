using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abpReact.Authorization.Roles;
using abpReact.Authorization.Users;
using abpReact.MultiTenancy;

namespace abpReact.EntityFrameworkCore
{
    public class abpReactDbContext : AbpZeroDbContext<Tenant, Role, User, abpReactDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public abpReactDbContext(DbContextOptions<abpReactDbContext> options)
            : base(options)
        {
        }
    }
}
