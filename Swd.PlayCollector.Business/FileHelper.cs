using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Business
{
    public static class FileHelper
    {

        public static async Task CopyFile(string sourceFilePath, string targetFilePath)
        {
            string targetDir = Path.GetDirectoryName(targetFilePath);
            if(!Directory.Exists(targetDir)) {
                Directory.CreateDirectory(targetDir);   
            }
            File.Copy(sourceFilePath, targetFilePath, true );   
        }

    }
}
