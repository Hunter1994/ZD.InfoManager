using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Application.SecurityInfos.Dto;
using Abp.Domain.Repositories;
using ZD.InfoManager.Core.SecurityInfos;
namespace ZD.InfoManager.Application.SecurityInfos
{
    public class SecurityInfoAppService : InfoManagerAppServiceBase, ISecurityInfoAppService
    {
        private readonly IRepository<SecurityInfo> _repositorySecurityInfo;
        public SecurityInfoAppService(IRepository<SecurityInfo> repositorySecurityInfo)
        {
            _repositorySecurityInfo = repositorySecurityInfo;
        }

        public Task Create(SecurityInfoDto input)
        {
            throw new NotImplementedException();
        }

        public Task<SecurityInfoDto> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultExtDto<SecurityInfoDto>> GetListByPager(QuerySecurityInfoByPageInput input)
        {
            throw new NotImplementedException();
        }

        public Task Update(SecurityInfoDto input)
        {
            throw new NotImplementedException();
        }
    }
}
