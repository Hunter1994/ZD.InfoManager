using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
namespace ZD.InfoManager.Application.SecurityInfos.Dto
{
    [DisableAuditing]
    public class SecurityInfoDto:EntityDto
    {
        [Required]
        public string Title { get;  set; }

        public string UserName { get;  set; }

        public string Password { get;  set; }

        public string Content { get;  set; }
    }
}
