namespace MochaMemoirs
{
    partial class MochaMemoirsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MochaMemoirsForm));
            DateLabel = new System.Windows.Forms.Label();
            TimeLabel = new System.Windows.Forms.Label();
            SideBarGroupBox = new System.Windows.Forms.GroupBox();
            SettingsButton = new System.Windows.Forms.Button();
            LibraryButton = new System.Windows.Forms.Button();
            HomeButton = new System.Windows.Forms.Button();
            LanguageBox = new System.Windows.Forms.ComboBox();
            HeaderGroupBox = new System.Windows.Forms.GroupBox();
            TitleLabel = new System.Windows.Forms.Label();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            PersonalLibraryGroupBox = new System.Windows.Forms.GroupBox();
            ViewLibrariesGroupBox = new System.Windows.Forms.GroupBox();
            FeaturedBookGroupBox = new System.Windows.Forms.GroupBox();
            PreviousButton = new System.Windows.Forms.Button();
            NextButton = new System.Windows.Forms.Button();
            FeaturedBookPictureBox = new System.Windows.Forms.PictureBox();
            SideBarGroupBox.SuspendLayout();
            HeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            DateLabel.Image = (System.Drawing.Image)resources.GetObject("DateLabel.Image");
            DateLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            DateLabel.Location = new System.Drawing.Point(4, 162);
            DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(294, 31);
            DateLabel.TabIndex = 0;
            // 
            // TimeLabel
            // 
            TimeLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            TimeLabel.Image = (System.Drawing.Image)resources.GetObject("TimeLabel.Image");
            TimeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            TimeLabel.Location = new System.Drawing.Point(550, 162);
            TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(123, 31);
            TimeLabel.TabIndex = 1;
            // 
            // SideBarGroupBox
            // 
            SideBarGroupBox.Controls.Add(SettingsButton);
            SideBarGroupBox.Controls.Add(LibraryButton);
            SideBarGroupBox.Controls.Add(HomeButton);
            SideBarGroupBox.Controls.Add(LanguageBox);
            SideBarGroupBox.Location = new System.Drawing.Point(2, -8);
            SideBarGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Size = new System.Drawing.Size(138, 779);
            SideBarGroupBox.TabIndex = 3;
            SideBarGroupBox.TabStop = false;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = System.Drawing.Color.PeachPuff;
            SettingsButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            SettingsButton.ForeColor = System.Drawing.Color.MidnightBlue;
            SettingsButton.Location = new System.Drawing.Point(32, 337);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(72, 73);
            SettingsButton.TabIndex = 0;
            SettingsButton.Text = "🔧";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // LibraryButton
            // 
            LibraryButton.BackColor = System.Drawing.Color.PeachPuff;
            LibraryButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            LibraryButton.ForeColor = System.Drawing.Color.MidnightBlue;
            LibraryButton.Location = new System.Drawing.Point(32, 179);
            LibraryButton.Name = "LibraryButton";
            LibraryButton.Size = new System.Drawing.Size(72, 73);
            LibraryButton.TabIndex = 1;
            LibraryButton.Text = "📖";
            LibraryButton.UseVisualStyleBackColor = false;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = System.Drawing.Color.PeachPuff;
            HomeButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            HomeButton.ForeColor = System.Drawing.Color.MidnightBlue;
            HomeButton.Location = new System.Drawing.Point(32, 26);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new System.Drawing.Size(72, 73);
            HomeButton.TabIndex = 2;
            HomeButton.Text = "🏠︎";
            HomeButton.UseVisualStyleBackColor = false;
            // 
            // LanguageBox
            // 
            LanguageBox.FormattingEnabled = true;
            LanguageBox.Items.AddRange(new object[] { "English", "French", "Spanish" });
            LanguageBox.Location = new System.Drawing.Point(19, 732);
            LanguageBox.Name = "LanguageBox";
            LanguageBox.Size = new System.Drawing.Size(100, 28);
            LanguageBox.TabIndex = 0;
            LanguageBox.Text = "Languages";
            // 
            // HeaderGroupBox
            // 
            HeaderGroupBox.BackColor = System.Drawing.Color.Transparent;
            HeaderGroupBox.Controls.Add(DateLabel);
            HeaderGroupBox.Controls.Add(TimeLabel);
            HeaderGroupBox.Controls.Add(TitleLabel);
            HeaderGroupBox.Controls.Add(BannerPictureBox);
            HeaderGroupBox.Location = new System.Drawing.Point(144, 3);
            HeaderGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            HeaderGroupBox.Name = "HeaderGroupBox";
            HeaderGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            HeaderGroupBox.Size = new System.Drawing.Size(679, 199);
            HeaderGroupBox.TabIndex = 4;
            HeaderGroupBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = System.Drawing.Color.Transparent;
            TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            TitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            TitleLabel.Image = (System.Drawing.Image)resources.GetObject("TitleLabel.Image");
            TitleLabel.Location = new System.Drawing.Point(0, 69);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(678, 54);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Mocha Memoirs";
            TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TitleLabel.UseCompatibleTextRendering = true;
            TitleLabel.Click += TitleLabel_Click;
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = (System.Drawing.Image)resources.GetObject("BannerPictureBox.Image");
            BannerPictureBox.Location = new System.Drawing.Point(0, -11);
            BannerPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.Size = new System.Drawing.Size(678, 209);
            BannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BannerPictureBox.TabIndex = 3;
            BannerPictureBox.TabStop = false;
            BannerPictureBox.Click += BannerPictureBox_Click;
            // 
            // PersonalLibraryGroupBox
            // 
            PersonalLibraryGroupBox.Location = new System.Drawing.Point(144, 203);
            PersonalLibraryGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            PersonalLibraryGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PersonalLibraryGroupBox.Size = new System.Drawing.Size(679, 199);
            PersonalLibraryGroupBox.TabIndex = 5;
            PersonalLibraryGroupBox.TabStop = false;
            PersonalLibraryGroupBox.Text = "Personal Library";
            // 
            // ViewLibrariesGroupBox
            // 
            ViewLibrariesGroupBox.Location = new System.Drawing.Point(144, 408);
            ViewLibrariesGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ViewLibrariesGroupBox.Name = "ViewLibrariesGroupBox";
            ViewLibrariesGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            ViewLibrariesGroupBox.Size = new System.Drawing.Size(470, 363);
            ViewLibrariesGroupBox.TabIndex = 6;
            ViewLibrariesGroupBox.TabStop = false;
            ViewLibrariesGroupBox.Text = "ViewLibraries";
            // 
            // FeaturedBookGroupBox
            // 
            FeaturedBookGroupBox.Controls.Add(PreviousButton);
            FeaturedBookGroupBox.Controls.Add(NextButton);
            FeaturedBookGroupBox.Controls.Add(FeaturedBookPictureBox);
            FeaturedBookGroupBox.Location = new System.Drawing.Point(620, 408);
            FeaturedBookGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            FeaturedBookGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            FeaturedBookGroupBox.Size = new System.Drawing.Size(202, 363);
            FeaturedBookGroupBox.TabIndex = 7;
            FeaturedBookGroupBox.TabStop = false;
            FeaturedBookGroupBox.Text = "FeaturedBooks";
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new System.Drawing.Point(6, 316);
            PreviousButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size(89, 35);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "&Prev";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new System.Drawing.Point(110, 316);
            NextButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(89, 35);
            NextButton.TabIndex = 1;
            NextButton.Text = "&Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // FeaturedBookPictureBox
            // 
            FeaturedBookPictureBox.Location = new System.Drawing.Point(6, 27);
            FeaturedBookPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.Size = new System.Drawing.Size(191, 275);
            FeaturedBookPictureBox.TabIndex = 0;
            FeaturedBookPictureBox.TabStop = false;
            // 
            // MochaMemoirsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 783);
            Controls.Add(FeaturedBookGroupBox);
            Controls.Add(ViewLibrariesGroupBox);
            Controls.Add(PersonalLibraryGroupBox);
            Controls.Add(HeaderGroupBox);
            Controls.Add(SideBarGroupBox);
            Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            Name = "MochaMemoirsForm";
            Text = "Mocha Memoirs";
            Load += MochaMemoirsForm_Load;
            SideBarGroupBox.ResumeLayout(false);
            HeaderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).EndInit();
            FeaturedBookGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.GroupBox HeaderGroupBox;
        private System.Windows.Forms.GroupBox PersonalLibraryGroupBox;
        private System.Windows.Forms.GroupBox ViewLibrariesGroupBox;
        private System.Windows.Forms.GroupBox FeaturedBookGroupBox;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.PictureBox FeaturedBookPictureBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox LanguageBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LibraryButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

