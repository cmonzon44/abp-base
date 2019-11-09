using System.Threading.Tasks;
using ABP_Base.Configuration.Dto;

namespace ABP_Base.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
