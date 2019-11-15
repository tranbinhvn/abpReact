using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using aspReact.Configuration.Dto;

namespace aspReact.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : aspReactAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
