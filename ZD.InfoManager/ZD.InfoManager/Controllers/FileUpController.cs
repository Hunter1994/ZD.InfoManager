using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ZD.InfoManager.Core.FileUp;
using Abp.Configuration;
using ZD.InfoManager.Core;
using System.IO;
using ZD.InfoManager.Application.Users;
using ZD.InfoManager.Application.Users.Dto;

namespace ZD.InfoManager.Controllers
{
    public class FileUpController : InfoManagerControllerBase
    {
        private readonly FileUpManager _fileUpManager;
        private readonly SettingManager _settingManager;
        private readonly IUserAppService _userAppService;

        public FileUpController(FileUpManager fileUpManager, SettingManager settingManager, IUserAppService userAppService)
        {
            _fileUpManager = fileUpManager;
            _settingManager = settingManager;
            _userAppService = userAppService;
        }

        // GET: FileUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeAvatarShow()
        {
            return View("ChangeAvatar");
        }

        [HttpPost]
        public async Task<JsonResult> ChangeAvatar()
        {
            var file = Request.Files[0];

            var filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            await _fileUpManager.UpFile(file.InputStream, InfoManagerConsts.AvatarPath, filename, new AvatarFileUpPolicy(_settingManager));
            await _userAppService.UpdateCurrentUserAvatar(new UpdateCurrentUserAvatarDto()
            {
                AvatarPath = "/" + InfoManagerConsts.AvatarPath + "/" + filename
            });
            return await Task.FromResult(Json("上传完成"));
        }
    }
}