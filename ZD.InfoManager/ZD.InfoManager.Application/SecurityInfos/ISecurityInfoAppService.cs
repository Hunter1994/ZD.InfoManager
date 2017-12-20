using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Application.SecurityInfos.Dto;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace ZD.InfoManager.Application.SecurityInfos
{
    public interface ISecurityInfoAppService:IApplicationService
    {
        Task Create(SecurityInfoDto input);
        Task Update(SecurityInfoDto input);
        Task<SecurityInfoDto> Get(int id);
        Task<PagedResultDto<SecurityInfoDto>> GetListByPager(QuerySecurityInfoByPageInput input);
        

    }
}
