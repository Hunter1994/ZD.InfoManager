using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
namespace ZD.InfoManager.Application.SecurityInfos.Dto
{
    public class SecurityInfoDto:EntityDto
    {
        [Required]
        public string Title { get; private set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public string Content { get; private set; }
    }
}
