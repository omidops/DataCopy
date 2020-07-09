using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascherDaten
{
    public class Helper
    {
        public static void DeleteFiles(string path, DateTime selectedtime)
        {
            var files = Directory
                            .GetFiles(path, "*", SearchOption.AllDirectories)
                            .ToList()
                            .ConvertAll(file => new FileInfo(file))
                            .Where(file => file.LastWriteTime.Date <= selectedtime);

            Parallel.ForEach(files, (file) =>
            {                
                if (file.Exists) file.Delete();
            });
        }

        public static void CopyFilesInSelectedTime(string src_path, string dst_path, DateTime startTime, DateTime endTime)
        {
            var files = Directory
                           .GetFiles(src_path, "*", SearchOption.AllDirectories)
                           .ToList()
                           .ConvertAll(file => new FileInfo(file))
                           .Where(file => file.LastWriteTime.Date >= startTime && file.LastWriteTime.Date <= endTime);

            Parallel.ForEach(files, (file) =>
            {
                FileInfo destFile = new FileInfo(file.FullName.Replace(src_path, dst_path));

                if (destFile.Exists)
                {
                    if (file.Length > destFile.Length)
                    {
                        file.CopyTo(destFile.FullName, true);
                    }
                }
                else
                {
                    Directory.CreateDirectory(destFile.DirectoryName);
                    file.CopyTo(destFile.FullName, false);
                }
            });
        }
    }
}
