using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpReact.Authorization;

namespace abpReact
{
    [DependsOn(
        typeof(abpReactCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class abpReactApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<abpReactAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(abpReactApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
