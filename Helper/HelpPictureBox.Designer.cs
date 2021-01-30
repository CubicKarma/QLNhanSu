namespace QLNhanSu.Helper
{
    partial class HelpPictureBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelPic = new System.Windows.Forms.Panel();
            this.helperPic = new System.Windows.Forms.PictureBox();
            this.panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helperPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 397);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(689, 30);
            this.panelButton.TabIndex = 0;
            // 
            // panelPic
            // 
            this.panelPic.Controls.Add(this.helperPic);
            this.panelPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPic.Location = new System.Drawing.Point(0, 0);
            this.panelPic.Name = "panelPic";
            this.panelPic.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelPic.Size = new System.Drawing.Size(689, 397);
            this.panelPic.TabIndex = 1;
            // 
            // helperPic
            // 
            this.helperPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helperPic.Location = new System.Drawing.Point(3, 3);
            this.helperPic.Name = "helperPic";
            this.helperPic.Size = new System.Drawing.Size(683, 394);
            this.helperPic.TabIndex = 0;
            this.helperPic.TabStop = false;
            // 
            // HelpPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPic);
            this.Controls.Add(this.panelButton);
            this.Name = "HelpPictureBox";
            this.Size = new System.Drawing.Size(689, 427);
            this.panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helperPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelPic;
        private System.Windows.Forms.PictureBox helperPic;
    }
}
