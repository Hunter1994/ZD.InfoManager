using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZD.InfoManager.Application.MultiTenancy.Dto;

namespace MyPassword.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
