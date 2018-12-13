using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SalesManagementSystem.MultiTenancy.Dto;

namespace SalesManagementSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
