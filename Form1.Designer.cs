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
            B_exit = new Button();
            L_acctNum = new Label();
            L_username = new Label();
            L_player = new Label();
            L_balance = new Label();
            L_starLevel = new Label();
            B_camOn = new Button();
            B_camOff = new Button();
            LB_history = new ListBox();
            L_status = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_captured).BeginInit();
            SuspendLayout();
            // 
            // B_takePhoto
            // 
            B_takePhoto.Cursor = Cursors.Hand;
            B_takePhoto.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            B_takePhoto.Location = new Point(273, 173);
            B_takePhoto.Margin = new Padding(4, 5, 4, 5);
            B_takePhoto.Name = "B_takePhoto";
            B_takePhoto.Size = new Size(107, 38);
            B_takePhoto.TabIndex = 0;
            B_takePhoto.Text = "Take Photo";
            B_takePhoto.UseVisualStyleBackColor = true;
            B_takePhoto.Click += B_takePhoto_Click;
            // 
            // B_scan
            // 
            B_scan.Cursor = Cursors.Hand;
            B_scan.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            B_scan.Location = new Point(388, 173);
            B_scan.Margin = new Padding(4, 5, 4, 5);
            B_scan.Name = "B_scan";
            B_scan.Size = new Size(107, 38);
            B_scan.TabIndex = 1;
            B_scan.Text = "Scan";
            B_scan.UseVisualStyleBackColor = true;
            B_scan.Click += B_scan_Click;
            // 
            // PB_photo
            // 
            PB_photo.BackColor = System.Drawing.Color.DarkViolet;
            PB_photo.BackgroundImageLayout = ImageLayout.Center;
            PB_photo.Image = (Image)resources.GetObject("PB_photo.Image");
            PB_photo.InitialImage = null;
            PB_photo.Location = new Point(17, 28);
            PB_photo.Margin = new Padding(4, 5, 4, 5);
            PB_photo.Name = "PB_photo";
            PB_photo.Padding = new Padding(7, 8, 7, 8);
            PB_photo.Size = new Size(240, 135);
            PB_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_photo.TabIndex = 2;
            PB_photo.TabStop = false;
            // 
            // PB_captured
            // 
            PB_captured.BackColor = System.Drawing.Color.DarkViolet;
            PB_captured.BackgroundImageLayout = ImageLayout.Center;
            PB_captured.Image = (Image)resources.GetObject("PB_captured.Image");
            PB_captured.InitialImage = null;
            PB_captured.Location = new Point(265, 28);
            PB_captured.Margin = new Padding(4, 5, 4, 5);
            PB_captured.Name = "PB_captured";
            PB_captured.Padding = new Padding(7, 8, 7, 8);
            PB_captured.Size = new Size(240, 135);
            PB_captured.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_captured.TabIndex = 3;
            PB_captured.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 4;
            label1.Text = "LIVE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(346, 1);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 5;
            label2.Text = "PICTURE";
            // 
            // B_exit
            // 
            B_exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            B_exit.Cursor = Cursors.Hand;
            B_exit.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            B_exit.Location = new Point(1, 632);
            B_exit.Margin = new Padding(4, 5, 4, 5);
            B_exit.Name = "B_exit";
            B_exit.Size = new Size(96, 48);
            B_exit.TabIndex = 6;
            B_exit.Text = "Exit";
            B_exit.UseVisualStyleBackColor = true;
            B_exit.Click += B_exit_Click;
            // 
            // L_acctNum
            // 
            L_acctNum.AutoSize = true;
            L_acctNum.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_acctNum.Location = new Point(513, 28);
            L_acctNum.Margin = new Padding(4, 0, 4, 0);
            L_acctNum.Name = "L_acctNum";
            L_acctNum.Size = new Size(99, 23);
            L_acctNum.TabIndex = 7;
            L_acctNum.Text = "Account #:  ";
            // 
            // L_username
            // 
            L_username.AutoSize = true;
            L_username.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_username.Location = new Point(513, 51);
            L_username.Margin = new Padding(4, 0, 4, 0);
            L_username.Name = "L_username";
            L_username.Size = new Size(98, 23);
            L_username.TabIndex = 9;
            L_username.Text = "Username: ";
            // 
            // L_player
            // 
            L_player.AutoSize = true;
            L_player.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_player.Location = new Point(513, 74);
            L_player.Margin = new Padding(4, 0, 4, 0);
            L_player.Name = "L_player";
            L_player.Size = new Size(67, 23);
            L_player.TabIndex = 10;
            L_player.Text = "Player: ";
            // 
            // L_balance
            // 
            L_balance.AutoSize = true;
            L_balance.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_balance.Location = new Point(513, 97);
            L_balance.Margin = new Padding(4, 0, 4, 0);
            L_balance.Name = "L_balance";
            L_balance.Size = new Size(78, 23);
            L_balance.TabIndex = 11;
            L_balance.Text = "Balance: ";
            // 
            // L_starLevel
            // 
            L_starLevel.AutoSize = true;
            L_starLevel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_starLevel.Location = new Point(513, 120);
            L_starLevel.Margin = new Padding(4, 0, 4, 0);
            L_starLevel.Name = "L_starLevel";
            L_starLevel.Size = new Size(93, 23);
            L_starLevel.TabIndex = 12;
            L_starLevel.Text = "Star Level: ";
            // 
            // B_camOn
            // 
            B_camOn.Location = new Point(51, 173);
            B_camOn.Name = "B_camOn";
            B_camOn.Size = new Size(75, 38);
            B_camOn.TabIndex = 13;
            B_camOn.Text = "On";
            B_camOn.UseVisualStyleBackColor = true;
            B_camOn.Click += B_camOn_Click;
            // 
            // B_camOff
            // 
            B_camOff.Location = new Point(132, 173);
            B_camOff.Name = "B_camOff";
            B_camOff.Size = new Size(75, 38);
            B_camOff.TabIndex = 14;
            B_camOff.Text = "Off";
            B_camOff.UseVisualStyleBackColor = true;
            B_camOff.Click += B_camOff_Click;
            // 
            // LB_history
            // 
            LB_history.FormattingEnabled = true;
            LB_history.ItemHeight = 23;
            LB_history.Location = new Point(725, 173);
            LB_history.Name = "LB_history";
            LB_history.Size = new Size(527, 487);
            LB_history.TabIndex = 15;
            // 
            // L_status
            // 
            L_status.AutoSize = true;
            L_status.BorderStyle = BorderStyle.FixedSingle;
            L_status.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            L_status.Location = new Point(515, 151);
            L_status.Margin = new Padding(4, 0, 4, 0);
            L_status.Name = "L_status";
            L_status.Size = new Size(105, 35);
            L_status.TabIndex = 16;
            L_status.Text = "status...";
            // 
            // SFT_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(L_status);
            Controls.Add(LB_history);
            Controls.Add(B_camOff);
            Controls.Add(B_camOn);
            Controls.Add(L_starLevel);
            Controls.Add(L_balance);
            Controls.Add(L_player);
            Controls.Add(L_username);
            Controls.Add(L_acctNum);
            Controls.Add(B_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PB_captured);
            Controls.Add(PB_photo);
            Controls.Add(B_scan);
            Controls.Add(B_takePhoto);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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
        private Button B_exit;
        private Label L_acctNum;
        private Label L_username;
        private Label L_player;
        private Label L_balance;
        private Label L_starLevel;
        private Button B_camOn;
        private Button B_camOff;
        private ListBox LB_history;
        private Label L_status;
    }
}