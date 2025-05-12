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
            SideBarGroupBox = new System.Windows.Forms.GroupBox();
            HeaderGroupBox = new System.Windows.Forms.GroupBox();
            TimeLabel = new System.Windows.Forms.Label();
            DateLabel = new System.Windows.Forms.Label();
            BannerPictureBox = new System.Windows.Forms.PictureBox();
            PersonalLibraryGroupBox = new System.Windows.Forms.GroupBox();
            ViewLibrariesGroupBox = new System.Windows.Forms.GroupBox();
            FeaturedBookGroupBox = new System.Windows.Forms.GroupBox();
            PreviousButton = new System.Windows.Forms.Button();
            NextButton = new System.Windows.Forms.Button();
            FeaturedBookPictureBox = new System.Windows.Forms.PictureBox();
            HeaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).BeginInit();
            FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SideBarGroupBox
            // 
            SideBarGroupBox.Location = new System.Drawing.Point(2, 2);
            SideBarGroupBox.Margin = new System.Windows.Forms.Padding(2);
            SideBarGroupBox.Name = "SideBarGroupBox";
            SideBarGroupBox.Padding = new System.Windows.Forms.Padding(2);
            SideBarGroupBox.Size = new System.Drawing.Size(123, 576);
            SideBarGroupBox.TabIndex = 3;
            SideBarGroupBox.TabStop = false;
            SideBarGroupBox.Text = "sidebar";
            // 
            // HeaderGroupBox
            // 
            HeaderGroupBox.Controls.Add(TimeLabel);
            HeaderGroupBox.Controls.Add(DateLabel);
            HeaderGroupBox.Controls.Add(BannerPictureBox);
            HeaderGroupBox.Location = new System.Drawing.Point(124, 2);
            HeaderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            HeaderGroupBox.Name = "HeaderGroupBox";
            HeaderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            HeaderGroupBox.Size = new System.Drawing.Size(545, 149);
            HeaderGroupBox.TabIndex = 4;
            HeaderGroupBox.TabStop = false;
            HeaderGroupBox.Text = "Header";
            // 
            // TimeLabel
            // 
            TimeLabel.BackColor = System.Drawing.Color.Transparent;
            TimeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            TimeLabel.Location = new System.Drawing.Point(373, 107);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(159, 29);
            TimeLabel.TabIndex = 5;
            // 
            // DateLabel
            // 
            DateLabel.BackColor = System.Drawing.Color.Transparent;
            DateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            DateLabel.Location = new System.Drawing.Point(6, 107);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new System.Drawing.Size(277, 29);
            DateLabel.TabIndex = 4;
            // 
            // BannerPictureBox
            // 
            BannerPictureBox.Image = (System.Drawing.Image)resources.GetObject("BannerPictureBox.Image");
            BannerPictureBox.Location = new System.Drawing.Point(0, 7);
            BannerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            BannerPictureBox.Name = "BannerPictureBox";
            BannerPictureBox.Size = new System.Drawing.Size(545, 142);
            BannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            BannerPictureBox.TabIndex = 3;
            BannerPictureBox.TabStop = false;
            // 
            // PersonalLibraryGroupBox
            // 
            PersonalLibraryGroupBox.Location = new System.Drawing.Point(124, 152);
            PersonalLibraryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            PersonalLibraryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            PersonalLibraryGroupBox.Size = new System.Drawing.Size(545, 149);
            PersonalLibraryGroupBox.TabIndex = 5;
            PersonalLibraryGroupBox.TabStop = false;
            PersonalLibraryGroupBox.Text = "Personal Library";
            // 
            // ViewLibrariesGroupBox
            // 
            ViewLibrariesGroupBox.Location = new System.Drawing.Point(124, 306);
            ViewLibrariesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            ViewLibrariesGroupBox.Name = "ViewLibrariesGroupBox";
            ViewLibrariesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            ViewLibrariesGroupBox.Size = new System.Drawing.Size(362, 272);
            ViewLibrariesGroupBox.TabIndex = 6;
            ViewLibrariesGroupBox.TabStop = false;
            ViewLibrariesGroupBox.Text = "ViewLibraries";
            // 
            // FeaturedBookGroupBox
            // 
            FeaturedBookGroupBox.Controls.Add(PreviousButton);
            FeaturedBookGroupBox.Controls.Add(NextButton);
            FeaturedBookGroupBox.Controls.Add(FeaturedBookPictureBox);
            FeaturedBookGroupBox.Location = new System.Drawing.Point(492, 306);
            FeaturedBookGroupBox.Margin = new System.Windows.Forms.Padding(2);
            FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            FeaturedBookGroupBox.Padding = new System.Windows.Forms.Padding(2);
            FeaturedBookGroupBox.Size = new System.Drawing.Size(177, 272);
            FeaturedBookGroupBox.TabIndex = 7;
            FeaturedBookGroupBox.TabStop = false;
            FeaturedBookGroupBox.Text = "FeaturedBooks";
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new System.Drawing.Point(5, 237);
            PreviousButton.Margin = new System.Windows.Forms.Padding(2);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new System.Drawing.Size(78, 26);
            PreviousButton.TabIndex = 2;
            PreviousButton.Text = "&Prev";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new System.Drawing.Point(96, 237);
            NextButton.Margin = new System.Windows.Forms.Padding(2);
            NextButton.Name = "NextButton";
            NextButton.Size = new System.Drawing.Size(78, 26);
            NextButton.TabIndex = 1;
            NextButton.Text = "&Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // FeaturedBookPictureBox
            // 
            FeaturedBookPictureBox.Location = new System.Drawing.Point(5, 20);
            FeaturedBookPictureBox.Margin = new System.Windows.Forms.Padding(2);
            FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            FeaturedBookPictureBox.Size = new System.Drawing.Size(167, 206);
            FeaturedBookPictureBox.TabIndex = 0;
            FeaturedBookPictureBox.TabStop = false;
            // 
            // MochaMemoirsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(674, 587);
            Controls.Add(FeaturedBookGroupBox);
            Controls.Add(ViewLibrariesGroupBox);
            Controls.Add(PersonalLibraryGroupBox);
            Controls.Add(HeaderGroupBox);
            Controls.Add(SideBarGroupBox);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "MochaMemoirsForm";
            Text = "Mocha Memoirs";
            Load += MochaMemoirsForm_Load;
            HeaderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BannerPictureBox).EndInit();
            FeaturedBookGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FeaturedBookPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.GroupBox HeaderGroupBox;
        private System.Windows.Forms.GroupBox PersonalLibraryGroupBox;
        private System.Windows.Forms.GroupBox ViewLibrariesGroupBox;
        private System.Windows.Forms.GroupBox FeaturedBookGroupBox;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.PictureBox FeaturedBookPictureBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}

