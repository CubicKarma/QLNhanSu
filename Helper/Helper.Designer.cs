namespace QLNhanSu.Helper
{
    partial class Helper
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addHelpBTN = new System.Windows.Forms.Button();
            this.editHelpBTN = new System.Windows.Forms.Button();
            this.deleteHelpBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchHelperBTN = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.helpImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchHelperBTN);
            this.panel2.Controls.Add(this.deleteHelpBTN);
            this.panel2.Controls.Add(this.editHelpBTN);
            this.panel2.Controls.Add(this.addHelpBTN);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(648, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 393);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 53);
            this.panel3.TabIndex = 3;
            // 
            // addHelpBTN
            // 
            this.addHelpBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.addHelpBTN.Location = new System.Drawing.Point(0, 53);
            this.addHelpBTN.Name = "addHelpBTN";
            this.addHelpBTN.Size = new System.Drawing.Size(152, 46);
            this.addHelpBTN.TabIndex = 4;
            this.addHelpBTN.Text = "Thêm nhân viên";
            this.addHelpBTN.UseVisualStyleBackColor = true;
            this.addHelpBTN.Click += new System.EventHandler(this.addHelpBTN_Click);
            // 
            // editHelpBTN
            // 
            this.editHelpBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.editHelpBTN.Location = new System.Drawing.Point(0, 99);
            this.editHelpBTN.Name = "editHelpBTN";
            this.editHelpBTN.Size = new System.Drawing.Size(152, 46);
            this.editHelpBTN.TabIndex = 3;
            this.editHelpBTN.Text = "Sửa nhân viên";
            this.editHelpBTN.UseVisualStyleBackColor = true;
            this.editHelpBTN.Click += new System.EventHandler(this.editHelpBTN_Click);
            // 
            // deleteHelpBTN
            // 
            this.deleteHelpBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteHelpBTN.Location = new System.Drawing.Point(0, 145);
            this.deleteHelpBTN.Name = "deleteHelpBTN";
            this.deleteHelpBTN.Size = new System.Drawing.Size(152, 46);
            this.deleteHelpBTN.TabIndex = 3;
            this.deleteHelpBTN.Text = "Xoá nhân viên";
            this.deleteHelpBTN.UseVisualStyleBackColor = true;
            this.deleteHelpBTN.Click += new System.EventHandler(this.deleteHelpBTN_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hướng dẫn sử dụng phần mềm QLNS";
            // 
            // searchHelperBTN
            // 
            this.searchHelperBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchHelperBTN.Location = new System.Drawing.Point(0, 191);
            this.searchHelperBTN.Name = "searchHelperBTN";
            this.searchHelperBTN.Size = new System.Drawing.Size(152, 46);
            this.searchHelperBTN.TabIndex = 5;
            this.searchHelperBTN.Text = "Tìm kiếm nhân viên";
            this.searchHelperBTN.UseVisualStyleBackColor = true;
            this.searchHelperBTN.Click += new System.EventHandler(this.searchHelperBTN_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.helpImage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 393);
            this.panel4.TabIndex = 2;
            // 
            // helpImage
            // 
            this.helpImage.BackColor = System.Drawing.Color.White;
            this.helpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpImage.Location = new System.Drawing.Point(0, 0);
            this.helpImage.Name = "helpImage";
            this.helpImage.Size = new System.Drawing.Size(648, 393);
            this.helpImage.TabIndex = 0;
            this.helpImage.TabStop = false;
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Helper";
            this.Text = "Helper";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.helpImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteHelpBTN;
        private System.Windows.Forms.Button editHelpBTN;
        private System.Windows.Forms.Button addHelpBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchHelperBTN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox helpImage;
    }
}