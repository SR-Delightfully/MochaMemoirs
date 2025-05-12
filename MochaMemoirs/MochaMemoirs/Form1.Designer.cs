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
            HomePanel = new System.Windows.Forms.Panel();
            ViewLibrariesPanel = new System.Windows.Forms.Panel();
            FeaturedBookGroupBox = new System.Windows.Forms.GroupBox();
            FeaturedBookPictureBox = new System.Windows.Forms.PictureBox();
            PreviousButton = new System.Windows.Forms.Button();
            NextButton = new System.Windows.Forms.Button();
            PersonalLibraryGroupBox = new System.Windows.Forms.GroupBox();
            HeaderGroupBox = new System.Windows.Forms.GroupBox();
            DateLabel = new System.Windows.Forms.Label();
            TimeLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            SideBarGroupBox = new System.Windows.Forms.GroupBox();
            SettingsButton = new System.Windows.Forms.Button();
            LibraryButton = new System.Windows.Forms.Button();
            HomeButton = new System.Windows.Forms.Button();
            LanguageBox = new System.Windows.Forms.ComboBox();
            LibraryPanel = new System.Windows.Forms.Panel();
            LibraryStageTitleLabel = new System.Windows.Forms.Label();
            SettingsPanel = new System.Windows.Forms.Panel();
            ThemeComboBox = new System.Windows.Forms.ComboBox();
            SettingsPanelTitleLabel = new System.Windows.Forms.Label();
            HomePanel.SuspendLayout();
            FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).BeginInit();
            HeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            SideBarGroupBox.SuspendLayout();
            LibraryPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(ViewLibrariesPanel);
            HomePanel.Controls.Add(FeaturedBookGroupBox);
            HomePanel.Controls.Add(PersonalLibraryGroupBox);
            HomePanel.Controls.Add(HeaderGroupBox);
            HomePanel.Location = new System.Drawing.Point(145, 3);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new System.Drawing.Size(686, 786);
            HomePanel.TabIndex = 0;
            // 
            // ViewLibrariesPanel
            // 
            ViewLibrariesPanel.AutoScroll = true;
            ViewLibrariesPanel.Location = new System.Drawing.Point(3, 418);
            ViewLibrariesPanel.Name = "ViewLibrariesPanel";
            ViewLibrariesPanel.Size = new System.Drawing.Size(467, 352);
            ViewLibrariesPanel.TabIndex = 0;
            // 
            // FeaturedBookGroupBox
            // 
            FeaturedBookGroupBox.Controls.Add(FeaturedBookPictureBox);
            FeaturedBookGroupBox.Controls.Add(PreviousButton);
            FeaturedBookGroupBox.Controls.Add(NextButton);
            FeaturedBookGroupBox.Location = new System.Drawing.Point(478, 407);
            FeaturedBookGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            FeaturedBookGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            FeaturedBookGroupBox.Size = new System.Drawing.Size(202, 363);
            FeaturedBookGroupBox.TabIndex = 12;
            FeaturedBookGroupBox.TabStop = false;
            FeaturedBookGroupBox.Text = "FeaturedBooks";
            // 
            // FeaturedBookPictureBox
            // 
            FeaturedBookPictureBox.Location = new System.Drawing.Point(5, 26);
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.Size = new System.Drawing.Size(192, 285);
            FeaturedBookPictureBox.TabIndex = 3;
            FeaturedBookPictureBox.TabStop = false;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new System.Drawing.Point(5, 318);
            PreviousButton.Margin = new System.Windows.Forms.Padding(2);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size(93, 40);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "&Prev";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new System.Drawing.Point(112, 316);
            NextButton.Margin = new System.Windows.Forms.Padding(2);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(85, 42);
            NextButton.TabIndex = 1;
            NextButton.Text = "&Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // PersonalLibraryGroupBox
            // 
            PersonalLibraryGroupBox.Location = new System.Drawing.Point(2, 207);
            PersonalLibraryGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            PersonalLibraryGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            PersonalLibraryGroupBox.Size = new System.Drawing.Size(679, 194);
            PersonalLibraryGroupBox.TabIndex = 10;
            PersonalLibraryGroupBox.TabStop = false;
            PersonalLibraryGroupBox.Text = "Personal Library";
            // 
            // HeaderGroupBox
            // 
            HeaderGroupBox.BackColor = System.Drawing.Color.Transparent;
            HeaderGroupBox.Controls.Add(DateLabel);
            HeaderGroupBox.Controls.Add(TimeLabel);
            HeaderGroupBox.Controls.Add(TitleLabel);
            HeaderGroupBox.Controls.Add(BannerPictureBox);
            HeaderGroupBox.Location = new System.Drawing.Point(2, 2);
            HeaderGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            HeaderGroupBox.Name = "HeaderGroupBox";
            HeaderGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            HeaderGroupBox.Size = new System.Drawing.Size(679, 199);
            HeaderGroupBox.TabIndex = 9;
            HeaderGroupBox.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            DateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            DateLabel.Image = (System.Drawing.Image)resources.GetObject("DateLabel.Image");
            DateLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            DateLabel.Location = new System.Drawing.Point(4, 162);
            DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(294, 31);
            DateLabel.TabIndex = 0;
            DateLabel.Click += DateLabel_Click;
            // 
            // TimeLabel
            // 
            TimeLabel.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TimeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic);
            TimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            TimeLabel.Image = (System.Drawing.Image)resources.GetObject("TimeLabel.Image");
            TimeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            TimeLabel.Location = new System.Drawing.Point(550, 162);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(123, 31);
            TimeLabel.TabIndex = 1;
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
            // 
            // SideBarGroupBox
            // 
            SideBarGroupBox.Controls.Add(SettingsButton);
            SideBarGroupBox.Controls.Add(LibraryButton);
            SideBarGroupBox.Controls.Add(HomeButton);
            SideBarGroupBox.Controls.Add(LanguageBox);
            SideBarGroupBox.Location = new System.Drawing.Point(2, -6);
            SideBarGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Size = new System.Drawing.Size(138, 788);
            SideBarGroupBox.TabIndex = 8;
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
            LibraryButton.Click += LibraryButton_Click;
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
            HomeButton.Click += HomeButton_Click;
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
            // LibraryPanel
            // 
            LibraryPanel.Controls.Add(LibraryStageTitleLabel);
            LibraryPanel.Location = new System.Drawing.Point(145, 4);
            LibraryPanel.Name = "LibraryPanel";
            LibraryPanel.Size = new System.Drawing.Size(689, 786);
            LibraryPanel.TabIndex = 9;
            // 
            // LibraryStageTitleLabel
            // 
            LibraryStageTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LibraryStageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            LibraryStageTitleLabel.Location = new System.Drawing.Point(15, 24);
            LibraryStageTitleLabel.Name = "LibraryStageTitleLabel";
            LibraryStageTitleLabel.Size = new System.Drawing.Size(659, 73);
            LibraryStageTitleLabel.TabIndex = 0;
            LibraryStageTitleLabel.Text = "Library:";
            LibraryStageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(ThemeComboBox);
            SettingsPanel.Controls.Add(SettingsPanelTitleLabel);
            SettingsPanel.Location = new System.Drawing.Point(145, 5);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new System.Drawing.Size(686, 783);
            SettingsPanel.TabIndex = 10;
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { "Light", "Dark" });
            ThemeComboBox.Location = new System.Drawing.Point(15, 140);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new System.Drawing.Size(265, 28);
            ThemeComboBox.TabIndex = 1;
            // 
            // SettingsPanelTitleLabel
            // 
            SettingsPanelTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            SettingsPanelTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            SettingsPanelTitleLabel.Location = new System.Drawing.Point(15, 24);
            SettingsPanelTitleLabel.Name = "SettingsPanelTitleLabel";
            SettingsPanelTitleLabel.Size = new System.Drawing.Size(659, 73);
            SettingsPanelTitleLabel.TabIndex = 0;
            SettingsPanelTitleLabel.Text = "Settings:";
            SettingsPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MochaMemoirsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 783);
            Controls.Add(HomePanel);
            Controls.Add(LibraryPanel);
            Controls.Add(SettingsPanel);
            Controls.Add(SideBarGroupBox);
            Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            Name = "MochaMemoirsForm";
            Text = "Mocha Memoirs";
            Load += MochaMemoirsForm_Load;
            HomePanel.ResumeLayout(false);
            FeaturedBookGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).EndInit();
            HeaderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).EndInit();
            SideBarGroupBox.ResumeLayout(false);
            LibraryPanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.GroupBox FeaturedBookGroupBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox FeaturedBookPictureBox;
        private System.Windows.Forms.GroupBox PersonalLibraryGroupBox;
        private System.Windows.Forms.GroupBox HeaderGroupBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LibraryButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ComboBox LanguageBox;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label SettingsPanelTitleLabel;
        private System.Windows.Forms.Label LibraryStageTitleLabel;
        private System.Windows.Forms.Panel ViewLibrariesPanel;
        private System.Windows.Forms.ComboBox ThemeComboBox;
    }
}
