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
            booksDataGridView = new System.Windows.Forms.DataGridView();
            DeleteButton = new System.Windows.Forms.Button();
            EditButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            genreTextBox = new System.Windows.Forms.TextBox();
            genreLabel = new System.Windows.Forms.Label();
            bookIdTextBox = new System.Windows.Forms.TextBox();
            RefreshButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();
            bookIdLabel = new System.Windows.Forms.Label();
            publisherTextBox = new System.Windows.Forms.TextBox();
            authorTextBox = new System.Windows.Forms.TextBox();
            titleTextBox = new System.Windows.Forms.TextBox();
            detailsPublisherLabel = new System.Windows.Forms.Label();
            detailsAuthor = new System.Windows.Forms.Label();
            titleDetailsLabel = new System.Windows.Forms.Label();
            DetailsLabel = new System.Windows.Forms.Label();
            LibraryStageTitleLabel = new System.Windows.Forms.Label();
            SettingsPanel = new System.Windows.Forms.Panel();
            ThemeComboBox = new System.Windows.Forms.ComboBox();
            SettingsPanelTitleLabel = new System.Windows.Forms.Label();
            viewLibrariesGroupBox = new System.Windows.Forms.GroupBox();
            HomePanel.SuspendLayout();
            FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).BeginInit();
            HeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            SideBarGroupBox.SuspendLayout();
            LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
            panel1.SuspendLayout();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(ViewLibrariesPanel);
            HomePanel.Controls.Add(FeaturedBookGroupBox);
            HomePanel.Controls.Add(PersonalLibraryGroupBox);
            HomePanel.Controls.Add(HeaderGroupBox);
            HomePanel.Location = new System.Drawing.Point(145, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new System.Drawing.Size(686, 790);
            HomePanel.TabIndex = 0;
            // 
            // ViewLibrariesPanel
            // 
            ViewLibrariesPanel.AutoScroll = true;
            ViewLibrariesPanel.Location = new System.Drawing.Point(0, 417);
            ViewLibrariesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ViewLibrariesPanel.Name = "ViewLibrariesPanel";
            ViewLibrariesPanel.Size = new System.Drawing.Size(473, 353);
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
            FeaturedBookPictureBox.Location = new System.Drawing.Point(5, 27);
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.Size = new System.Drawing.Size(192, 285);
            FeaturedBookPictureBox.TabIndex = 3;
            FeaturedBookPictureBox.TabStop = false;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new System.Drawing.Point(5, 317);
            PreviousButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            NextButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(85, 43);
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
            PersonalLibraryGroupBox.Size = new System.Drawing.Size(679, 195);
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
            HeaderGroupBox.Location = new System.Drawing.Point(2, 3);
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
            DateLabel.Location = new System.Drawing.Point(5, 163);
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
            TimeLabel.Location = new System.Drawing.Point(514, 163);
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
            TitleLabel.Size = new System.Drawing.Size(678, 53);
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
            SideBarGroupBox.Location = new System.Drawing.Point(2, 0);
            SideBarGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            SideBarGroupBox.Size = new System.Drawing.Size(138, 783);
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
            HomeButton.Location = new System.Drawing.Point(32, 27);
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
            LibraryPanel.Controls.Add(booksDataGridView);
            LibraryPanel.Controls.Add(DeleteButton);
            LibraryPanel.Controls.Add(EditButton);
            LibraryPanel.Controls.Add(AddButton);
            LibraryPanel.Controls.Add(panel1);
            LibraryPanel.Controls.Add(LibraryStageTitleLabel);
            LibraryPanel.Location = new System.Drawing.Point(145, 0);
            LibraryPanel.Name = "LibraryPanel";
            LibraryPanel.Size = new System.Drawing.Size(684, 780);
            LibraryPanel.TabIndex = 9;
            // 
            // booksDataGridView
            // 
            booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Location = new System.Drawing.Point(102, 185);
            booksDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.RowHeadersWidth = 51;
            booksDataGridView.Size = new System.Drawing.Size(483, 267);
            booksDataGridView.TabIndex = 9;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(467, 117);
            DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(118, 51);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new System.Drawing.Point(286, 117);
            EditButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(114, 51);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new System.Drawing.Point(103, 117);
            AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(123, 51);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(genreTextBox);
            panel1.Controls.Add(genreLabel);
            panel1.Controls.Add(bookIdTextBox);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(bookIdLabel);
            panel1.Controls.Add(publisherTextBox);
            panel1.Controls.Add(authorTextBox);
            panel1.Controls.Add(titleTextBox);
            panel1.Controls.Add(detailsPublisherLabel);
            panel1.Controls.Add(detailsAuthor);
            panel1.Controls.Add(titleDetailsLabel);
            panel1.Controls.Add(DetailsLabel);
            panel1.Location = new System.Drawing.Point(103, 460);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(482, 293);
            panel1.TabIndex = 3;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new System.Drawing.Point(101, 169);
            genreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new System.Drawing.Size(367, 27);
            genreTextBox.TabIndex = 15;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            genreLabel.Location = new System.Drawing.Point(26, 167);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(68, 28);
            genreLabel.TabIndex = 14;
            genreLabel.Text = "Genre:";
            // 
            // bookIdTextBox
            // 
            bookIdTextBox.Location = new System.Drawing.Point(101, 48);
            bookIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bookIdTextBox.Name = "bookIdTextBox";
            bookIdTextBox.Size = new System.Drawing.Size(367, 27);
            bookIdTextBox.TabIndex = 13;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new System.Drawing.Point(383, 256);
            RefreshButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new System.Drawing.Size(86, 31);
            RefreshButton.TabIndex = 11;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += loadButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(280, 256);
            ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(86, 31);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            bookIdLabel.Location = new System.Drawing.Point(46, 48);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(35, 28);
            bookIdLabel.TabIndex = 12;
            bookIdLabel.Text = "ID:";
            // 
            // publisherTextBox
            // 
            publisherTextBox.Location = new System.Drawing.Point(101, 211);
            publisherTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new System.Drawing.Size(367, 27);
            publisherTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new System.Drawing.Point(101, 125);
            authorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new System.Drawing.Size(367, 27);
            authorTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new System.Drawing.Point(101, 87);
            titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(367, 27);
            titleTextBox.TabIndex = 4;
            // 
            // detailsPublisherLabel
            // 
            detailsPublisherLabel.AutoSize = true;
            detailsPublisherLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            detailsPublisherLabel.Location = new System.Drawing.Point(9, 208);
            detailsPublisherLabel.Name = "detailsPublisherLabel";
            detailsPublisherLabel.Size = new System.Drawing.Size(96, 28);
            detailsPublisherLabel.TabIndex = 3;
            detailsPublisherLabel.Text = "Publisher:";
            // 
            // detailsAuthor
            // 
            detailsAuthor.AutoSize = true;
            detailsAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            detailsAuthor.Location = new System.Drawing.Point(22, 129);
            detailsAuthor.Name = "detailsAuthor";
            detailsAuthor.Size = new System.Drawing.Size(77, 28);
            detailsAuthor.TabIndex = 2;
            detailsAuthor.Text = "Author:";
            // 
            // titleDetailsLabel
            // 
            titleDetailsLabel.AutoSize = true;
            titleDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            titleDetailsLabel.Location = new System.Drawing.Point(37, 87);
            titleDetailsLabel.Name = "titleDetailsLabel";
            titleDetailsLabel.Size = new System.Drawing.Size(53, 28);
            titleDetailsLabel.TabIndex = 1;
            titleDetailsLabel.Text = "Title:";
            // 
            // DetailsLabel
            // 
            DetailsLabel.AutoSize = true;
            DetailsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DetailsLabel.Location = new System.Drawing.Point(9, 9);
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new System.Drawing.Size(152, 32);
            DetailsLabel.TabIndex = 0;
            DetailsLabel.Text = "Book Details:";
            // 
            // LibraryStageTitleLabel
            // 
            LibraryStageTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LibraryStageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            LibraryStageTitleLabel.Location = new System.Drawing.Point(102, 24);
            LibraryStageTitleLabel.Name = "LibraryStageTitleLabel";
            LibraryStageTitleLabel.Size = new System.Drawing.Size(483, 73);
            LibraryStageTitleLabel.TabIndex = 0;
            LibraryStageTitleLabel.Text = "Library:";
            LibraryStageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(ThemeComboBox);
            SettingsPanel.Controls.Add(SettingsPanelTitleLabel);
            SettingsPanel.Location = new System.Drawing.Point(145, 0);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new System.Drawing.Size(686, 783);
            SettingsPanel.TabIndex = 10;
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { "Light", "Dark" });
            ThemeComboBox.Location = new System.Drawing.Point(17, 187);
            ThemeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new System.Drawing.Size(302, 28);
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
            // viewLibrariesGroupBox
            // 
            viewLibrariesGroupBox.Location = new System.Drawing.Point(10, 10);
            viewLibrariesGroupBox.Name = "viewLibrariesGroupBox";
            viewLibrariesGroupBox.Size = new System.Drawing.Size(200, 200);
            viewLibrariesGroupBox.TabIndex = 0;
            viewLibrariesGroupBox.TabStop = false;
            viewLibrariesGroupBox.Text = "Library Actions";
            // 
            // MochaMemoirsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 783);
            Controls.Add(HomePanel);
            Controls.Add(SettingsPanel);
            Controls.Add(LibraryPanel);
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
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Label BookDetailsLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label detailsPublisherLabel;
        private System.Windows.Forms.Label detailsAuthor;
        private System.Windows.Forms.Label titleDetailsLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.Label bookIdLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.GroupBox viewLibrariesGroupBox;
    }
}
