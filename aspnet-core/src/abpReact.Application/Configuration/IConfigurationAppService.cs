using System.Threading.Tasks;
using abpReact.Configuration.Dto;

namespace abpReact.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
