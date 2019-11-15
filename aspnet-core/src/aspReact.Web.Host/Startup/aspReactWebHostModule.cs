using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using aspReact.Configuration;

namespace aspReact.Web.Host.Startup
{
    [DependsOn(
       typeof(aspReactWebCoreModule))]
    public class aspReactWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public aspReactWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(aspReactWebHostModule).GetAssembly());
        }
    }
}
