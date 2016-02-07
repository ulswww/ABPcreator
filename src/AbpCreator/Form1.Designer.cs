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
            this.SuspendLayout();
            // 
            // btn_createAbp
            // 
            this.btn_createAbp.Location = new System.Drawing.Point(443, 135);
            this.btn_createAbp.Name = "btn_createAbp";
            this.btn_createAbp.Size = new System.Drawing.Size(70, 27);
            this.btn_createAbp.TabIndex = 0;
            this.btn_createAbp.Text = "创建";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 194);
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
    }
}

