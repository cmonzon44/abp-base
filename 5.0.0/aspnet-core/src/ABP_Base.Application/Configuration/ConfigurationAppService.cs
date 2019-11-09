using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP_Base.Configuration.Dto;

namespace ABP_Base.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABP_BaseAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
