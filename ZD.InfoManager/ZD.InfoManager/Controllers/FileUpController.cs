using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace ZD.InfoManager.Controllers
{
    public class FileUpController : Controller
    {
        // GET: FileUp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeAvatar()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ChangeAvatar(HttpPostedFileBase txt_file)
        {
            return Json("上传完成");
        }
    }
}