namespace TanGaiDaiCuong
{
    partial class welcome
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.goNote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goLearn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goDict = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.goNote);
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 96);
            this.panel3.TabIndex = 2;
            // 
            // goNote
            // 
            this.goNote.Location = new System.Drawing.Point(3, 3);
            this.goNote.Name = "goNote";
            this.goNote.Size = new System.Drawing.Size(795, 90);
            this.goNote.TabIndex = 2;
            this.goNote.Text = "THÊM GHI CHÚ";
            this.goNote.UseVisualStyleBackColor = true;
            this.goNote.Click += new System.EventHandler(this.goNote_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.goLearn);
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 96);
            this.panel1.TabIndex = 3;
            // 
            // goLearn
            // 
            this.goLearn.Location = new System.Drawing.Point(3, 3);
            this.goLearn.Name = "goLearn";
            this.goLearn.Size = new System.Drawing.Size(795, 90);
            this.goLearn.TabIndex = 1;
            this.goLearn.Text = "ĐỌC LÝ THUYẾT TÁN GÁI";
            this.goLearn.UseVisualStyleBackColor = true;
            this.goLearn.Click += new System.EventHandler(this.goLearn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goDict);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 96);
            this.panel2.TabIndex = 4;
            // 
            // goDict
            // 
            this.goDict.Location = new System.Drawing.Point(3, 3);
            this.goDict.Name = "goDict";
            this.goDict.Size = new System.Drawing.Size(795, 90);
            this.goDict.TabIndex = 0;
            this.goDict.Text = "TRA TỪ ĐIỂN TIẾNG EM";
            this.goDict.UseVisualStyleBackColor = true;
            this.goDict.Click += new System.EventHandler(this.goDict_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 96);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÁN GÁI ĐẠI CƯƠNG";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "welcome";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goNote;
        private System.Windows.Forms.Button goLearn;
        private System.Windows.Forms.Button goDict;
    }
}

