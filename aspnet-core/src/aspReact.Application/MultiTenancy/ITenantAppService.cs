using Abp.Application.Services;
using Abp.Application.Services.Dto;
using aspReact.MultiTenancy.Dto;

namespace aspReact.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

