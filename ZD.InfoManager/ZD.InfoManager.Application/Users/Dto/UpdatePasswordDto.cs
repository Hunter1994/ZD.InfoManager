using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Auditing;

namespace ZD.InfoManager.Application.Users.Dto
{
    [DisableAuditing]
    public class UpdatePasswordDto
    {
        [Required]
        [MaxLength(AbpUserBase.MaxPasswordLength)]
        public string Password { get; set; }
        [Required]
        [MaxLength(AbpUserBase.MaxPasswordLength)]
        public string NewPassword { get; set; }
    }
}
