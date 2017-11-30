using System.Threading.Tasks;
using Abp.Application.Services;
using ZD.InfoManager.Application.Authorization.Accounts.Dto;

namespace ZD.InfoManager.Application.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
