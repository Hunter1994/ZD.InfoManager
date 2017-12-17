using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD.InfoManager.Core.FileUp
{
    public interface IFileUpPolicy
    {
        Task ValidAsync(string filename, long length);
    }
}
