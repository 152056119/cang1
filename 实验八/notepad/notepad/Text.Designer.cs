namespace notepad
{
    partial class Text
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_document = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_clear_document = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_save_document = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_check = new System.Windows.Forms.ToolStripMenuItem();
            this.查看保存文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.文本背景toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具栏toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对齐toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.左对齐toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.右对齐toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.居中toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.剪切toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.复制toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.粘贴toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_document,
            this.MenuItem_check,
            this.toolStripMenuItem1,
            this.工具toolStripMenuItem5,
            this.MenuItem_help,
            this.退出ToolStripMenuItem,
            this.对齐toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_document
            // 
            this.MenuItem_document.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_clear_document,
            this.MenuItem_save_document,
            this.toolStripMenuItem4});
            this.MenuItem_document.Name = "MenuItem_document";
            this.MenuItem_document.Size = new System.Drawing.Size(61, 21);
            this.MenuItem_document.Text = "文件(&D)";
            this.MenuItem_document.Click += new System.EventHandler(this.MenuItem_document_Click);
            // 
            // MenuItem_clear_document
            // 
            this.MenuItem_clear_document.Name = "MenuItem_clear_document";
            this.MenuItem_clear_document.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_clear_document.Text = "新建文件";
            this.MenuItem_clear_document.Click += new System.EventHandler(this.MenuItem_clear_document_Click);
            // 
            // MenuItem_save_document
            // 
            this.MenuItem_save_document.Name = "MenuItem_save_document";
            this.MenuItem_save_document.Size = new System.Drawing.Size(124, 22);
            this.MenuItem_save_document.Text = "保存文件";
            this.MenuItem_save_document.Click += new System.EventHandler(this.MenuItem_save_document_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem4.Text = "打开文件";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // MenuItem_check
            // 
            this.MenuItem_check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看保存文档ToolStripMenuItem,
            this.个人信息ToolStripMenuItem});
            this.MenuItem_check.Name = "MenuItem_check";
            this.MenuItem_check.Size = new System.Drawing.Size(60, 21);
            this.MenuItem_check.Text = "查看(&C)";
            // 
            // 查看保存文档ToolStripMenuItem
            // 
            this.查看保存文档ToolStripMenuItem.Name = "查看保存文档ToolStripMenuItem";
            this.查看保存文档ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看保存文档ToolStripMenuItem.Text = "查看保存文档";
            this.查看保存文档ToolStripMenuItem.Click += new System.EventHandler(this.查看保存文档ToolStripMenuItem_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.文本背景toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "格式";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "字体";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem3.Text = "字体颜色";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 文本背景toolStripMenuItem5
            // 
            this.文本背景toolStripMenuItem5.Name = "文本背景toolStripMenuItem5";
            this.文本背景toolStripMenuItem5.Size = new System.Drawing.Size(124, 22);
            this.文本背景toolStripMenuItem5.Text = "文本背景";
            this.文本背景toolStripMenuItem5.Click += new System.EventHandler(this.文本背景toolStripMenuItem5_Click);
            // 
            // 工具toolStripMenuItem5
            // 
            this.工具toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具栏toolStripMenuItem5});
            this.工具toolStripMenuItem5.Name = "工具toolStripMenuItem5";
            this.工具toolStripMenuItem5.Size = new System.Drawing.Size(44, 21);
            this.工具toolStripMenuItem5.Text = "工具";
            // 
            // 工具栏toolStripMenuItem5
            // 
            this.工具栏toolStripMenuItem5.Checked = true;
            this.工具栏toolStripMenuItem5.CheckOnClick = true;
            this.工具栏toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.工具栏toolStripMenuItem5.Name = "工具栏toolStripMenuItem5";
            this.工具栏toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.工具栏toolStripMenuItem5.Text = "工具栏";
            this.工具栏toolStripMenuItem5.Click += new System.EventHandler(this.工具栏toolStripMenuItem5_Click);
            // 
            // MenuItem_help
            // 
            this.MenuItem_help.Name = "MenuItem_help";
            this.MenuItem_help.Size = new System.Drawing.Size(44, 21);
            this.MenuItem_help.Text = "帮助";
            this.MenuItem_help.Click += new System.EventHandler(this.MenuItem_help_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 对齐toolStripMenuItem5
            // 
            this.对齐toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左对齐toolStripMenuItem5,
            this.右对齐toolStripMenuItem6,
            this.居中toolStripMenuItem5});
            this.对齐toolStripMenuItem5.Name = "对齐toolStripMenuItem5";
            this.对齐toolStripMenuItem5.Size = new System.Drawing.Size(44, 21);
            this.对齐toolStripMenuItem5.Text = "对齐";
            // 
            // 左对齐toolStripMenuItem5
            // 
            this.左对齐toolStripMenuItem5.Checked = true;
            this.左对齐toolStripMenuItem5.CheckOnClick = true;
            this.左对齐toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.左对齐toolStripMenuItem5.Name = "左对齐toolStripMenuItem5";
            this.左对齐toolStripMenuItem5.Size = new System.Drawing.Size(126, 22);
            this.左对齐toolStripMenuItem5.Text = "左对齐(L)";
            this.左对齐toolStripMenuItem5.Click += new System.EventHandler(this.左对齐toolStripMenuItem5_Click);
            // 
            // 右对齐toolStripMenuItem6
            // 
            this.右对齐toolStripMenuItem6.Checked = true;
            this.右对齐toolStripMenuItem6.CheckOnClick = true;
            this.右对齐toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.右对齐toolStripMenuItem6.Name = "右对齐toolStripMenuItem6";
            this.右对齐toolStripMenuItem6.Size = new System.Drawing.Size(126, 22);
            this.右对齐toolStripMenuItem6.Text = "右对齐";
            this.右对齐toolStripMenuItem6.Click += new System.EventHandler(this.右对齐toolStripMenuItem6_Click);
            // 
            // 居中toolStripMenuItem5
            // 
            this.居中toolStripMenuItem5.Checked = true;
            this.居中toolStripMenuItem5.CheckOnClick = true;
            this.居中toolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.居中toolStripMenuItem5.Name = "居中toolStripMenuItem5";
            this.居中toolStripMenuItem5.Size = new System.Drawing.Size(126, 22);
            this.居中toolStripMenuItem5.Text = "居中";
            this.居中toolStripMenuItem5.Click += new System.EventHandler(this.居中toolStripMenuItem5_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.Color.Red;
            this.label_title.Location = new System.Drawing.Point(12, 372);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(48, 16);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "label";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "日记",
            "随笔",
            "其他"});
            this.comboBox_type.Location = new System.Drawing.Point(469, 3);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_type.TabIndex = 3;
            this.comboBox_type.Text = "日记本";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_type.Location = new System.Drawing.Point(413, 4);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(35, 14);
            this.label_type.TabIndex = 4;
            this.label_type.Text = "类型";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(391, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(350, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 312);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切toolStripButton1,
            this.复制toolStripButton2,
            this.粘贴toolStripButton3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 剪切toolStripButton1
            // 
            this.剪切toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("剪切toolStripButton1.Image")));
            this.剪切toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切toolStripButton1.Name = "剪切toolStripButton1";
            this.剪切toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.剪切toolStripButton1.Text = "剪切(&U)";
            this.剪切toolStripButton1.Click += new System.EventHandler(this.剪切toolStripButton1_Click);
            // 
            // 复制toolStripButton2
            // 
            this.复制toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("复制toolStripButton2.Image")));
            this.复制toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制toolStripButton2.Name = "复制toolStripButton2";
            this.复制toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.复制toolStripButton2.Text = "复制(&C)";
            this.复制toolStripButton2.Click += new System.EventHandler(this.复制toolStripButton2_Click);
            // 
            // 粘贴toolStripButton3
            // 
            this.粘贴toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("粘贴toolStripButton3.Image")));
            this.粘贴toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴toolStripButton3.Name = "粘贴toolStripButton3";
            this.粘贴toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.粘贴toolStripButton3.Text = "粘贴(&P)";
            this.粘贴toolStripButton3.Click += new System.EventHandler(this.粘贴toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Text";
            this.Text = "Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Text_FormClosing);
            this.Load += new System.EventHandler(this.Text_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_save_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_clear_document;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_check;
        private System.Windows.Forms.ToolStripMenuItem 查看保存文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_help;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 文本背景toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 工具toolStripMenuItem5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具栏toolStripMenuItem5;
        private System.Windows.Forms.ToolStripButton 剪切toolStripButton1;
        private System.Windows.Forms.ToolStripButton 复制toolStripButton2;
        private System.Windows.Forms.ToolStripButton 粘贴toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 对齐toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 左对齐toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 右对齐toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 居中toolStripMenuItem5;

    }
}