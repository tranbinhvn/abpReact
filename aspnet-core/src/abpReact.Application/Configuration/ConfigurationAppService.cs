using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using abpReact.Configuration.Dto;

namespace abpReact.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : abpReactAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
