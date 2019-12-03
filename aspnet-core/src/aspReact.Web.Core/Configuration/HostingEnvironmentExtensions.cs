using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace aspReact.Configuration
{
    public static class HostingEnvironmentExtensions
    {
#pragma warning disable CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
        public static IConfigurationRoot GetAppConfiguration(this IHostingEnvironment env)
#pragma warning restore CS0618 // 'IHostingEnvironment' is obsolete: 'This type is obsolete and will be removed in a future version. The recommended alternative is Microsoft.AspNetCore.Hosting.IWebHostEnvironment.'
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
