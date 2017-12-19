using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Application.SecurityInfos.Dto;
using Abp.Application.Services;
namespace ZD.InfoManager.Application.SecurityInfos
{
    public interface ISecurityInfoAppService:IApplicationService
    {
        Task Create(SecurityInfoDto input);
        Task Update(SecurityInfoDto input);
        Task<SecurityInfoDto> Get(long id);
        Task<PagedResultExtDto<SecurityInfoDto>> GetListByPager(QuerySecurityInfoByPageInput input)
        

    }
}
