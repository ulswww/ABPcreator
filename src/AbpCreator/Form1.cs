using System;
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

        private  string SourceName = "MyCompanyName.AbpZeroTemplate";

        private  string SourceProjectName = "AbpZeroTemplate";
        private  string MyCompanyName = "MyCompanyName";
        public Form1()
        {
            InitializeComponent();

            _directoryHelper = new DirectoryHelper();

            _fileNameHelper = new FileNameHelper();

            _fileContentHelper = new FileContentHelper();

            txt_prefix_company.Text = MyCompanyName;
            txt_prefix_project.Text = SourceProjectName;

            txt_generatePath.Text = Application.StartupPath;

        }

        private void btn_createAbp_Click(object sender, EventArgs e)
        {
            TryThis(CreateProject);
        }

        public void TryThis(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateProject()
        {
            AssertInput();

            SourceName = txt_prefix_company.Text + "." + txt_prefix_project.Text;
            SourceProjectName = txt_prefix_project.Text;
            CreateProject(_projectPath, txt_projectName.Text, txt_generatePath.Text);
        }

        private void AssertInput()
        {
            if(string.IsNullOrEmpty(txt_projectName.Text))
                throw new Exception("请输入项目名称");

            if (string.IsNullOrEmpty(txt_generatePath.Text))
                throw new Exception("请输入生成目录");
        }

        private void CreateProject(string projectPath, string projectName, string generatePath)
        {
            EnsureDirecotory(generatePath);

            var targetPath = Path.Combine(generatePath, projectName);

            DirectoryHelper. DirectoryCopy(projectPath, targetPath,true);

            _fileContentHelper.ReplaceName(targetPath, SourceName, projectName);

            _fileContentHelper.ReplaceName(targetPath, SourceProjectName, projectName);

            _directoryHelper.ReplaceDirectoryName(targetPath, SourceName,projectName);
            _directoryHelper.ReplaceDirectoryName(targetPath, SourceProjectName, projectName);

            _fileNameHelper.ReplaceFileName(targetPath, SourceName,projectName);

            _fileNameHelper.ReplaceFileName(targetPath, SourceProjectName, projectName);

            Process.Start(generatePath);
        }

        private static void EnsureDirecotory(string generatePath)
        {
            if (!Directory.Exists(generatePath))
            {
                Directory.CreateDirectory(generatePath);
            }
        }

     
    }
}
