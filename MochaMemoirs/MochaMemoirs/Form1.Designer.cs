using System.Drawing;

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
        private void InitializeComponent() {
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
            exitButton = new System.Windows.Forms.Button();
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            StartupGroupBox = new System.Windows.Forms.GroupBox();
            DefaultPanelLabel = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            MinimizedCheckBox = new System.Windows.Forms.CheckBox();
            ClockAndDateSettingsGroupBox = new System.Windows.Forms.GroupBox();
            HideTimeCheckBox = new System.Windows.Forms.CheckBox();
            HideDateCheckBox = new System.Windows.Forms.CheckBox();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            AppearanceGroupBox = new System.Windows.Forms.GroupBox();
            ItalicCheckBox = new System.Windows.Forms.CheckBox();
            BoldCheckBox = new System.Windows.Forms.CheckBox();
            ThemeModeLabel = new System.Windows.Forms.Label();
            ThemeComboBox = new System.Windows.Forms.ComboBox();
            FontFamilyLabel = new System.Windows.Forms.Label();
            FontFamilyComboBox = new System.Windows.Forms.ComboBox();
            SettingsPanelTitleLabel = new System.Windows.Forms.Label();
            viewLibrariesGroupBox = new System.Windows.Forms.GroupBox();
            loginPanel = new System.Windows.Forms.Panel();
            passwordLabel = new System.Windows.Forms.Label();
            caPasswordInput = new System.Windows.Forms.TextBox();
            cdEmailInput = new System.Windows.Forms.TextBox();
            createAccountButton = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            CreateAccTitleLabel = new System.Windows.Forms.Label();
            backToLoginBtn = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            toCreateAccountBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            passwordInput = new System.Windows.Forms.TextBox();
            usernameInput = new System.Windows.Forms.TextBox();
            loginBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            cdNameInput = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            StartupGroupBox.SuspendLayout();
            ClockAndDateSettingsGroupBox.SuspendLayout();
            AppearanceGroupBox.SuspendLayout();
            loginPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // HomePanel
            // 
            HomePanel.Controls.Add(ViewLibrariesPanel);
            HomePanel.Controls.Add(FeaturedBookGroupBox);
            HomePanel.Controls.Add(PersonalLibraryGroupBox);
            HomePanel.Controls.Add(HeaderGroupBox);
            resources.ApplyResources(HomePanel, "HomePanel");
            HomePanel.Name = "HomePanel";
            // 
            // ViewLibrariesPanel
            // 
            resources.ApplyResources(ViewLibrariesPanel, "ViewLibrariesPanel");
            ViewLibrariesPanel.Name = "ViewLibrariesPanel";
            // 
            // FeaturedBookGroupBox
            // 
            FeaturedBookGroupBox.Controls.Add(FeaturedBookPictureBox);
            FeaturedBookGroupBox.Controls.Add(PreviousButton);
            FeaturedBookGroupBox.Controls.Add(NextButton);
            resources.ApplyResources(FeaturedBookGroupBox, "FeaturedBookGroupBox");
            FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            FeaturedBookGroupBox.TabStop = false;
            // 
            // FeaturedBookPictureBox
            // 
            resources.ApplyResources(FeaturedBookPictureBox, "FeaturedBookPictureBox");
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.TabStop = false;
            // 
            // PreviousButton
            // 
            resources.ApplyResources(PreviousButton, "PreviousButton");
            PreviousButton.Name = "PreviousButton";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            resources.ApplyResources(NextButton, "NextButton");
            NextButton.Name = "NextButton";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // PersonalLibraryGroupBox
            // 
            resources.ApplyResources(PersonalLibraryGroupBox, "PersonalLibraryGroupBox");
            PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            PersonalLibraryGroupBox.TabStop = false;
            // 
            // HeaderGroupBox
            // 
            HeaderGroupBox.BackColor = Color.Transparent;
            HeaderGroupBox.Controls.Add(DateLabel);
            HeaderGroupBox.Controls.Add(TimeLabel);
            HeaderGroupBox.Controls.Add(TitleLabel);
            HeaderGroupBox.Controls.Add(BannerPictureBox);
            resources.ApplyResources(HeaderGroupBox, "HeaderGroupBox");
            HeaderGroupBox.Name = "HeaderGroupBox";
            HeaderGroupBox.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.BackColor = Color.FromArgb(0, 0, 64);
            DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(DateLabel, "DateLabel");
            DateLabel.ForeColor = SystemColors.HighlightText;
            DateLabel.Name = "DateLabel";
            // 
            // TimeLabel
            // 
            TimeLabel.BackColor = Color.FromArgb(0, 0, 64);
            TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(TimeLabel, "TimeLabel");
            TimeLabel.ForeColor = SystemColors.HighlightText;
            TimeLabel.Name = "TimeLabel";
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(TitleLabel, "TitleLabel");
            TitleLabel.ForeColor = SystemColors.HighlightText;
            TitleLabel.Name = "TitleLabel";
            TitleLabel.UseCompatibleTextRendering = true;
            // 
            // BannerPictureBox
            // 
            resources.ApplyResources(BannerPictureBox, "BannerPictureBox");
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.TabStop = false;
            // 
            // SideBarGroupBox
            // 
            SideBarGroupBox.Controls.Add(exitButton);
            SideBarGroupBox.Controls.Add(SettingsButton);
            SideBarGroupBox.Controls.Add(LibraryButton);
            SideBarGroupBox.Controls.Add(HomeButton);
            SideBarGroupBox.Controls.Add(LanguageBox);
            resources.ApplyResources(SideBarGroupBox, "SideBarGroupBox");
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.PeachPuff;
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.ForeColor = Color.MidnightBlue;
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.PeachPuff;
            resources.ApplyResources(SettingsButton, "SettingsButton");
            SettingsButton.ForeColor = Color.MidnightBlue;
            SettingsButton.Name = "SettingsButton";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // LibraryButton
            // 
            LibraryButton.BackColor = Color.PeachPuff;
            resources.ApplyResources(LibraryButton, "LibraryButton");
            LibraryButton.ForeColor = Color.MidnightBlue;
            LibraryButton.Name = "LibraryButton";
            LibraryButton.UseVisualStyleBackColor = false;
            LibraryButton.Click += LibraryButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.PeachPuff;
            resources.ApplyResources(HomeButton, "HomeButton");
            HomeButton.ForeColor = Color.MidnightBlue;
            HomeButton.Name = "HomeButton";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // LanguageBox
            // 
            LanguageBox.FormattingEnabled = true;
            LanguageBox.Items.AddRange(new object[] { resources.GetString("LanguageBox.Items"), resources.GetString("LanguageBox.Items1"), resources.GetString("LanguageBox.Items2") });
            resources.ApplyResources(LanguageBox, "LanguageBox");
            LanguageBox.Name = "LanguageBox";
            LanguageBox.SelectedIndexChanged += LanguageBox_SelectedIndexChanged;
            // 
            // LibraryPanel
            // 
            LibraryPanel.Controls.Add(booksDataGridView);
            LibraryPanel.Controls.Add(DeleteButton);
            LibraryPanel.Controls.Add(EditButton);
            LibraryPanel.Controls.Add(AddButton);
            LibraryPanel.Controls.Add(panel1);
            LibraryPanel.Controls.Add(LibraryStageTitleLabel);
            resources.ApplyResources(LibraryPanel, "LibraryPanel");
            LibraryPanel.Name = "LibraryPanel";
            // 
            // booksDataGridView
            // 
            booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(booksDataGridView, "booksDataGridView");
            booksDataGridView.Name = "booksDataGridView";
            // 
            // DeleteButton
            // 
            resources.ApplyResources(DeleteButton, "DeleteButton");
            DeleteButton.Name = "DeleteButton";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            resources.ApplyResources(EditButton, "EditButton");
            EditButton.Name = "EditButton";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            resources.ApplyResources(AddButton, "AddButton");
            AddButton.Name = "AddButton";
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
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // genreTextBox
            // 
            resources.ApplyResources(genreTextBox, "genreTextBox");
            genreTextBox.Name = "genreTextBox";
            // 
            // genreLabel
            // 
            resources.ApplyResources(genreLabel, "genreLabel");
            genreLabel.Name = "genreLabel";
            // 
            // bookIdTextBox
            // 
            resources.ApplyResources(bookIdTextBox, "bookIdTextBox");
            bookIdTextBox.Name = "bookIdTextBox";
            // 
            // RefreshButton
            // 
            resources.ApplyResources(RefreshButton, "RefreshButton");
            RefreshButton.Name = "RefreshButton";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += loadButton_Click;
            // 
            // ClearButton
            // 
            resources.ApplyResources(ClearButton, "ClearButton");
            ClearButton.Name = "ClearButton";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // bookIdLabel
            // 
            resources.ApplyResources(bookIdLabel, "bookIdLabel");
            bookIdLabel.Name = "bookIdLabel";
            // 
            // publisherTextBox
            // 
            resources.ApplyResources(publisherTextBox, "publisherTextBox");
            publisherTextBox.Name = "publisherTextBox";
            // 
            // authorTextBox
            // 
            resources.ApplyResources(authorTextBox, "authorTextBox");
            authorTextBox.Name = "authorTextBox";
            // 
            // titleTextBox
            // 
            resources.ApplyResources(titleTextBox, "titleTextBox");
            titleTextBox.Name = "titleTextBox";
            // 
            // detailsPublisherLabel
            // 
            resources.ApplyResources(detailsPublisherLabel, "detailsPublisherLabel");
            detailsPublisherLabel.Name = "detailsPublisherLabel";
            // 
            // detailsAuthor
            // 
            resources.ApplyResources(detailsAuthor, "detailsAuthor");
            detailsAuthor.Name = "detailsAuthor";
            // 
            // titleDetailsLabel
            // 
            resources.ApplyResources(titleDetailsLabel, "titleDetailsLabel");
            titleDetailsLabel.Name = "titleDetailsLabel";
            // 
            // DetailsLabel
            // 
            resources.ApplyResources(DetailsLabel, "DetailsLabel");
            DetailsLabel.Name = "DetailsLabel";
            // 
            // LibraryStageTitleLabel
            // 
            LibraryStageTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(LibraryStageTitleLabel, "LibraryStageTitleLabel");
            LibraryStageTitleLabel.Name = "LibraryStageTitleLabel";
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(pictureBox1);
            SettingsPanel.Controls.Add(groupBox1);
            SettingsPanel.Controls.Add(StartupGroupBox);
            SettingsPanel.Controls.Add(ClockAndDateSettingsGroupBox);
            SettingsPanel.Controls.Add(AppearanceGroupBox);
            SettingsPanel.Controls.Add(SettingsPanelTitleLabel);
            resources.ApplyResources(SettingsPanel, "SettingsPanel");
            SettingsPanel.Name = "SettingsPanel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // StartupGroupBox
            // 
            StartupGroupBox.Controls.Add(DefaultPanelLabel);
            StartupGroupBox.Controls.Add(comboBox1);
            StartupGroupBox.Controls.Add(MinimizedCheckBox);
            resources.ApplyResources(StartupGroupBox, "StartupGroupBox");
            StartupGroupBox.Name = "StartupGroupBox";
            StartupGroupBox.TabStop = false;
            // 
            // DefaultPanelLabel
            // 
            resources.ApplyResources(DefaultPanelLabel, "DefaultPanelLabel");
            DefaultPanelLabel.Name = "DefaultPanelLabel";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // MinimizedCheckBox
            // 
            resources.ApplyResources(MinimizedCheckBox, "MinimizedCheckBox");
            MinimizedCheckBox.Name = "MinimizedCheckBox";
            MinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClockAndDateSettingsGroupBox
            // 
            ClockAndDateSettingsGroupBox.Controls.Add(HideTimeCheckBox);
            ClockAndDateSettingsGroupBox.Controls.Add(HideDateCheckBox);
            ClockAndDateSettingsGroupBox.Controls.Add(radioButton2);
            ClockAndDateSettingsGroupBox.Controls.Add(radioButton1);
            resources.ApplyResources(ClockAndDateSettingsGroupBox, "ClockAndDateSettingsGroupBox");
            ClockAndDateSettingsGroupBox.Name = "ClockAndDateSettingsGroupBox";
            ClockAndDateSettingsGroupBox.TabStop = false;
            // 
            // HideTimeCheckBox
            // 
            resources.ApplyResources(HideTimeCheckBox, "HideTimeCheckBox");
            HideTimeCheckBox.Name = "HideTimeCheckBox";
            HideTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // HideDateCheckBox
            // 
            resources.ApplyResources(HideDateCheckBox, "HideDateCheckBox");
            HideDateCheckBox.Name = "HideDateCheckBox";
            HideDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // AppearanceGroupBox
            // 
            AppearanceGroupBox.Controls.Add(ItalicCheckBox);
            AppearanceGroupBox.Controls.Add(BoldCheckBox);
            AppearanceGroupBox.Controls.Add(ThemeModeLabel);
            AppearanceGroupBox.Controls.Add(ThemeComboBox);
            AppearanceGroupBox.Controls.Add(FontFamilyLabel);
            AppearanceGroupBox.Controls.Add(FontFamilyComboBox);
            resources.ApplyResources(AppearanceGroupBox, "AppearanceGroupBox");
            AppearanceGroupBox.Name = "AppearanceGroupBox";
            AppearanceGroupBox.TabStop = false;
            // 
            // ItalicCheckBox
            // 
            resources.ApplyResources(ItalicCheckBox, "ItalicCheckBox");
            ItalicCheckBox.Name = "ItalicCheckBox";
            // 
            // BoldCheckBox
            // 
            resources.ApplyResources(BoldCheckBox, "BoldCheckBox");
            BoldCheckBox.Name = "BoldCheckBox";
            // 
            // ThemeModeLabel
            // 
            resources.ApplyResources(ThemeModeLabel, "ThemeModeLabel");
            ThemeModeLabel.Name = "ThemeModeLabel";
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { resources.GetString("ThemeComboBox.Items"), resources.GetString("ThemeComboBox.Items1"), resources.GetString("ThemeComboBox.Items2"), resources.GetString("ThemeComboBox.Items3"), resources.GetString("ThemeComboBox.Items4") });
            resources.ApplyResources(ThemeComboBox, "ThemeComboBox");
            ThemeComboBox.Name = "ThemeComboBox";
            // 
            // FontFamilyLabel
            // 
            resources.ApplyResources(FontFamilyLabel, "FontFamilyLabel");
            FontFamilyLabel.Name = "FontFamilyLabel";
            // 
            // FontFamilyComboBox
            // 
            FontFamilyComboBox.FormattingEnabled = true;
            FontFamilyComboBox.Items.AddRange(new object[] { resources.GetString("FontFamilyComboBox.Items"), resources.GetString("FontFamilyComboBox.Items1"), resources.GetString("FontFamilyComboBox.Items2"), resources.GetString("FontFamilyComboBox.Items3"), resources.GetString("FontFamilyComboBox.Items4"), resources.GetString("FontFamilyComboBox.Items5"), resources.GetString("FontFamilyComboBox.Items6"), resources.GetString("FontFamilyComboBox.Items7"), resources.GetString("FontFamilyComboBox.Items8"), resources.GetString("FontFamilyComboBox.Items9") });
            resources.ApplyResources(FontFamilyComboBox, "FontFamilyComboBox");
            FontFamilyComboBox.Name = "FontFamilyComboBox";
            // 
            // SettingsPanelTitleLabel
            // 
            SettingsPanelTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(SettingsPanelTitleLabel, "SettingsPanelTitleLabel");
            SettingsPanelTitleLabel.Name = "SettingsPanelTitleLabel";
            // 
            // viewLibrariesGroupBox
            // 
            resources.ApplyResources(viewLibrariesGroupBox, "viewLibrariesGroupBox");
            viewLibrariesGroupBox.Name = "viewLibrariesGroupBox";
            viewLibrariesGroupBox.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(cdNameInput);
            loginPanel.Controls.Add(nameLabel);
            loginPanel.Controls.Add(backToLoginBtn);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(caPasswordInput);
            loginPanel.Controls.Add(cdEmailInput);
            loginPanel.Controls.Add(createAccountButton);
            loginPanel.Controls.Add(emailLabel);
            loginPanel.Controls.Add(CreateAccTitleLabel);
            resources.ApplyResources(loginPanel, "loginPanel");
            loginPanel.Name = "loginPanel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // caPasswordInput
            // 
            resources.ApplyResources(caPasswordInput, "caPasswordInput");
            caPasswordInput.Name = "caPasswordInput";
            // 
            // cdEmailInput
            // 
            resources.ApplyResources(cdEmailInput, "cdEmailInput");
            cdEmailInput.Name = "cdEmailInput";
            // 
            // createAccountButton
            // 
            resources.ApplyResources(createAccountButton, "createAccountButton");
            createAccountButton.Name = "createAccountButton";
            createAccountButton.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Name = "emailLabel";
            // 
            // CreateAccTitleLabel
            // 
            resources.ApplyResources(CreateAccTitleLabel, "CreateAccTitleLabel");
            CreateAccTitleLabel.Name = "CreateAccTitleLabel";
            // 
            // backToLoginBtn
            // 
            resources.ApplyResources(backToLoginBtn, "backToLoginBtn");
            backToLoginBtn.Name = "backToLoginBtn";
            backToLoginBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(toCreateAccountBtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(usernameInput);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // toCreateAccountBtn
            // 
            resources.ApplyResources(toCreateAccountBtn, "toCreateAccountBtn");
            toCreateAccountBtn.Name                    =  "toCreateAccountBtn";
            toCreateAccountBtn.UseVisualStyleBackColor =  true;
            toCreateAccountBtn.Click                   += toCreateAccountBtn_onClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // passwordInput
            // 
            resources.ApplyResources(passwordInput, "passwordInput");
            passwordInput.Name = "passwordInput";
            // 
            // usernameInput
            // 
            resources.ApplyResources(usernameInput, "usernameInput");
            usernameInput.Name = "usernameInput";
            // 
            // loginBtn
            // 
            resources.ApplyResources(loginBtn, "loginBtn");
            loginBtn.Name                    =  "loginBtn";
            loginBtn.UseVisualStyleBackColor =  true;
            loginBtn.Click                   += loginBtn_onClick;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // cdNameInput
            // 
            resources.ApplyResources(cdNameInput, "cdNameInput");
            cdNameInput.Name = "cdNameInput";
            // 
            // MochaMemoirsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(loginPanel);
            Controls.Add(HomePanel);
            Controls.Add(LibraryPanel);
            Controls.Add(SettingsPanel);
            Controls.Add(SideBarGroupBox);
            Name = "MochaMemoirsForm";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            StartupGroupBox.ResumeLayout(false);
            StartupGroupBox.PerformLayout();
            ClockAndDateSettingsGroupBox.ResumeLayout(false);
            ClockAndDateSettingsGroupBox.PerformLayout();
            AppearanceGroupBox.ResumeLayout(false);
            AppearanceGroupBox.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel        HomePanel;
        private System.Windows.Forms.GroupBox     FeaturedBookGroupBox;
        private System.Windows.Forms.Button       PreviousButton;
        private System.Windows.Forms.Button       NextButton;
        private System.Windows.Forms.PictureBox   FeaturedBookPictureBox;
        private System.Windows.Forms.GroupBox     PersonalLibraryGroupBox;
        private System.Windows.Forms.GroupBox     HeaderGroupBox;
        private System.Windows.Forms.Label        DateLabel;
        private System.Windows.Forms.Label        TimeLabel;
        private System.Windows.Forms.Label        TitleLabel;
        private System.Windows.Forms.PictureBox   BannerPictureBox;
        private System.Windows.Forms.GroupBox     SideBarGroupBox;
        private System.Windows.Forms.Button       SettingsButton;
        private System.Windows.Forms.Button       LibraryButton;
        private System.Windows.Forms.Button       HomeButton;
        private System.Windows.Forms.ComboBox     LanguageBox;
        private System.Windows.Forms.Panel        LibraryPanel;
        private System.Windows.Forms.Panel        SettingsPanel;
        private System.Windows.Forms.Label        SettingsPanelTitleLabel;
        private System.Windows.Forms.Label        LibraryStageTitleLabel;
        private System.Windows.Forms.Panel        ViewLibrariesPanel;
        private System.Windows.Forms.ComboBox     ThemeComboBox;
        private System.Windows.Forms.Panel        panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button       ClearButton;
        private System.Windows.Forms.Button       DeleteButton;
        private System.Windows.Forms.Button       EditButton;
        private System.Windows.Forms.Button       AddButton;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.Label        BookDetailsLabel;
        private System.Windows.Forms.TextBox      publisherTextBox;
        private System.Windows.Forms.TextBox      authorTextBox;
        private System.Windows.Forms.TextBox      titleTextBox;
        private System.Windows.Forms.Label        detailsPublisherLabel;
        private System.Windows.Forms.Label        detailsAuthor;
        private System.Windows.Forms.Label        titleDetailsLabel;
        private System.Windows.Forms.Label        DetailsLabel;
        private System.Windows.Forms.Button       RefreshButton;
        private System.Windows.Forms.TextBox      bookIdTextBox;
        private System.Windows.Forms.Label        bookIdLabel;
        private System.Windows.Forms.TextBox      genreTextBox;
        private System.Windows.Forms.Label        genreLabel;
        private System.Windows.Forms.GroupBox     viewLibrariesGroupBox;
        private System.Windows.Forms.Label        ThemeModeLabel;
        private System.Windows.Forms.ComboBox     FontFamilyComboBox;
        private System.Windows.Forms.Label        FontFamilyLabel;
        private System.Windows.Forms.GroupBox     ClockAndDateSettingsGroupBox;
        private System.Windows.Forms.GroupBox     StartupGroupBox;
        private System.Windows.Forms.GroupBox     AppearanceGroupBox;
        private System.Windows.Forms.CheckBox     ItalicCheckBox;
        private System.Windows.Forms.CheckBox     BoldCheckBox;
        private System.Windows.Forms.CheckBox     MinimizedCheckBox;
        private System.Windows.Forms.Label        DefaultPanelLabel;
        private System.Windows.Forms.ComboBox     comboBox1;
        private System.Windows.Forms.RadioButton  radioButton2;
        private System.Windows.Forms.RadioButton  radioButton1;
        private System.Windows.Forms.CheckBox     HideTimeCheckBox;
        private System.Windows.Forms.CheckBox     HideDateCheckBox;
        private System.Windows.Forms.PictureBox   pictureBox1;
        private System.Windows.Forms.GroupBox     groupBox1;
        private System.Windows.Forms.Button       exitButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label CreateAccTitleLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox caPasswordInput;
        private System.Windows.Forms.TextBox cdEmailInput;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button toCreateAccountBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cdNameInput;
        private System.Windows.Forms.Label nameLabel;
    }
}
