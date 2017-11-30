using System.Threading.Tasks;
using Abp.Application.Services;
using ZD.InfoManager.Application.Configuration.Dto;

namespace ZD.InfoManager.Application.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}