namespace TanGaiDaiCuong
{
    partial class note
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbLearn = new System.Windows.Forms.RadioButton();
            this.rbDict = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbSubContent = new System.Windows.Forms.TextBox();
            this.lbSubContent = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 51);
            this.panel1.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(65, 14);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(721, 22);
            this.tbTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbContent);
            this.panel2.Location = new System.Drawing.Point(1, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 219);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung:";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(6, 28);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContent.Size = new System.Drawing.Size(780, 188);
            this.tbContent.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbLearn);
            this.panel3.Controls.Add(this.rbDict);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 43);
            this.panel3.TabIndex = 2;
            // 
            // rbLearn
            // 
            this.rbLearn.AutoSize = true;
            this.rbLearn.Location = new System.Drawing.Point(160, 8);
            this.rbLearn.Name = "rbLearn";
            this.rbLearn.Size = new System.Drawing.Size(80, 20);
            this.rbLearn.TabIndex = 5;
            this.rbLearn.Text = "Lý thuyết";
            this.rbLearn.UseVisualStyleBackColor = true;
            // 
            // rbDict
            // 
            this.rbDict.AutoSize = true;
            this.rbDict.Checked = true;
            this.rbDict.Location = new System.Drawing.Point(81, 8);
            this.rbDict.Name = "rbDict";
            this.rbDict.Size = new System.Drawing.Size(73, 20);
            this.rbDict.TabIndex = 4;
            this.rbDict.TabStop = true;
            this.rbDict.Text = "Từ điển";
            this.rbDict.UseVisualStyleBackColor = true;
            this.rbDict.CheckedChanged += new System.EventHandler(this.rbDict_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn loại:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChooseFile);
            this.panel4.Controls.Add(this.tbSubContent);
            this.panel4.Controls.Add(this.lbSubContent);
            this.panel4.Controls.Add(this.btnFinish);
            this.panel4.Location = new System.Drawing.Point(1, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 116);
            this.panel4.TabIndex = 3;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(712, 29);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 35);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Chọn file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Visible = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbSubContent
            // 
            this.tbSubContent.Location = new System.Drawing.Point(6, 29);
            this.tbSubContent.Multiline = true;
            this.tbSubContent.Name = "tbSubContent";
            this.tbSubContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSubContent.Size = new System.Drawing.Size(691, 77);
            this.tbSubContent.TabIndex = 2;
            // 
            // lbSubContent
            // 
            this.lbSubContent.AutoSize = true;
            this.lbSubContent.Location = new System.Drawing.Point(9, 9);
            this.lbSubContent.Name = "lbSubContent";
            this.lbSubContent.Size = new System.Drawing.Size(70, 16);
            this.lbSubContent.TabIndex = 1;
            this.lbSubContent.Text = "Cách xử lý:";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(711, 70);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 36);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "Thêm";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbLearn;
        private System.Windows.Forms.RadioButton rbDict;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbSubContent;
        private System.Windows.Forms.Label lbSubContent;
        private System.Windows.Forms.Button btnFinish;
    }
}