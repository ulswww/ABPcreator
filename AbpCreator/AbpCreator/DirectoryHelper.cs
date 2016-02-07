using System.IO;
using System.Security.Policy;

namespace AbpCreator
{
    public class DirectoryHelper
    {
        public DirectoryHelper()
        {
        }

        public  void ReplaceDirectoryName(string sourcePath, string sourceName, string targetName)
        {

            if(! Directory.Exists(sourcePath))
                return;

            ReplaceSubDirectory(sourcePath, sourceName, targetName);

            var shortName = Path.GetFileName(sourcePath);

            if (shortName == null)
                return;

            if (shortName.Contains(sourceName))
            {
                var targetPath = sourcePath.Replace(sourceName, targetName);

                ChangeDirectoryName(sourcePath, targetPath);
            }
        }

        private void ChangeDirectoryName(string sourcePath, string targetPath)
        {
            System.IO.Directory.Move(sourcePath, targetPath);
        }

        private void ReplaceSubDirectory(string sourcePath, string sourceName, string targetName)
        {
            var paths = Directory.GetDirectories(sourcePath);

            foreach (var path in paths)
            {
                ReplaceDirectoryName(path, sourceName, targetName);
            }
        }
    }
}