using System.Threading.Tasks;
using Abp.Application.Services;
using SalesManagementSystem.Sessions.Dto;

namespace SalesManagementSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
