using Abp.AutoMapper;
using SalesManagementSystem.Sessions.Dto;

namespace SalesManagementSystem.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}