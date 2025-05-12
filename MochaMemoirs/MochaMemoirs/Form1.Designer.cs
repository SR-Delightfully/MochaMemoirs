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
            RefreshButton = new System.Windows.Forms.Button();
            DeleteButton = new System.Windows.Forms.Button();
            EditButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            bookIdTextBox = new System.Windows.Forms.TextBox();
            ClearButton = new System.Windows.Forms.Button();
            bookIdLabel = new System.Windows.Forms.Label();
            publisherTextBox = new System.Windows.Forms.TextBox();
            authorTextBox = new System.Windows.Forms.TextBox();
            titleTextBox = new System.Windows.Forms.TextBox();
            detailsPublisherLabel = new System.Windows.Forms.Label();
            detailsAuthor = new System.Windows.Forms.Label();
            titleDetailsLabel = new System.Windows.Forms.Label();
            DetailsLabel = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            LibraryStageTitleLabel = new System.Windows.Forms.Label();
            SettingsPanel = new System.Windows.Forms.Panel();
            ThemeComboBox = new System.Windows.Forms.ComboBox();
            SettingsPanelTitleLabel = new System.Windows.Forms.Label();
            genreTextBox = new System.Windows.Forms.TextBox();
            genreLabel = new System.Windows.Forms.Label();
            HomePanel.SuspendLayout();
            FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).BeginInit();
            HeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            SideBarGroupBox.SuspendLayout();
            LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(ViewLibrariesPanel);
            HomePanel.Controls.Add(FeaturedBookGroupBox);
            HomePanel.Controls.Add(PersonalLibraryGroupBox);
            HomePanel.Controls.Add(HeaderGroupBox);
            HomePanel.Location = new System.Drawing.Point(127, 2);
            HomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new System.Drawing.Size(600, 590);
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
            FeaturedBookGroupBox.Location = new System.Drawing.Point(418, 305);
            FeaturedBookGroupBox.Margin = new System.Windows.Forms.Padding(2);
            FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            FeaturedBookGroupBox.Padding = new System.Windows.Forms.Padding(2);
            FeaturedBookGroupBox.Size = new System.Drawing.Size(177, 272);
            FeaturedBookGroupBox.TabIndex = 12;
            FeaturedBookGroupBox.TabStop = false;
            FeaturedBookGroupBox.Text = "FeaturedBooks";
            // 
            // FeaturedBookPictureBox
            // 
            FeaturedBookPictureBox.Location = new System.Drawing.Point(4, 20);
            FeaturedBookPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.Size = new System.Drawing.Size(168, 214);
            FeaturedBookPictureBox.TabIndex = 3;
            FeaturedBookPictureBox.TabStop = false;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new System.Drawing.Point(4, 238);
            PreviousButton.Margin = new System.Windows.Forms.Padding(2);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size(81, 30);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "&Prev";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new System.Drawing.Point(98, 237);
            NextButton.Margin = new System.Windows.Forms.Padding(2);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(74, 32);
            NextButton.TabIndex = 1;
            NextButton.Text = "&Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
<<<<<<< Updated upstream
=======
            // ViewLibrariesGroupBox
            // 
            ViewLibrariesGroupBox.Location = new System.Drawing.Point(2, 305);
            ViewLibrariesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            ViewLibrariesGroupBox.Name = "ViewLibrariesGroupBox";
            ViewLibrariesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            ViewLibrariesGroupBox.Size = new System.Drawing.Size(411, 272);
            ViewLibrariesGroupBox.TabIndex = 11;
            ViewLibrariesGroupBox.TabStop = false;
            ViewLibrariesGroupBox.Text = "ViewLibraries";
            // 
>>>>>>> Stashed changes
            // PersonalLibraryGroupBox
            // 
            PersonalLibraryGroupBox.Location = new System.Drawing.Point(2, 155);
            PersonalLibraryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            PersonalLibraryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            PersonalLibraryGroupBox.Size = new System.Drawing.Size(594, 146);
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
            HeaderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            HeaderGroupBox.Name = "HeaderGroupBox";
            HeaderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            HeaderGroupBox.Size = new System.Drawing.Size(594, 149);
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
            DateLabel.Location = new System.Drawing.Point(4, 122);
            DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(257, 23);
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
<<<<<<< Updated upstream
            TimeLabel.Location = new System.Drawing.Point(550, 162);
=======
            TimeLabel.Location = new System.Drawing.Point(481, 122);
>>>>>>> Stashed changes
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(108, 23);
            TimeLabel.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = System.Drawing.Color.Transparent;
            TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            TitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            TitleLabel.Image = (System.Drawing.Image)resources.GetObject("TitleLabel.Image");
            TitleLabel.Location = new System.Drawing.Point(0, 52);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(593, 40);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Mocha Memoirs";
            TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TitleLabel.UseCompatibleTextRendering = true;
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = (System.Drawing.Image)resources.GetObject("BannerPictureBox.Image");
            BannerPictureBox.Location = new System.Drawing.Point(0, -8);
            BannerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.Size = new System.Drawing.Size(593, 157);
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
            SideBarGroupBox.Location = new System.Drawing.Point(2, -4);
            SideBarGroupBox.Margin = new System.Windows.Forms.Padding(2);
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.Padding = new System.Windows.Forms.Padding(2);
            SideBarGroupBox.Size = new System.Drawing.Size(121, 591);
            SideBarGroupBox.TabIndex = 8;
            SideBarGroupBox.TabStop = false;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = System.Drawing.Color.PeachPuff;
            SettingsButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            SettingsButton.ForeColor = System.Drawing.Color.MidnightBlue;
            SettingsButton.Location = new System.Drawing.Point(28, 253);
            SettingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(63, 55);
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
            LibraryButton.Location = new System.Drawing.Point(28, 134);
            LibraryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LibraryButton.Name = "LibraryButton";
            LibraryButton.Size = new System.Drawing.Size(63, 55);
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
            HomeButton.Location = new System.Drawing.Point(28, 20);
            HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new System.Drawing.Size(63, 55);
            HomeButton.TabIndex = 2;
            HomeButton.Text = "🏠︎";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // LanguageBox
            // 
            LanguageBox.FormattingEnabled = true;
            LanguageBox.Items.AddRange(new object[] { "English", "French", "Spanish" });
            LanguageBox.Location = new System.Drawing.Point(17, 549);
            LanguageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LanguageBox.Name = "LanguageBox";
            LanguageBox.Size = new System.Drawing.Size(88, 23);
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
            LibraryPanel.Controls.Add(dataGridView1);
            LibraryPanel.Controls.Add(LibraryStageTitleLabel);
<<<<<<< Updated upstream
            LibraryPanel.Location = new System.Drawing.Point(145, 4);
            LibraryPanel.Name = "LibraryPanel";
            LibraryPanel.Size = new System.Drawing.Size(689, 786);
=======
            LibraryPanel.Location = new System.Drawing.Point(130, 3);
            LibraryPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LibraryPanel.Name = "LibraryPanel";
            LibraryPanel.Size = new System.Drawing.Size(600, 590);
>>>>>>> Stashed changes
            LibraryPanel.TabIndex = 9;
            // 
            // booksDataGridView
            // 
            booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGridView.Location = new System.Drawing.Point(89, 139);
            booksDataGridView.Name = "booksDataGridView";
            booksDataGridView.Size = new System.Drawing.Size(423, 200);
            booksDataGridView.TabIndex = 9;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new System.Drawing.Point(335, 192);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new System.Drawing.Size(75, 23);
            RefreshButton.TabIndex = 11;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += loadButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(409, 88);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(103, 38);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new System.Drawing.Point(250, 88);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(100, 38);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new System.Drawing.Point(90, 88);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(108, 38);
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
            panel1.Location = new System.Drawing.Point(90, 345);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(422, 220);
            panel1.TabIndex = 3;
            // 
            // bookIdTextBox
            // 
            bookIdTextBox.Location = new System.Drawing.Point(88, 36);
            bookIdTextBox.Name = "bookIdTextBox";
            bookIdTextBox.Size = new System.Drawing.Size(322, 23);
            bookIdTextBox.TabIndex = 13;
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(245, 192);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(75, 23);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            bookIdLabel.Location = new System.Drawing.Point(40, 36);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(28, 21);
            bookIdLabel.TabIndex = 12;
            bookIdLabel.Text = "ID:";
            // 
            // publisherTextBox
            // 
            publisherTextBox.Location = new System.Drawing.Point(88, 158);
            publisherTextBox.Name = "publisherTextBox";
            publisherTextBox.Size = new System.Drawing.Size(322, 23);
            publisherTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new System.Drawing.Point(88, 94);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new System.Drawing.Size(322, 23);
            authorTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new System.Drawing.Point(88, 65);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(322, 23);
            titleTextBox.TabIndex = 4;
            // 
            // detailsPublisherLabel
            // 
            detailsPublisherLabel.AutoSize = true;
            detailsPublisherLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            detailsPublisherLabel.Location = new System.Drawing.Point(8, 156);
            detailsPublisherLabel.Name = "detailsPublisherLabel";
            detailsPublisherLabel.Size = new System.Drawing.Size(78, 21);
            detailsPublisherLabel.TabIndex = 3;
            detailsPublisherLabel.Text = "Publisher:";
            // 
            // detailsAuthor
            // 
            detailsAuthor.AutoSize = true;
            detailsAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            detailsAuthor.Location = new System.Drawing.Point(19, 97);
            detailsAuthor.Name = "detailsAuthor";
            detailsAuthor.Size = new System.Drawing.Size(61, 21);
            detailsAuthor.TabIndex = 2;
            detailsAuthor.Text = "Author:";
            // 
            // titleDetailsLabel
            // 
            titleDetailsLabel.AutoSize = true;
            titleDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            titleDetailsLabel.Location = new System.Drawing.Point(32, 65);
            titleDetailsLabel.Name = "titleDetailsLabel";
            titleDetailsLabel.Size = new System.Drawing.Size(42, 21);
            titleDetailsLabel.TabIndex = 1;
            titleDetailsLabel.Text = "Title:";
            // 
            // DetailsLabel
            // 
            DetailsLabel.AutoSize = true;
            DetailsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DetailsLabel.Location = new System.Drawing.Point(8, 7);
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new System.Drawing.Size(120, 25);
            DetailsLabel.TabIndex = 0;
            DetailsLabel.Text = "Book Details:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(89, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(423, 200);
            dataGridView1.TabIndex = 2;
            // 
            // LibraryStageTitleLabel
            // 
            LibraryStageTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LibraryStageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            LibraryStageTitleLabel.Location = new System.Drawing.Point(89, 18);
            LibraryStageTitleLabel.Name = "LibraryStageTitleLabel";
            LibraryStageTitleLabel.Size = new System.Drawing.Size(423, 55);
            LibraryStageTitleLabel.TabIndex = 0;
            LibraryStageTitleLabel.Text = "Library:";
            LibraryStageTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(ThemeComboBox);
            SettingsPanel.Controls.Add(SettingsPanelTitleLabel);
<<<<<<< Updated upstream
            SettingsPanel.Location = new System.Drawing.Point(145, 5);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new System.Drawing.Size(686, 783);
=======
            SettingsPanel.Location = new System.Drawing.Point(130, 4);
            SettingsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new System.Drawing.Size(598, 587);
>>>>>>> Stashed changes
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
            SettingsPanelTitleLabel.Location = new System.Drawing.Point(13, 18);
            SettingsPanelTitleLabel.Name = "SettingsPanelTitleLabel";
            SettingsPanelTitleLabel.Size = new System.Drawing.Size(577, 55);
            SettingsPanelTitleLabel.TabIndex = 0;
            SettingsPanelTitleLabel.Text = "Settings:";
            SettingsPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new System.Drawing.Point(88, 127);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new System.Drawing.Size(322, 23);
            genreTextBox.TabIndex = 15;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            genreLabel.Location = new System.Drawing.Point(23, 125);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(55, 21);
            genreLabel.TabIndex = 14;
            genreLabel.Text = "Genre:";
            // 
            // MochaMemoirsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(728, 587);
            Controls.Add(LibraryPanel);
            Controls.Add(HomePanel);
            Controls.Add(SettingsPanel);
            Controls.Add(SideBarGroupBox);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
<<<<<<< Updated upstream
        private System.Windows.Forms.Panel ViewLibrariesPanel;
        private System.Windows.Forms.ComboBox ThemeComboBox;
=======
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
>>>>>>> Stashed changes
    }
}
