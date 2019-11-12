using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using abpReact.Authorization.Roles;
using abpReact.Authorization.Users;
using abpReact.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace abpReact.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
