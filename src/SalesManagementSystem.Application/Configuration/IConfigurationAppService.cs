using System.Threading.Tasks;
using Abp.Application.Services;
using SalesManagementSystem.Configuration.Dto;

namespace SalesManagementSystem.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}