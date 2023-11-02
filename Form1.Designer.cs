using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace SovereignFinances
{
    partial class SFT_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFT_Form));
            B_takePhoto = new Button();
            B_scan = new Button();
            PB_photo = new PictureBox();
            PB_captured = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_captured).BeginInit();
            SuspendLayout();
            // 
            // B_takePhoto
            // 
            B_takePhoto.Location = new Point(302, 169);
            B_takePhoto.Name = "B_takePhoto";
            B_takePhoto.Size = new Size(75, 23);
            B_takePhoto.TabIndex = 0;
            B_takePhoto.Text = "Take Photo";
            B_takePhoto.UseVisualStyleBackColor = true;
            B_takePhoto.Click += B_takePhoto_Click;
            // 
            // B_scan
            // 
            B_scan.Location = new Point(383, 169);
            B_scan.Name = "B_scan";
            B_scan.Size = new Size(75, 23);
            B_scan.TabIndex = 1;
            B_scan.Text = "Scan";
            B_scan.UseVisualStyleBackColor = true;
            B_scan.Click += B_scan_Click;
            // 
            // PB_photo
            // 
            PB_photo.BackgroundImageLayout = ImageLayout.Center;
            PB_photo.Image = (Image)resources.GetObject("PB_photo.Image");
            PB_photo.InitialImage = null;
            PB_photo.Location = new Point(12, 28);
            PB_photo.Name = "PB_photo";
            PB_photo.Size = new Size(240, 135);
            PB_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_photo.TabIndex = 2;
            PB_photo.TabStop = false;
            // 
            // PB_captured
            // 
            PB_captured.BackgroundImageLayout = ImageLayout.Center;
            PB_captured.Image = (Image)resources.GetObject("PB_captured.Image");
            PB_captured.InitialImage = null;
            PB_captured.Location = new Point(258, 28);
            PB_captured.Name = "PB_captured";
            PB_captured.Size = new Size(240, 135);
            PB_captured.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_captured.TabIndex = 3;
            PB_captured.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "LIVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Picture";
            // 
            // SFT_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PB_captured);
            Controls.Add(PB_photo);
            Controls.Add(B_scan);
            Controls.Add(B_takePhoto);
            Name = "SFT_Form";
            Text = "Sovereign Finances Terminal";
            FormClosing += MainForm_FormClosing;
            Load += SFT_Form_Load;
            ((System.ComponentModel.ISupportInitialize)PB_photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_captured).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B_takePhoto;
        private Button B_scan;
        private PictureBox PB_photo;
        private PictureBox PB_captured;
        private Label label1;
        private Label label2;
    }
}