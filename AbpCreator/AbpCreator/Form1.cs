﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbpCreator
{
    public partial class Form1 : Form
    {
        private string _projectPath = Path.Combine(Application.StartupPath, "src");
        private readonly DirectoryHelper _directoryHelper;
        private readonly FileNameHelper _fileNameHelper;
        private readonly FileContentHelper _fileContentHelper;

        private const string SourceName = "AbpCompanyName.AbpProjectName";

        private const string SourceProjectName = "AbpProjectName";
        public Form1()
        {
            InitializeComponent();

            _directoryHelper = new DirectoryHelper();

            _fileNameHelper = new FileNameHelper();

            _fileContentHelper = new FileContentHelper();
        }

        private void btn_createAbp_Click(object sender, EventArgs e)
        {
            CreateProject(_projectPath,txt_projectName.Text);
        }

        private void CreateProject(string projectPath, string projectName)
        {
            var targetPath = Path.Combine(Application.StartupPath, projectName);

            DirectoryCopy(projectPath, targetPath,true);

            _fileContentHelper.ReplaceName(targetPath, SourceName, projectName);

            _fileContentHelper.ReplaceName(targetPath, SourceProjectName, projectName);

            _directoryHelper.ReplaceDirectoryName(targetPath, SourceName,projectName);

            _fileNameHelper.ReplaceFileName(targetPath, SourceName,projectName);

            _fileNameHelper.ReplaceFileName(targetPath, SourceProjectName, projectName);

            Process.Start(Application.StartupPath);
        }

        private static void DirectoryCopy(
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