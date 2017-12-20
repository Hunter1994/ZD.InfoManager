using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Application.SecurityInfos.Dto;
using Abp.Domain.Repositories;
using ZD.InfoManager.Core.SecurityInfos;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;

namespace ZD.InfoManager.Application.SecurityInfos
{
    public class SecurityInfoAppService : InfoManagerAppServiceBase, ISecurityInfoAppService
    {
        private readonly IRepository<SecurityInfo> _repositorySecurityInfo;
        public SecurityInfoAppService(IRepository<SecurityInfo> repositorySecurityInfo)
        {
            _repositorySecurityInfo = repositorySecurityInfo;
        }

        public async Task Create(SecurityInfoDto input)
        {
            var securityInfo = new SecurityInfo(input.Title, input.UserName, input.Password, input.Content);
            await _repositorySecurityInfo.InsertAsync(securityInfo);
        }

        public async Task<SecurityInfoDto> Get(int id)
        {
            var securityInfo = await _repositorySecurityInfo.GetAsync(id);
            var securityInfoDto = new SecurityInfoDto();
            securityInfoDto.Title = securityInfo.GetTitle();
            securityInfoDto.UserName = securityInfo.GetUserName();
            securityInfoDto.Password = securityInfo.GetPassword();
            securityInfoDto.Content = securityInfo.GetContent();
            return securityInfoDto;
        }

        public async Task<PagedResultDto<SecurityInfoDto>> GetListByPager(QuerySecurityInfoByPageInput input)
        {
            var securityInfos = _repositorySecurityInfo.GetAll().WhereIf(!input.Title.IsNullOrEmpty(), t => t.Title.Contains(input.Title));
            securityInfos = securityInfos.OrderBy(c => c.CreationTime);

            var total = securityInfos.Count();
            var data = securityInfos.PageBy(input).ToList();

            return await Task.FromResult(
                 new PagedResultDto<SecurityInfoDto>()
                 {
                     Items = data.MapTo<List<SecurityInfoDto>>(),
                     TotalCount = total
                 }
                );
        }

        public async Task Update(SecurityInfoDto input)
        {
            var securityInfo = await _repositorySecurityInfo.GetAsync(input.Id);
            securityInfo.SetTitle(input.Title);
            securityInfo.SetUserName(input.UserName);
            securityInfo.SetPassword(input.Password);
            securityInfo.SetContent(input.Content);
        }
    }
}
