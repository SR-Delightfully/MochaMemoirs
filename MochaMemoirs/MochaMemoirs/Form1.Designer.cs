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
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeAndDateGroup = new System.Windows.Forms.GroupBox();
            this.SideBarGroupBox = new System.Windows.Forms.GroupBox();
            this.HeaderGroupBox = new System.Windows.Forms.GroupBox();
            this.PersonalLibraryGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewLibrariesGroupBox = new System.Windows.Forms.GroupBox();
            this.FeaturedBookGroupBox = new System.Windows.Forms.GroupBox();
            this.BannerPictureBox = new System.Windows.Forms.PictureBox();
            this.FeaturedBookPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.TimeAndDateGroup.SuspendLayout();
            this.HeaderGroupBox.SuspendLayout();
            this.FeaturedBookGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedBookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateLabel.Location = new System.Drawing.Point(17, 17);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(449, 40);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Location = new System.Drawing.Point(472, 17);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(227, 40);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // TimeAndDateGroup
            // 
            this.TimeAndDateGroup.Controls.Add(this.TimeLabel);
            this.TimeAndDateGroup.Controls.Add(this.DateLabel);
            this.TimeAndDateGroup.Location = new System.Drawing.Point(0, 139);
            this.TimeAndDateGroup.Name = "TimeAndDateGroup";
            this.TimeAndDateGroup.Size = new System.Drawing.Size(701, 60);
            this.TimeAndDateGroup.TabIndex = 2;
            this.TimeAndDateGroup.TabStop = false;
            this.TimeAndDateGroup.Text = "Date&Time";
            // 
            // SideBarGroupBox
            // 
            this.SideBarGroupBox.Location = new System.Drawing.Point(2, 3);
            this.SideBarGroupBox.Name = "SideBarGroupBox";
            this.SideBarGroupBox.Size = new System.Drawing.Size(158, 768);
            this.SideBarGroupBox.TabIndex = 3;
            this.SideBarGroupBox.TabStop = false;
            this.SideBarGroupBox.Text = "sidebar";
            // 
            // HeaderGroupBox
            // 
            this.HeaderGroupBox.Controls.Add(this.TimeAndDateGroup);
            this.HeaderGroupBox.Controls.Add(this.BannerPictureBox);
            this.HeaderGroupBox.Location = new System.Drawing.Point(160, 3);
            this.HeaderGroupBox.Name = "HeaderGroupBox";
            this.HeaderGroupBox.Size = new System.Drawing.Size(701, 199);
            this.HeaderGroupBox.TabIndex = 4;
            this.HeaderGroupBox.TabStop = false;
            this.HeaderGroupBox.Text = "Header";
            // 
            // PersonalLibraryGroupBox
            // 
            this.PersonalLibraryGroupBox.Location = new System.Drawing.Point(160, 203);
            this.PersonalLibraryGroupBox.Name = "PersonalLibraryGroupBox";
            this.PersonalLibraryGroupBox.Size = new System.Drawing.Size(701, 199);
            this.PersonalLibraryGroupBox.TabIndex = 5;
            this.PersonalLibraryGroupBox.TabStop = false;
            this.PersonalLibraryGroupBox.Text = "Personal Library";
            this.PersonalLibraryGroupBox.Enter += new System.EventHandler(this.PersonalLibraryGroupBox_Enter);
            // 
            // ViewLibrariesGroupBox
            // 
            this.ViewLibrariesGroupBox.Location = new System.Drawing.Point(160, 408);
            this.ViewLibrariesGroupBox.Name = "ViewLibrariesGroupBox";
            this.ViewLibrariesGroupBox.Size = new System.Drawing.Size(466, 363);
            this.ViewLibrariesGroupBox.TabIndex = 6;
            this.ViewLibrariesGroupBox.TabStop = false;
            this.ViewLibrariesGroupBox.Text = "ViewLibraries";
            // 
            // FeaturedBookGroupBox
            // 
            this.FeaturedBookGroupBox.Controls.Add(this.PreviousButton);
            this.FeaturedBookGroupBox.Controls.Add(this.NextButton);
            this.FeaturedBookGroupBox.Controls.Add(this.FeaturedBookPictureBox);
            this.FeaturedBookGroupBox.Location = new System.Drawing.Point(632, 408);
            this.FeaturedBookGroupBox.Name = "FeaturedBookGroupBox";
            this.FeaturedBookGroupBox.Size = new System.Drawing.Size(227, 363);
            this.FeaturedBookGroupBox.TabIndex = 7;
            this.FeaturedBookGroupBox.TabStop = false;
            this.FeaturedBookGroupBox.Text = "FeaturedBooks";
            // 
            // BannerPictureBox
            // 
            this.BannerPictureBox.Location = new System.Drawing.Point(0, 9);
            this.BannerPictureBox.Name = "BannerPictureBox";
            this.BannerPictureBox.Size = new System.Drawing.Size(701, 190);
            this.BannerPictureBox.TabIndex = 3;
            this.BannerPictureBox.TabStop = false;
            this.BannerPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FeaturedBookPictureBox
            // 
            this.FeaturedBookPictureBox.Location = new System.Drawing.Point(6, 27);
            this.FeaturedBookPictureBox.Name = "FeaturedBookPictureBox";
            this.FeaturedBookPictureBox.Size = new System.Drawing.Size(215, 274);
            this.FeaturedBookPictureBox.TabIndex = 0;
            this.FeaturedBookPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(123, 316);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 34);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(6, 316);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(100, 34);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "&Prev";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // MochaMemoirsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 783);
            this.Controls.Add(this.FeaturedBookGroupBox);
            this.Controls.Add(this.ViewLibrariesGroupBox);
            this.Controls.Add(this.PersonalLibraryGroupBox);
            this.Controls.Add(this.HeaderGroupBox);
            this.Controls.Add(this.SideBarGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MochaMemoirsForm";
            this.Text = "Mocha Memoirs";
            this.TimeAndDateGroup.ResumeLayout(false);
            this.HeaderGroupBox.ResumeLayout(false);
            this.FeaturedBookGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BannerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturedBookPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox TimeAndDateGroup;
        private System.Windows.Forms.GroupBox SideBarGroupBox;
        private System.Windows.Forms.GroupBox HeaderGroupBox;
        private System.Windows.Forms.GroupBox PersonalLibraryGroupBox;
        private System.Windows.Forms.GroupBox ViewLibrariesGroupBox;
        private System.Windows.Forms.GroupBox FeaturedBookGroupBox;
        private System.Windows.Forms.PictureBox BannerPictureBox;
        private System.Windows.Forms.PictureBox FeaturedBookPictureBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
    }
}

