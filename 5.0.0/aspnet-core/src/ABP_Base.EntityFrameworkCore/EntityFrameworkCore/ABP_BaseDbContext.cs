using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP_Base.Authorization.Roles;
using ABP_Base.Authorization.Users;
using ABP_Base.MultiTenancy;

namespace ABP_Base.EntityFrameworkCore
{
    public class ABP_BaseDbContext : AbpZeroDbContext<Tenant, Role, User, ABP_BaseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABP_BaseDbContext(DbContextOptions<ABP_BaseDbContext> options)
            : base(options)
        {
        }
    }
}
