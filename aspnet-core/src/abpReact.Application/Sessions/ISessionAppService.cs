using System.Threading.Tasks;
using Abp.Application.Services;
using abpReact.Sessions.Dto;

namespace abpReact.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
