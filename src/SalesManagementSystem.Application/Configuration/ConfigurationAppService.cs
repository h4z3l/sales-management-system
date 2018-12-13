using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SalesManagementSystem.Configuration.Dto;

namespace SalesManagementSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SalesManagementSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
