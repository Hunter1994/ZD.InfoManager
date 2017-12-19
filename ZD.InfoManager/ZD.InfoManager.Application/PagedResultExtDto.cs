using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD.InfoManager.Application
{
    public class PagedResultExtDto<T>: PagedResultDto<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
