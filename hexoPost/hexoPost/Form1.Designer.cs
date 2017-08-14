namespace hexoPost
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
            this.fileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Creat_button = new System.Windows.Forms.Button();
            this.text_fileName = new System.Windows.Forms.TextBox();
            this.text_postName = new System.Windows.Forms.TextBox();
            this.text_catName = new System.Windows.Forms.TextBox();
            this.text_tagsName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileName.Location = new System.Drawing.Point(183, 105);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(74, 21);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "文件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(183, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "文章名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(183, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "分类名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(183, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "标签名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hexo静态博客——一键生成文章框架";
            // 
            // Creat_button
            // 
            this.Creat_button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Creat_button.Location = new System.Drawing.Point(279, 325);
            this.Creat_button.Name = "Creat_button";
            this.Creat_button.Size = new System.Drawing.Size(118, 37);
            this.Creat_button.TabIndex = 5;
            this.Creat_button.Text = "一键生成";
            this.Creat_button.UseVisualStyleBackColor = true;
            this.Creat_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_fileName
            // 
            this.text_fileName.Location = new System.Drawing.Point(266, 105);
            this.text_fileName.Name = "text_fileName";
            this.text_fileName.Size = new System.Drawing.Size(325, 21);
            this.text_fileName.TabIndex = 6;
            // 
            // text_postName
            // 
            this.text_postName.Location = new System.Drawing.Point(266, 149);
            this.text_postName.Name = "text_postName";
            this.text_postName.Size = new System.Drawing.Size(325, 21);
            this.text_postName.TabIndex = 7;
            // 
            // text_catName
            // 
            this.text_catName.Location = new System.Drawing.Point(266, 193);
            this.text_catName.Name = "text_catName";
            this.text_catName.Size = new System.Drawing.Size(325, 21);
            this.text_catName.TabIndex = 8;
            // 
            // text_tagsName
            // 
            this.text_tagsName.Location = new System.Drawing.Point(266, 256);
            this.text_tagsName.Name = "text_tagsName";
            this.text_tagsName.Size = new System.Drawing.Size(325, 21);
            this.text_tagsName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "多级分类按照层级使用“，”分隔。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "多个标签使用“，”分隔。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(175, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "生成路径：";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(266, 68);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(325, 21);
            this.filePath.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(751, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_tagsName);
            this.Controls.Add(this.text_catName);
            this.Controls.Add(this.text_postName);
            this.Controls.Add(this.text_fileName);
            this.Controls.Add(this.Creat_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileName);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Creat_button;
        private System.Windows.Forms.TextBox text_fileName;
        private System.Windows.Forms.TextBox text_postName;
        private System.Windows.Forms.TextBox text_catName;
        private System.Windows.Forms.TextBox text_tagsName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

