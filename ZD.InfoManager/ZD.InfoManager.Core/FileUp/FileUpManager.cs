using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using System.IO;
using Abp.Extensions;

namespace ZD.InfoManager.Core.FileUp
{
    public class FileUpManager:ITransientDependency
    {
        public async Task UpFile(Stream stream, string path, string filename, IFileUpPolicy policy)
        {
            await policy.ValidAsync(filename, stream.Length);

            await SaveAsync(stream, path, filename);
        }

        public Task SaveAsync(Stream stream,string path, string filename)
        {
            return Task.Run(() =>
            {
                string filePath = AppDomain.CurrentDomain.BaseDirectory + path;
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                var bs = new byte[stream.Length];
                stream.Read(bs, 0, stream.Length.To<int>());
                using (FileStream fs = new FileStream(filePath + "/" + filename, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(bs, 0, bs.Length);
                    fs.Flush();
                    fs.Close();
                }
            });
           
        }


    }
}
