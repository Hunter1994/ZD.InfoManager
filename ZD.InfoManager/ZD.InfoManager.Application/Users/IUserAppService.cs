using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZD.InfoManager.Application.Roles.Dto;
using ZD.InfoManager.Application.Users.Dto;

namespace ZD.InfoManager.Application.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task UpdateCurrent(UpdateCurrentUserDto input);

        Task UpdateCurrentUserAvatar(UpdateCurrentUserAvatarDto input);

        Task UpdatePassword(UpdatePasswordDto input);

    }
}