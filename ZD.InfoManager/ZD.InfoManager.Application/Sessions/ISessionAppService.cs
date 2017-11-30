using System.Threading.Tasks;
using Abp.Application.Services;
using ZD.InfoManager.Application.Sessions.Dto;

namespace ZD.InfoManager.Application.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
