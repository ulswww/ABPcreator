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
                
                var content = File.ReadAllText(file,Encoding.UTF8);

                if (content.Contains(sourceName))
                {
                    content = content.Replace(sourceName, targetName);

                    File.WriteAllText(file, content, Encoding.UTF8);
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