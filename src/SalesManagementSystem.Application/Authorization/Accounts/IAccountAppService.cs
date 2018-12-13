using System.Threading.Tasks;
using Abp.Application.Services;
using SalesManagementSystem.Authorization.Accounts.Dto;

namespace SalesManagementSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
