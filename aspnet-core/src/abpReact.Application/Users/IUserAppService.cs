using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abpReact.Roles.Dto;
using abpReact.Users.Dto;

namespace abpReact.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
