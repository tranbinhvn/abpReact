using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abpReact.Configuration;

namespace abpReact.Web.Host.Startup
{
    [DependsOn(
       typeof(abpReactWebCoreModule))]
    public class abpReactWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public abpReactWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(abpReactWebHostModule).GetAssembly());
        }
    }
}
