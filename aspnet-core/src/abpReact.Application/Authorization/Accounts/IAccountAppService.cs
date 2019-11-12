using System.Threading.Tasks;
using Abp.Application.Services;
using abpReact.Authorization.Accounts.Dto;

namespace abpReact.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
