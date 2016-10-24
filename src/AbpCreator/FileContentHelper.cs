using System;
using System.IO;
using System.Linq;
using System.Text;

namespace AbpCreator
{
    public class FileContentHelper
    {
        public FileContentHelper()
        {
        }

        public void ReplaceName(string sourcePath, string sourceName, string targetName)
        {

            if (!Directory.Exists(sourcePath))
                return;

            MapSubDirectory(sourcePath, sourceName, targetName);
           
            foreach (var file in Directory.GetFiles(sourcePath).Where(f=>Fit(f, ".cs", ".sln", ".csproj", ".cshtml", ".config", ".xml", ".txt", ".js", ".asax", ".bat")))
            {
                
                var content = File.ReadAllText(file, GetFileEncodeType(file));

                if (content.Contains(sourceName))
                {
                    content = content.Replace(sourceName, targetName);

                    File.WriteAllText(file, content, Encoding.UTF8);
                }

            }

        }

        public System.Text.Encoding GetFileEncodeType(string filename)
        {
            System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            Byte[] buffer = br.ReadBytes(2);
            if (buffer[0] >= 0xEF)
            {
                if (buffer[0] == 0xEF && buffer[1] == 0xBB)
                {
                    return System.Text.Encoding.UTF8;
                }
                else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                {
                    return System.Text.Encoding.BigEndianUnicode;
                }
                else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                {
                    return System.Text.Encoding.Unicode;
                }
                else
                {
                    return System.Text.Encoding.Default;
                }
            }
            else
            {
                return System.Text.Encoding.Default;
            }
        }

        private bool Fit(string s,params string[] extensions)
        {
            foreach (var extension in extensions)
            {
                if (s.Contains(extension))
                    return true;
            }

            return false;
        }

        private void MapSubDirectory(string sourcePath, string sourceName, string targetName)
        {
            var paths = Directory.GetDirectories(sourcePath);

            foreach (var path in paths)
            {
                ReplaceName(path, sourceName, targetName);
            }
        }
    }
}