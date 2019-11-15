using System.Threading.Tasks;
using Abp.Application.Services;
using aspReact.Authorization.Accounts.Dto;

namespace aspReact.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
