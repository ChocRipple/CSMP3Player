namespace MP3Player
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PlayerButtonUp = new System.Windows.Forms.Button();
            this.PlayerButtonNext = new System.Windows.Forms.Button();
            this.PlayerButtonMute = new System.Windows.Forms.Button();
            this.PlayerButtonPause = new System.Windows.Forms.Button();
            this.PlayerButtonDown = new System.Windows.Forms.Button();
            this.PlayerButtonBack = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerAlbumNameTitle = new System.Windows.Forms.Label();
            this.TitleArtist = new System.Windows.Forms.Label();
            this.TitleLength = new System.Windows.Forms.Label();
            this.PlayerSongLengthTitle = new System.Windows.Forms.Label();
            this.PlayerArtistNameTitle = new System.Windows.Forms.Label();
            this.TitleAlbum = new System.Windows.Forms.Label();
            this.PlayerSongNameTitle = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LibraryMoveButton = new System.Windows.Forms.TabPage();
            this.LibraryButtonClear = new System.Windows.Forms.Button();
            this.LibraryButtonDown = new System.Windows.Forms.Button();
            this.LibraryButtonUp = new System.Windows.Forms.Button();
            this.ButtonMoveToList = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerVolumeLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.LibraryMoveButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.LibraryMoveButton);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(440, 253);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PlayerButtonUp);
            this.tabPage1.Controls.Add(this.PlayerButtonNext);
            this.tabPage1.Controls.Add(this.PlayerButtonMute);
            this.tabPage1.Controls.Add(this.PlayerButtonPause);
            this.tabPage1.Controls.Add(this.PlayerButtonDown);
            this.tabPage1.Controls.Add(this.PlayerButtonBack);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // PlayerButtonUp
            // 
            this.PlayerButtonUp.Location = new System.Drawing.Point(349, 145);
            this.PlayerButtonUp.Name = "PlayerButtonUp";
            this.PlayerButtonUp.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonUp.TabIndex = 16;
            this.PlayerButtonUp.Text = "Volume +";
            this.PlayerButtonUp.UseVisualStyleBackColor = true;
            this.PlayerButtonUp.Click += new System.EventHandler(this.PlayerButtonUp_Click);
            // 
            // PlayerButtonNext
            // 
            this.PlayerButtonNext.Location = new System.Drawing.Point(349, 111);
            this.PlayerButtonNext.Name = "PlayerButtonNext";
            this.PlayerButtonNext.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonNext.TabIndex = 15;
            this.PlayerButtonNext.Text = "Next";
            this.PlayerButtonNext.UseVisualStyleBackColor = true;
            this.PlayerButtonNext.Click += new System.EventHandler(this.PlayerButtonNext_Click);
            // 
            // PlayerButtonMute
            // 
            this.PlayerButtonMute.Location = new System.Drawing.Point(268, 145);
            this.PlayerButtonMute.Name = "PlayerButtonMute";
            this.PlayerButtonMute.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonMute.TabIndex = 14;
            this.PlayerButtonMute.Text = "Mute";
            this.PlayerButtonMute.UseVisualStyleBackColor = true;
            this.PlayerButtonMute.Click += new System.EventHandler(this.PlayerButtonMute_Click);
            // 
            // PlayerButtonPause
            // 
            this.PlayerButtonPause.Location = new System.Drawing.Point(268, 111);
            this.PlayerButtonPause.Name = "PlayerButtonPause";
            this.PlayerButtonPause.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonPause.TabIndex = 13;
            this.PlayerButtonPause.Text = "Play";
            this.PlayerButtonPause.UseVisualStyleBackColor = true;
            this.PlayerButtonPause.Click += new System.EventHandler(this.PlayerButtonPause_Click);
            // 
            // PlayerButtonDown
            // 
            this.PlayerButtonDown.Location = new System.Drawing.Point(187, 145);
            this.PlayerButtonDown.Name = "PlayerButtonDown";
            this.PlayerButtonDown.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonDown.TabIndex = 12;
            this.PlayerButtonDown.Text = "Volume -";
            this.PlayerButtonDown.UseVisualStyleBackColor = true;
            this.PlayerButtonDown.Click += new System.EventHandler(this.PlayerButtonDown_Click);
            // 
            // PlayerButtonBack
            // 
            this.PlayerButtonBack.Location = new System.Drawing.Point(187, 111);
            this.PlayerButtonBack.Name = "PlayerButtonBack";
            this.PlayerButtonBack.Size = new System.Drawing.Size(75, 28);
            this.PlayerButtonBack.TabIndex = 11;
            this.PlayerButtonBack.Text = "Back";
            this.PlayerButtonBack.UseVisualStyleBackColor = true;
            this.PlayerButtonBack.Click += new System.EventHandler(this.PlayerButtonBack_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 33);
            this.progressBar1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayerAlbumNameTitle);
            this.groupBox1.Controls.Add(this.TitleArtist);
            this.groupBox1.Controls.Add(this.TitleLength);
            this.groupBox1.Controls.Add(this.PlayerSongLengthTitle);
            this.groupBox1.Controls.Add(this.PlayerArtistNameTitle);
            this.groupBox1.Controls.Add(this.TitleAlbum);
            this.groupBox1.Controls.Add(this.PlayerSongNameTitle);
            this.groupBox1.Controls.Add(this.TitleLabel);
            this.groupBox1.Location = new System.Drawing.Point(187, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // PlayerAlbumNameTitle
            // 
            this.PlayerAlbumNameTitle.AutoSize = true;
            this.PlayerAlbumNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PlayerAlbumNameTitle.Location = new System.Drawing.Point(66, 36);
            this.PlayerAlbumNameTitle.Name = "PlayerAlbumNameTitle";
            this.PlayerAlbumNameTitle.Size = new System.Drawing.Size(157, 18);
            this.PlayerAlbumNameTitle.TabIndex = 2;
            this.PlayerAlbumNameTitle.Text = "PlayerAlbumNameTitle";
            // 
            // TitleArtist
            // 
            this.TitleArtist.AutoSize = true;
            this.TitleArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TitleArtist.Location = new System.Drawing.Point(4, 56);
            this.TitleArtist.Name = "TitleArtist";
            this.TitleArtist.Size = new System.Drawing.Size(45, 18);
            this.TitleArtist.TabIndex = 7;
            this.TitleArtist.Text = "Artist:";
            // 
            // TitleLength
            // 
            this.TitleLength.AutoSize = true;
            this.TitleLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TitleLength.Location = new System.Drawing.Point(4, 76);
            this.TitleLength.Name = "TitleLength";
            this.TitleLength.Size = new System.Drawing.Size(56, 18);
            this.TitleLength.TabIndex = 8;
            this.TitleLength.Text = "Length:";
            // 
            // PlayerSongLengthTitle
            // 
            this.PlayerSongLengthTitle.AutoSize = true;
            this.PlayerSongLengthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PlayerSongLengthTitle.Location = new System.Drawing.Point(66, 76);
            this.PlayerSongLengthTitle.Name = "PlayerSongLengthTitle";
            this.PlayerSongLengthTitle.Size = new System.Drawing.Size(155, 18);
            this.PlayerSongLengthTitle.TabIndex = 4;
            this.PlayerSongLengthTitle.Text = "PlayerSongLengthTitle";
            // 
            // PlayerArtistNameTitle
            // 
            this.PlayerArtistNameTitle.AutoSize = true;
            this.PlayerArtistNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PlayerArtistNameTitle.Location = new System.Drawing.Point(66, 56);
            this.PlayerArtistNameTitle.Name = "PlayerArtistNameTitle";
            this.PlayerArtistNameTitle.Size = new System.Drawing.Size(149, 18);
            this.PlayerArtistNameTitle.TabIndex = 3;
            this.PlayerArtistNameTitle.Text = "PlayerArtistNameTitle";
            // 
            // TitleAlbum
            // 
            this.TitleAlbum.AutoSize = true;
            this.TitleAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TitleAlbum.Location = new System.Drawing.Point(4, 36);
            this.TitleAlbum.Name = "TitleAlbum";
            this.TitleAlbum.Size = new System.Drawing.Size(53, 18);
            this.TitleAlbum.TabIndex = 6;
            this.TitleAlbum.Text = "Album:";
            // 
            // PlayerSongNameTitle
            // 
            this.PlayerSongNameTitle.AutoSize = true;
            this.PlayerSongNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PlayerSongNameTitle.Location = new System.Drawing.Point(66, 16);
            this.PlayerSongNameTitle.Name = "PlayerSongNameTitle";
            this.PlayerSongNameTitle.Size = new System.Drawing.Size(151, 18);
            this.PlayerSongNameTitle.TabIndex = 1;
            this.PlayerSongNameTitle.Text = "PlayerSongNameTitle";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TitleLabel.Location = new System.Drawing.Point(4, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 18);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title:";
            // 
            // LibraryMoveButton
            // 
            this.LibraryMoveButton.Controls.Add(this.LibraryButtonClear);
            this.LibraryMoveButton.Controls.Add(this.LibraryButtonDown);
            this.LibraryMoveButton.Controls.Add(this.LibraryButtonUp);
            this.LibraryMoveButton.Controls.Add(this.ButtonMoveToList);
            this.LibraryMoveButton.Controls.Add(this.treeView1);
            this.LibraryMoveButton.Controls.Add(this.listBox2);
            this.LibraryMoveButton.Location = new System.Drawing.Point(4, 22);
            this.LibraryMoveButton.Name = "LibraryMoveButton";
            this.LibraryMoveButton.Padding = new System.Windows.Forms.Padding(3);
            this.LibraryMoveButton.Size = new System.Drawing.Size(432, 227);
            this.LibraryMoveButton.TabIndex = 1;
            this.LibraryMoveButton.Text = "Library";
            this.LibraryMoveButton.UseVisualStyleBackColor = true;
            // 
            // LibraryButtonClear
            // 
            this.LibraryButtonClear.Location = new System.Drawing.Point(213, 93);
            this.LibraryButtonClear.Name = "LibraryButtonClear";
            this.LibraryButtonClear.Size = new System.Drawing.Size(75, 23);
            this.LibraryButtonClear.TabIndex = 5;
            this.LibraryButtonClear.Text = "Clear";
            this.LibraryButtonClear.UseVisualStyleBackColor = true;
            this.LibraryButtonClear.Click += new System.EventHandler(this.LibraryButtonClear_Click);
            // 
            // LibraryButtonDown
            // 
            this.LibraryButtonDown.Enabled = false;
            this.LibraryButtonDown.Location = new System.Drawing.Point(213, 64);
            this.LibraryButtonDown.Name = "LibraryButtonDown";
            this.LibraryButtonDown.Size = new System.Drawing.Size(75, 23);
            this.LibraryButtonDown.TabIndex = 4;
            this.LibraryButtonDown.Text = "\\/";
            this.LibraryButtonDown.UseVisualStyleBackColor = true;
            this.LibraryButtonDown.Click += new System.EventHandler(this.LibraryButtonDown_Click);
            // 
            // LibraryButtonUp
            // 
            this.LibraryButtonUp.Enabled = false;
            this.LibraryButtonUp.Location = new System.Drawing.Point(213, 35);
            this.LibraryButtonUp.Name = "LibraryButtonUp";
            this.LibraryButtonUp.Size = new System.Drawing.Size(75, 23);
            this.LibraryButtonUp.TabIndex = 3;
            this.LibraryButtonUp.Text = "/\\";
            this.LibraryButtonUp.UseVisualStyleBackColor = true;
            this.LibraryButtonUp.Click += new System.EventHandler(this.LibraryButtonUp_Click);
            // 
            // ButtonMoveToList
            // 
            this.ButtonMoveToList.Location = new System.Drawing.Point(213, 6);
            this.ButtonMoveToList.Name = "ButtonMoveToList";
            this.ButtonMoveToList.Size = new System.Drawing.Size(75, 23);
            this.ButtonMoveToList.TabIndex = 2;
            this.ButtonMoveToList.Text = "-->";
            this.ButtonMoveToList.UseVisualStyleBackColor = true;
            this.ButtonMoveToList.Click += new System.EventHandler(this.ButtonMoveToList_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 212);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(294, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 212);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vol:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerVolumeLabel
            // 
            this.PlayerVolumeLabel.AutoSize = true;
            this.PlayerVolumeLabel.Location = new System.Drawing.Point(427, 6);
            this.PlayerVolumeLabel.Name = "PlayerVolumeLabel";
            this.PlayerVolumeLabel.Size = new System.Drawing.Size(10, 13);
            this.PlayerVolumeLabel.TabIndex = 2;
            this.PlayerVolumeLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 275);
            this.Controls.Add(this.PlayerVolumeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LibraryMoveButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage LibraryMoveButton;
        private System.Windows.Forms.Label PlayerSongLengthTitle;
        private System.Windows.Forms.Label PlayerArtistNameTitle;
        private System.Windows.Forms.Label PlayerAlbumNameTitle;
        private System.Windows.Forms.Label PlayerSongNameTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLength;
        private System.Windows.Forms.Label TitleArtist;
        private System.Windows.Forms.Label TitleAlbum;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button PlayerButtonUp;
        private System.Windows.Forms.Button PlayerButtonNext;
        private System.Windows.Forms.Button PlayerButtonMute;
        private System.Windows.Forms.Button PlayerButtonPause;
        private System.Windows.Forms.Button PlayerButtonDown;
        private System.Windows.Forms.Button PlayerButtonBack;
        private System.Windows.Forms.Button LibraryButtonDown;
        private System.Windows.Forms.Button LibraryButtonUp;
        private System.Windows.Forms.Button ButtonMoveToList;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerVolumeLabel;
        private System.Windows.Forms.Button LibraryButtonClear;
    }
}

