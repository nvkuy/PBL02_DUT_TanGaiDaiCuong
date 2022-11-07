namespace TanGaiDaiCuong
{
    partial class learn
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
            this.lvLearn = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvLearn);
            this.panel3.Location = new System.Drawing.Point(5, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 446);
            this.panel3.TabIndex = 1;
            // 
            // lvLearn
            // 
            this.lvLearn.HideSelection = false;
            this.lvLearn.Location = new System.Drawing.Point(4, 0);
            this.lvLearn.Margin = new System.Windows.Forms.Padding(4);
            this.lvLearn.MultiSelect = false;
            this.lvLearn.Name = "lvLearn";
            this.lvLearn.Size = new System.Drawing.Size(783, 445);
            this.lvLearn.TabIndex = 0;
            this.lvLearn.UseCompatibleStateImageBehavior = false;
            this.lvLearn.View = System.Windows.Forms.View.List;
            this.lvLearn.SelectedIndexChanged += new System.EventHandler(this.lvLearn_SelectedIndexChanged);
            // 
            // learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "learn";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvLearn;
    }
}