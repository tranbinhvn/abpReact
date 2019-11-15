using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using aspReact.Authorization.Roles;
using aspReact.Authorization.Users;
using aspReact.MultiTenancy;

namespace aspReact.EntityFrameworkCore
{
    public class aspReactDbContext : AbpZeroDbContext<Tenant, Role, User, aspReactDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public aspReactDbContext(DbContextOptions<aspReactDbContext> options)
            : base(options)
        {
        }
    }
}
