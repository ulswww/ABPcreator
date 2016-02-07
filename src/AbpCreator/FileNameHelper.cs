using System.IO;

namespace AbpCreator
{
    public class FileNameHelper
    {
        public FileNameHelper()
        {
        }

        public void ReplaceFileName(string sourcePath, string sourceName, string targetName)
        {

            if (!Directory.Exists(sourcePath))
                return;

            MapSubDirectory(sourcePath, sourceName, targetName);

            foreach (var file in Directory.GetFiles(sourcePath))
            {
                var shortName = Path.GetFileName(file);
                if(shortName==null)
                    continue;

                if (shortName.Contains(sourceName))
                {
                    var targetPath = file.Replace(sourceName, targetName);

                    ChangeFileName(file, targetPath);
                }
            }

        }

        private void ChangeFileName(string sourcePath, string targetPath)
        {
            File.Move(sourcePath, targetPath);
        }

        private void MapSubDirectory(string sourcePath, string sourceName, string targetName)
        {
            var paths = Directory.GetDirectories(sourcePath);

            foreach (var path in paths)
            {
                ReplaceFileName(path, sourceName, targetName);
            }
        }
    }
}