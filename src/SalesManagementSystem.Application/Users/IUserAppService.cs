using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SalesManagementSystem.Roles.Dto;
using SalesManagementSystem.Users.Dto;

namespace SalesManagementSystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}