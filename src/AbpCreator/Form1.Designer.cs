namespace AbpCreator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createAbp = new System.Windows.Forms.Button();
            this.txt_projectName = new System.Windows.Forms.TextBox();
            this.lb_ProjectName = new System.Windows.Forms.Label();
            this.txt_generatePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prefix_company = new System.Windows.Forms.TextBox();
            this.txt_prefix_project = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Src = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_createAbp
            // 
            this.btn_createAbp.Location = new System.Drawing.Point(404, 260);
            this.btn_createAbp.Name = "btn_createAbp";
            this.btn_createAbp.Size = new System.Drawing.Size(126, 27);
            this.btn_createAbp.TabIndex = 0;
            this.btn_createAbp.Text = "Create Project";
            this.btn_createAbp.UseVisualStyleBackColor = true;
            this.btn_createAbp.Click += new System.EventHandler(this.btn_createAbp_Click);
            // 
            // txt_projectName
            // 
            this.txt_projectName.Location = new System.Drawing.Point(157, 145);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(373, 21);
            this.txt_projectName.TabIndex = 1;
            // 
            // lb_ProjectName
            // 
            this.lb_ProjectName.AutoSize = true;
            this.lb_ProjectName.Location = new System.Drawing.Point(65, 148);
            this.lb_ProjectName.Name = "lb_ProjectName";
            this.lb_ProjectName.Size = new System.Drawing.Size(53, 12);
            this.lb_ProjectName.TabIndex = 2;
            this.lb_ProjectName.Text = "项目名称";
            // 
            // txt_generatePath
            // 
            this.txt_generatePath.Location = new System.Drawing.Point(157, 206);
            this.txt_generatePath.Name = "txt_generatePath";
            this.txt_generatePath.Size = new System.Drawing.Size(373, 21);
            this.txt_generatePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "生成目录";
            // 
            // txt_prefix_company
            // 
            this.txt_prefix_company.Location = new System.Drawing.Point(157, 101);
            this.txt_prefix_company.Name = "txt_prefix_company";
            this.txt_prefix_company.Size = new System.Drawing.Size(100, 21);
            this.txt_prefix_company.TabIndex = 5;
            // 
            // txt_prefix_project
            // 
            this.txt_prefix_project.Location = new System.Drawing.Point(280, 101);
            this.txt_prefix_project.Name = "txt_prefix_project";
            this.txt_prefix_project.Size = new System.Drawing.Size(135, 21);
            this.txt_prefix_project.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "公司.项目名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "src";
            // 
            // txt_Src
            // 
            this.txt_Src.Location = new System.Drawing.Point(157, 51);
            this.txt_Src.Name = "txt_Src";
            this.txt_Src.Size = new System.Drawing.Size(373, 21);
            this.txt_Src.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 21);
            this.textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 331);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Src);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_prefix_project);
            this.Controls.Add(this.txt_prefix_company);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_generatePath);
            this.Controls.Add(this.lb_ProjectName);
            this.Controls.Add(this.txt_projectName);
            this.Controls.Add(this.btn_createAbp);
            this.Name = "Form1";
            this.Text = "ABP CREATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createAbp;
        private System.Windows.Forms.TextBox txt_projectName;
        private System.Windows.Forms.Label lb_ProjectName;
        private System.Windows.Forms.TextBox txt_generatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prefix_company;
        private System.Windows.Forms.TextBox txt_prefix_project;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Src;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

