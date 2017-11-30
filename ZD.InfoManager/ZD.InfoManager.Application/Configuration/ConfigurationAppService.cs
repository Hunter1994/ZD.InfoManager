using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZD.InfoManager.Application.Configuration.Dto;
using ZD.InfoManager.Core.Configuration;

namespace ZD.InfoManager.Application.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InfoManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
