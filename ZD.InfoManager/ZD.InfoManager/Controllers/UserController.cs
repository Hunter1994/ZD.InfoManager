﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ZD.InfoManager.Application.Users;
using Abp.AutoMapper;
using ZD.InfoManager.Models.User;
using ZD.InfoManager.Core.Authorization;
using Abp.Authorization;

namespace ZD.InfoManager.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserController : InfoManagerControllerBase
    {
        private readonly IUserAppService _userAppService;
        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> UpdateCurrentUser()
        {
            var user = await _userAppService.Get(new Abp.Application.Services.Dto.EntityDto<long>()
            {
                Id = AbpSession.UserId ?? 0
            });
            return PartialView("_UpdateCurrentUser", user.MapTo<UpdateCurrentUserViewModel>());
        }

        public async Task<PartialViewResult> UpdatePassword()
        {
            return PartialView("_UpdatePassword");
        }

    }
}