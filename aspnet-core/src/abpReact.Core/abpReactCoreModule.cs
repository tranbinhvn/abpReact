using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using abpReact.Authorization.Roles;
using abpReact.Authorization.Users;
using abpReact.Configuration;
using abpReact.Localization;
using abpReact.MultiTenancy;
using abpReact.Timing;

namespace abpReact
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class abpReactCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            abpReactLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = abpReactConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abpReactCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
