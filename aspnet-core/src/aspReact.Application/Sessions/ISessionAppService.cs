using System.Threading.Tasks;
using Abp.Application.Services;
using aspReact.Sessions.Dto;

namespace aspReact.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
