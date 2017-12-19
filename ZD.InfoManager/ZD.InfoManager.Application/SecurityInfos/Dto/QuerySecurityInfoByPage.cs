using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD.InfoManager.Application.SecurityInfos.Dto
{
    public class QuerySecurityInfoByPageInput: PagedAndSortedResultRequestDto
    {
        public string Title { get; private set; }
    }

}
