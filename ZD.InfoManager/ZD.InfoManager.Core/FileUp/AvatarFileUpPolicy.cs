using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Core.Configuration;
using Abp.Extensions;
using Abp.UI;
using Abp.Configuration;

namespace ZD.InfoManager.Core.FileUp
{
    public class AvatarFileUpPolicy : IFileUpPolicy
    {
        public readonly SettingManager _settingManager;
        public AvatarFileUpPolicy(SettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public Task ValidAsync(string filename, long length)
        {
            return Task.Run(() => {
                string[] extens = new[] { ".JPG", ".JPEG", ".PNG", ".GIF", ".BMP" };
                var validExten = Path.GetExtension(filename).ToUpper();
                if (!extens.Contains(validExten)) throw new UserFriendlyException("上传头像格式有误！");
                var upAvatarMaxLength = _settingManager.GetSettingValueAsync(AppSettingNames.UpAvatarMaxLength).Result.To<int>();
                if (length > upAvatarMaxLength) throw new UserFriendlyException("上传头像过大！");
            });
        }

    }
}
