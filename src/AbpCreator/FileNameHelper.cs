using System;
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
   
            var pattern =new StringReplacePattern(sourceName,targetName);

            if (!Directory.Exists(sourcePath))
                return;

            MapSubDirectory(sourcePath, sourceName, targetName);

            foreach (var file in Directory.GetFiles(sourcePath))
            {
                    string replace=null;
                try
                {
                    var shortName = Path.GetFileName(file);
                    if (shortName == null)
                        continue;

                    if (pattern.MatchAndReplace(file, out replace))
                    {
                        ChangeFileName(file, replace);
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(string.Format("{0}-{1}:{2}",sourceName, replace, file),ex);
                }



                //if (shortName.Contains(sourceName))
                //{
                //    var targetPath = file.Replace(sourceName, targetName);

                //    ChangeFileName(file, targetPath);
                //}
            }

        }

        private void ChangeFileName(string sourcePath, string targetPath)
        {
            Console.WriteLine(sourcePath +"   0000 "+targetPath);
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