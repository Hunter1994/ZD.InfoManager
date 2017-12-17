using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Core.Authorization.Users;

namespace ZD.InfoManager.Application.Users.Dto
{
    [AutoMapTo(typeof(User))]
    public class UpdateCurrentUserAvatarDto
    {
        [Required]
        public string AvatarPath { get; set; }
    }
}
