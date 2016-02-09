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
            this.SuspendLayout();
            // 
            // btn_createAbp
            // 
            this.btn_createAbp.Location = new System.Drawing.Point(387, 181);
            this.btn_createAbp.Name = "btn_createAbp";
            this.btn_createAbp.Size = new System.Drawing.Size(126, 27);
            this.btn_createAbp.TabIndex = 0;
            this.btn_createAbp.Text = "Create Project";
            this.btn_createAbp.UseVisualStyleBackColor = true;
            this.btn_createAbp.Click += new System.EventHandler(this.btn_createAbp_Click);
            // 
            // txt_projectName
            // 
            this.txt_projectName.Location = new System.Drawing.Point(140, 66);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(373, 21);
            this.txt_projectName.TabIndex = 1;
            // 
            // lb_ProjectName
            // 
            this.lb_ProjectName.AutoSize = true;
            this.lb_ProjectName.Location = new System.Drawing.Point(48, 69);
            this.lb_ProjectName.Name = "lb_ProjectName";
            this.lb_ProjectName.Size = new System.Drawing.Size(53, 12);
            this.lb_ProjectName.TabIndex = 2;
            this.lb_ProjectName.Text = "项目名称";
            // 
            // txt_generatePath
            // 
            this.txt_generatePath.Location = new System.Drawing.Point(140, 127);
            this.txt_generatePath.Name = "txt_generatePath";
            this.txt_generatePath.Size = new System.Drawing.Size(373, 21);
            this.txt_generatePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "生成目录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 240);
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
    }
}

