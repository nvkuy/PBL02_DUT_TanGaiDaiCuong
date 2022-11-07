namespace TanGaiDaiCuong
{
    partial class detailDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailDoc));
            this.flowContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lbContent = new System.Windows.Forms.Label();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbResponse = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.flowContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // flowContent
            // 
            this.flowContent.AutoScroll = true;
            this.flowContent.Controls.Add(this.lbContent);
            this.flowContent.Controls.Add(this.videoPlayer);
            this.flowContent.Controls.Add(this.lbResponse);
            this.flowContent.Location = new System.Drawing.Point(1, 37);
            this.flowContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowContent.Name = "flowContent";
            this.flowContent.Size = new System.Drawing.Size(816, 459);
            this.flowContent.TabIndex = 0;
            // 
            // lbContent
            // 
            this.lbContent.Location = new System.Drawing.Point(3, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(813, 23);
            this.lbContent.TabIndex = 0;
            this.lbContent.Text = "content";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(3, 26);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(813, 378);
            this.videoPlayer.TabIndex = 1;
            // 
            // lbResponse
            // 
            this.lbResponse.Location = new System.Drawing.Point(3, 407);
            this.lbResponse.Name = "lbResponse";
            this.lbResponse.Size = new System.Drawing.Size(813, 23);
            this.lbResponse.TabIndex = 2;
            this.lbResponse.Text = "Response";
            this.lbResponse.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(1, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(816, 23);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tiêu đề";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 497);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.flowContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detailDoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.detailDoc_FormClosing);
            this.flowContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowContent;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbContent;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Label lbResponse;
    }
}