using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using aspReact.Authorization;

namespace aspReact
{
    [DependsOn(
        typeof(aspReactCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class aspReactApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<aspReactAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(aspReactApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
