using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abp.AutoMapper;
using ZD.InfoManager.Application.Users.Dto;

namespace ZD.InfoManager.Models.User
{
    [AutoMapFrom(typeof(UserDto))]
    public class UpdateCurrentUserViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}