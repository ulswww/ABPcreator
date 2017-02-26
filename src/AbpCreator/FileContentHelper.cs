using System;
using System.Drawing;
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

                long length = new System.IO.FileInfo(file).Length;

                if (length > 0)
                {
                    var content = File.ReadAllText(file, GetFileEncodeType(file));

                    if (content.Contains(sourceName))
                    {
                        content = content.Replace(sourceName, targetName);

                        File.WriteAllText(file, content, Encoding.UTF8);
                    }

                }


            }

        }

        public Encoding GetFileEncodeType(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open,
                    FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                Byte[] buffer = br.ReadBytes(2);

               
                if (buffer[0] >= 0xEF)
                {
                    if (buffer[0] == 0xEF && buffer[1] == 0xBB)
                    {
                        return Encoding.UTF8;
                    }
                    else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                    {
                        return Encoding.BigEndianUnicode;
                    }
                    else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                    {
                        return Encoding.Unicode;
                    }
                    else
                    {
                        return Encoding.Default;
                    }
                }
                else
                {
                    return Encoding.Default;
                }
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