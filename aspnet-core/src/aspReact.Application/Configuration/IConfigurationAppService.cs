using System.Threading.Tasks;
using aspReact.Configuration.Dto;

namespace aspReact.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
