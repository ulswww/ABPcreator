using System;
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
            StringReplacePattern pattern =new StringReplacePattern(sourceName,targetName);

            if (! Directory.Exists(sourcePath))
                return;


            ReplaceSubDirectory(sourcePath, sourceName, targetName);

            var shortName =   Path.GetFileName(sourcePath);
      
            if (shortName == null)
                return;

            string targetDirectoryName;

            if (pattern.MatchAndReplace(shortName, out targetDirectoryName))
            {
                var root = Path.GetDirectoryName(sourcePath);

                ChangeDirectoryName(sourcePath, Path.Combine(root, targetDirectoryName));
            }

            //if (shortName.Contains(sourceName))
            //{
            //    var root = Path.GetDirectoryName(sourcePath);

            //    var shortDirectoryName = Path.GetFileName(sourcePath);
            //    var targetDirectoryName = shortDirectoryName.Replace(sourceName, targetName);
            //    if (sourcePath.Contains("Localization"))
            //    {
            //        int i = 2;
            //    }
            //    ChangeDirectoryName(sourcePath, Path.Combine(root,targetDirectoryName));
            //}
        }

        private void ChangeDirectoryName(string sourcePath, string targetPath)
        {
            if (NormalizePath(sourcePath) == NormalizePath(targetPath))
                return;
            Console.WriteLine(targetPath);
            //DirectoryCopy(sourcePath,targetPath,true);
            //new DirectoryInfo(sourcePath).Delete(true);
            System.IO.Directory.Move(sourcePath, targetPath);
        }

        public static string NormalizePath(string path)
        {
            return Path.GetFullPath(new Uri(path).LocalPath)
                       .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                       .ToUpperInvariant();
        }

        private void ReplaceSubDirectory(string sourcePath, string sourceName, string targetName)
        {
            var paths = Directory.GetDirectories(sourcePath);

            foreach (var path in paths)
            {
                ReplaceDirectoryName(path, sourceName, targetName);
            }
        }

        public  static void DirectoryCopy(
    string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }


}