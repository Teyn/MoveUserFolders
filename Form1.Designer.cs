using System;

namespace MoveDefaultUserFolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.Objects_Button = new System.Windows.Forms.Button();
            this.Contacts_Button = new System.Windows.Forms.Button();
            this.SavedGames_Button = new System.Windows.Forms.Button();
            this.Searches_Button = new System.Windows.Forms.Button();
            this.Favorites_Button = new System.Windows.Forms.Button();
            this.Links_Button = new System.Windows.Forms.Button();
            this.Music_Button = new System.Windows.Forms.Button();
            this.Videos_Button = new System.Windows.Forms.Button();
            this.Pictures_Button = new System.Windows.Forms.Button();
            this.Documents_Button = new System.Windows.Forms.Button();
            this.Downloads_Button = new System.Windows.Forms.Button();
            this.Desktop_Button = new System.Windows.Forms.Button();
            this.Objects_TextBox = new System.Windows.Forms.TextBox();
            this.Contacts_TextBox = new System.Windows.Forms.TextBox();
            this.SavedGames_TextBox = new System.Windows.Forms.TextBox();
            this.Searches_TextBox = new System.Windows.Forms.TextBox();
            this.Favorites_TextBox = new System.Windows.Forms.TextBox();
            this.Links_TextBox = new System.Windows.Forms.TextBox();
            this.Music_TextBox = new System.Windows.Forms.TextBox();
            this.Videos_TextBox = new System.Windows.Forms.TextBox();
            this.Pictures_TextBox = new System.Windows.Forms.TextBox();
            this.Documents_TextBox = new System.Windows.Forms.TextBox();
            this.Downloads_TextBox = new System.Windows.Forms.TextBox();
            this.Desktop_TextBox = new System.Windows.Forms.TextBox();
            this.Objects = new System.Windows.Forms.CheckBox();
            this.Contacts = new System.Windows.Forms.CheckBox();
            this.SavedGames = new System.Windows.Forms.CheckBox();
            this.Searches = new System.Windows.Forms.CheckBox();
            this.Favorites = new System.Windows.Forms.CheckBox();
            this.Links = new System.Windows.Forms.CheckBox();
            this.Music = new System.Windows.Forms.CheckBox();
            this.Videos = new System.Windows.Forms.CheckBox();
            this.Pictures = new System.Windows.Forms.CheckBox();
            this.Documents = new System.Windows.Forms.CheckBox();
            this.Downloads = new System.Windows.Forms.CheckBox();
            this.Desktop = new System.Windows.Forms.CheckBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LocationBrowseButton = new System.Windows.Forms.Button();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(12, 9);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(228, 16);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Move selection to the same location?";
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Checked = true;
            this.YesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRadioButton.Location = new System.Drawing.Point(246, 7);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(50, 20);
            this.YesRadioButton.TabIndex = 1;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            this.YesRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_Click);
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRadioButton.Location = new System.Drawing.Point(302, 7);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(44, 20);
            this.NoRadioButton.TabIndex = 2;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            this.NoRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.selectAllCheckBox);
            this.GroupBox.Controls.Add(this.Objects_Button);
            this.GroupBox.Controls.Add(this.Contacts_Button);
            this.GroupBox.Controls.Add(this.SavedGames_Button);
            this.GroupBox.Controls.Add(this.Searches_Button);
            this.GroupBox.Controls.Add(this.Favorites_Button);
            this.GroupBox.Controls.Add(this.Links_Button);
            this.GroupBox.Controls.Add(this.Music_Button);
            this.GroupBox.Controls.Add(this.Videos_Button);
            this.GroupBox.Controls.Add(this.Pictures_Button);
            this.GroupBox.Controls.Add(this.Documents_Button);
            this.GroupBox.Controls.Add(this.Downloads_Button);
            this.GroupBox.Controls.Add(this.Desktop_Button);
            this.GroupBox.Controls.Add(this.Objects_TextBox);
            this.GroupBox.Controls.Add(this.Contacts_TextBox);
            this.GroupBox.Controls.Add(this.SavedGames_TextBox);
            this.GroupBox.Controls.Add(this.Searches_TextBox);
            this.GroupBox.Controls.Add(this.Favorites_TextBox);
            this.GroupBox.Controls.Add(this.Links_TextBox);
            this.GroupBox.Controls.Add(this.Music_TextBox);
            this.GroupBox.Controls.Add(this.Videos_TextBox);
            this.GroupBox.Controls.Add(this.Pictures_TextBox);
            this.GroupBox.Controls.Add(this.Documents_TextBox);
            this.GroupBox.Controls.Add(this.Downloads_TextBox);
            this.GroupBox.Controls.Add(this.Desktop_TextBox);
            this.GroupBox.Controls.Add(this.Objects);
            this.GroupBox.Controls.Add(this.Contacts);
            this.GroupBox.Controls.Add(this.SavedGames);
            this.GroupBox.Controls.Add(this.Searches);
            this.GroupBox.Controls.Add(this.Favorites);
            this.GroupBox.Controls.Add(this.Links);
            this.GroupBox.Controls.Add(this.Music);
            this.GroupBox.Controls.Add(this.Videos);
            this.GroupBox.Controls.Add(this.Pictures);
            this.GroupBox.Controls.Add(this.Documents);
            this.GroupBox.Controls.Add(this.Downloads);
            this.GroupBox.Controls.Add(this.Desktop);
            this.GroupBox.Location = new System.Drawing.Point(15, 79);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(331, 183);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(135, 0);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckBox.TabIndex = 0;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.Click += new System.EventHandler(this.SelectAllCheckBox_Click);
            // 
            // Objects_Button
            // 
            this.Objects_Button.Enabled = false;
            this.Objects_Button.Location = new System.Drawing.Point(184, 293);
            this.Objects_Button.Name = "Objects_Button";
            this.Objects_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Objects_Button.Size = new System.Drawing.Size(25, 22);
            this.Objects_Button.TabIndex = 34;
            this.Objects_Button.Text = "...";
            this.Objects_Button.UseVisualStyleBackColor = true;
            this.Objects_Button.Visible = false;
            this.Objects_Button.Click += new System.EventHandler(this.Objects_Button_Click);
            // 
            // Contacts_Button
            // 
            this.Contacts_Button.Enabled = false;
            this.Contacts_Button.Location = new System.Drawing.Point(184, 243);
            this.Contacts_Button.Name = "Contacts_Button";
            this.Contacts_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Contacts_Button.Size = new System.Drawing.Size(25, 22);
            this.Contacts_Button.TabIndex = 31;
            this.Contacts_Button.Text = "...";
            this.Contacts_Button.UseVisualStyleBackColor = true;
            this.Contacts_Button.Visible = false;
            this.Contacts_Button.Click += new System.EventHandler(this.Contacts_Button_Click);
            // 
            // SavedGames_Button
            // 
            this.SavedGames_Button.Enabled = false;
            this.SavedGames_Button.Location = new System.Drawing.Point(184, 193);
            this.SavedGames_Button.Name = "SavedGames_Button";
            this.SavedGames_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SavedGames_Button.Size = new System.Drawing.Size(25, 22);
            this.SavedGames_Button.TabIndex = 28;
            this.SavedGames_Button.Text = "...";
            this.SavedGames_Button.UseVisualStyleBackColor = true;
            this.SavedGames_Button.Visible = false;
            this.SavedGames_Button.Click += new System.EventHandler(this.SavedGames_Button_Click);
            // 
            // Searches_Button
            // 
            this.Searches_Button.Enabled = false;
            this.Searches_Button.Location = new System.Drawing.Point(184, 143);
            this.Searches_Button.Name = "Searches_Button";
            this.Searches_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Searches_Button.Size = new System.Drawing.Size(25, 22);
            this.Searches_Button.TabIndex = 25;
            this.Searches_Button.Text = "...";
            this.Searches_Button.UseVisualStyleBackColor = true;
            this.Searches_Button.Visible = false;
            this.Searches_Button.Click += new System.EventHandler(this.Searches_Button_Click);
            // 
            // Favorites_Button
            // 
            this.Favorites_Button.Enabled = false;
            this.Favorites_Button.Location = new System.Drawing.Point(184, 93);
            this.Favorites_Button.Name = "Favorites_Button";
            this.Favorites_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Favorites_Button.Size = new System.Drawing.Size(25, 22);
            this.Favorites_Button.TabIndex = 22;
            this.Favorites_Button.Text = "...";
            this.Favorites_Button.UseVisualStyleBackColor = true;
            this.Favorites_Button.Visible = false;
            this.Favorites_Button.Click += new System.EventHandler(this.Favorites_Button_Click);
            // 
            // Links_Button
            // 
            this.Links_Button.Enabled = false;
            this.Links_Button.Location = new System.Drawing.Point(184, 43);
            this.Links_Button.Name = "Links_Button";
            this.Links_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Links_Button.Size = new System.Drawing.Size(25, 22);
            this.Links_Button.TabIndex = 19;
            this.Links_Button.Text = "...";
            this.Links_Button.UseVisualStyleBackColor = true;
            this.Links_Button.Visible = false;
            this.Links_Button.Click += new System.EventHandler(this.Links_Button_Click);
            // 
            // Music_Button
            // 
            this.Music_Button.Enabled = false;
            this.Music_Button.Location = new System.Drawing.Point(23, 293);
            this.Music_Button.Name = "Music_Button";
            this.Music_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Music_Button.Size = new System.Drawing.Size(25, 22);
            this.Music_Button.TabIndex = 16;
            this.Music_Button.Text = "...";
            this.Music_Button.UseVisualStyleBackColor = true;
            this.Music_Button.Visible = false;
            this.Music_Button.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // Videos_Button
            // 
            this.Videos_Button.Enabled = false;
            this.Videos_Button.Location = new System.Drawing.Point(23, 243);
            this.Videos_Button.Name = "Videos_Button";
            this.Videos_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Videos_Button.Size = new System.Drawing.Size(25, 22);
            this.Videos_Button.TabIndex = 13;
            this.Videos_Button.Text = "...";
            this.Videos_Button.UseVisualStyleBackColor = true;
            this.Videos_Button.Visible = false;
            this.Videos_Button.Click += new System.EventHandler(this.VideosButton_Click);
            // 
            // Pictures_Button
            // 
            this.Pictures_Button.Enabled = false;
            this.Pictures_Button.Location = new System.Drawing.Point(23, 193);
            this.Pictures_Button.Name = "Pictures_Button";
            this.Pictures_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pictures_Button.Size = new System.Drawing.Size(25, 22);
            this.Pictures_Button.TabIndex = 10;
            this.Pictures_Button.Text = "...";
            this.Pictures_Button.UseVisualStyleBackColor = true;
            this.Pictures_Button.Visible = false;
            this.Pictures_Button.Click += new System.EventHandler(this.PicturesButton_Click);
            // 
            // Documents_Button
            // 
            this.Documents_Button.Enabled = false;
            this.Documents_Button.Location = new System.Drawing.Point(23, 143);
            this.Documents_Button.Name = "Documents_Button";
            this.Documents_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Documents_Button.Size = new System.Drawing.Size(25, 22);
            this.Documents_Button.TabIndex = 7;
            this.Documents_Button.Text = "...";
            this.Documents_Button.UseVisualStyleBackColor = true;
            this.Documents_Button.Visible = false;
            this.Documents_Button.Click += new System.EventHandler(this.DocumentsButton_Click);
            // 
            // Downloads_Button
            // 
            this.Downloads_Button.Enabled = false;
            this.Downloads_Button.Location = new System.Drawing.Point(23, 93);
            this.Downloads_Button.Name = "Downloads_Button";
            this.Downloads_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Downloads_Button.Size = new System.Drawing.Size(25, 22);
            this.Downloads_Button.TabIndex = 4;
            this.Downloads_Button.Text = "...";
            this.Downloads_Button.UseVisualStyleBackColor = true;
            this.Downloads_Button.Visible = false;
            this.Downloads_Button.Click += new System.EventHandler(this.DownloadsButton_Click);
            // 
            // Desktop_Button
            // 
            this.Desktop_Button.Enabled = false;
            this.Desktop_Button.Location = new System.Drawing.Point(23, 43);
            this.Desktop_Button.Name = "Desktop_Button";
            this.Desktop_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Desktop_Button.Size = new System.Drawing.Size(25, 22);
            this.Desktop_Button.TabIndex = 1;
            this.Desktop_Button.Text = "...";
            this.Desktop_Button.UseVisualStyleBackColor = true;
            this.Desktop_Button.Visible = false;
            this.Desktop_Button.Click += new System.EventHandler(this.DesktopButton_Click);
            // 
            // Objects_TextBox
            // 
            this.Objects_TextBox.Enabled = false;
            this.Objects_TextBox.Location = new System.Drawing.Point(211, 294);
            this.Objects_TextBox.Name = "Objects_TextBox";
            this.Objects_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Objects_TextBox.TabIndex = 35;
            this.Objects_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{31C0DD25-9439-4F12-BF41-7FF4EDA38722}");
            this.Objects_TextBox.Visible = false;
            this.Objects_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Contacts_TextBox
            // 
            this.Contacts_TextBox.Enabled = false;
            this.Contacts_TextBox.Location = new System.Drawing.Point(211, 244);
            this.Contacts_TextBox.Name = "Contacts_TextBox";
            this.Contacts_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Contacts_TextBox.TabIndex = 32;
            this.Contacts_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{56784854-C6CB-462B-8169-88E350ACB882}");
            this.Contacts_TextBox.Visible = false;
            this.Contacts_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SavedGames_TextBox
            // 

            this.SavedGames_TextBox.Enabled = false;
            this.SavedGames_TextBox.Location = new System.Drawing.Point(211, 194);
            this.SavedGames_TextBox.Name = "SavedGames_TextBox";
            this.SavedGames_TextBox.Size = new System.Drawing.Size(103, 20);
            this.SavedGames_TextBox.TabIndex = 29;
            this.SavedGames_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}");
            this.SavedGames_TextBox.Visible = false;
            this.SavedGames_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Searches_TextBox
            // 
            this.Searches_TextBox.Enabled = false;
            this.Searches_TextBox.Location = new System.Drawing.Point(211, 144);
            this.Searches_TextBox.Name = "Searches_TextBox";
            this.Searches_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Searches_TextBox.TabIndex = 26;
            this.Searches_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}");
            this.Searches_TextBox.Visible = false;
            this.Searches_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Favorites_TextBox
            // 
            this.Favorites_TextBox.Enabled = false;
            this.Favorites_TextBox.Location = new System.Drawing.Point(211, 94);
            this.Favorites_TextBox.Name = "Favorites_TextBox";
            this.Favorites_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Favorites_TextBox.TabIndex = 23;
            this.Favorites_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("Favorites");
            this.Favorites_TextBox.Visible = false;
            this.Favorites_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Links_TextBox
            // 
            this.Links_TextBox.Enabled = false;
            this.Links_TextBox.Location = new System.Drawing.Point(211, 44);
            this.Links_TextBox.Name = "Links_TextBox";
            this.Links_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Links_TextBox.TabIndex = 20;
            this.Links_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}");
            this.Links_TextBox.Visible = false;
            this.Links_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Music_TextBox
            // 
            this.Music_TextBox.Enabled = false;
            this.Music_TextBox.Location = new System.Drawing.Point(50, 294);
            this.Music_TextBox.Name = "Music_TextBox";
            this.Music_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Music_TextBox.TabIndex = 17;
            this.Music_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("My Music");
            this.Music_TextBox.Visible = false;
            this.Music_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Videos_TextBox
            // 
            this.Videos_TextBox.Enabled = false;
            this.Videos_TextBox.Location = new System.Drawing.Point(50, 244);
            this.Videos_TextBox.Name = "Videos_TextBox";
            this.Videos_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Videos_TextBox.TabIndex = 14;
            this.Videos_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("My Video");
            this.Videos_TextBox.Visible = false;
            this.Videos_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Pictures_TextBox
            // 
            this.Pictures_TextBox.Enabled = false;
            this.Pictures_TextBox.Location = new System.Drawing.Point(50, 194);
            this.Pictures_TextBox.Name = "Pictures_TextBox";
            this.Pictures_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Pictures_TextBox.TabIndex = 11;
            this.Pictures_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("My Pictures");
            this.Pictures_TextBox.Visible = false;
            this.Pictures_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Documents_TextBox
            // 
            this.Documents_TextBox.Enabled = false;
            this.Documents_TextBox.Location = new System.Drawing.Point(50, 144);
            this.Documents_TextBox.Name = "Documents_TextBox";
            this.Documents_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Documents_TextBox.TabIndex = 8;
            this.Documents_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("Personal");
            this.Documents_TextBox.Visible = false;
            this.Documents_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Downloads_TextBox
            // 
            this.Downloads_TextBox.Enabled = false;
            this.Downloads_TextBox.Location = new System.Drawing.Point(50, 94);
            this.Downloads_TextBox.Name = "Downloads_TextBox";
            this.Downloads_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Downloads_TextBox.TabIndex = 5;
            this.Downloads_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("{374DE290-123F-4565-9164-39C4925E467B}");
            this.Downloads_TextBox.Visible = false;
            this.Downloads_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Desktop_TextBox
            // 
            this.Desktop_TextBox.Enabled = false;
            this.Desktop_TextBox.Location = new System.Drawing.Point(50, 44);
            this.Desktop_TextBox.Name = "Desktop_TextBox";
            this.Desktop_TextBox.Size = new System.Drawing.Size(103, 20);
            this.Desktop_TextBox.TabIndex = 2;
            this.Desktop_TextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\' + GetFolderName("Desktop");
            this.Desktop_TextBox.Visible = false;
            this.Desktop_TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Objects
            // 
            this.Objects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Objects.AutoSize = true;
            this.Objects.Image = ((System.Drawing.Image)(resources.GetObject("Objects.Image")));
            this.Objects.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Objects.Location = new System.Drawing.Point(190, 144);
            this.Objects.Margin = new System.Windows.Forms.Padding(0);
            this.Objects.MinimumSize = new System.Drawing.Size(0, 25);
            this.Objects.Name = "Objects";
            this.Objects.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Objects.Size = new System.Drawing.Size(102, 25);
            this.Objects.TabIndex = 33;
            this.Objects.Text = "3D Objects";
            this.Objects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Objects.UseVisualStyleBackColor = true;
            this.Objects.CheckedChanged += new System.EventHandler(this.Objects_CheckedChanged);
            // 
            // Contacts
            // 
            this.Contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contacts.AutoSize = true;
            this.Contacts.Image = ((System.Drawing.Image)(resources.GetObject("Contacts.Image")));
            this.Contacts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Contacts.Location = new System.Drawing.Point(190, 119);
            this.Contacts.Margin = new System.Windows.Forms.Padding(0);
            this.Contacts.MinimumSize = new System.Drawing.Size(0, 25);
            this.Contacts.Name = "Contacts";
            this.Contacts.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Contacts.Size = new System.Drawing.Size(87, 25);
            this.Contacts.TabIndex = 30;
            this.Contacts.Text = "Contacts";
            this.Contacts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Contacts.UseVisualStyleBackColor = true;
            this.Contacts.CheckedChanged += new System.EventHandler(this.Contacts_CheckedChanged);
            // 
            // SavedGames
            // 
            this.SavedGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedGames.AutoSize = true;
            this.SavedGames.Image = ((System.Drawing.Image)(resources.GetObject("SavedGames.Image")));
            this.SavedGames.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SavedGames.Location = new System.Drawing.Point(190, 94);
            this.SavedGames.Margin = new System.Windows.Forms.Padding(0);
            this.SavedGames.MinimumSize = new System.Drawing.Size(0, 25);
            this.SavedGames.Name = "SavedGames";
            this.SavedGames.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.SavedGames.Size = new System.Drawing.Size(112, 25);
            this.SavedGames.TabIndex = 27;
            this.SavedGames.Text = "Saved Games";
            this.SavedGames.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SavedGames.UseVisualStyleBackColor = true;
            this.SavedGames.CheckedChanged += new System.EventHandler(this.SavedGames_CheckedChanged);
            // 
            // Searches
            // 
            this.Searches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Searches.AutoSize = true;
            this.Searches.Image = ((System.Drawing.Image)(resources.GetObject("Searches.Image")));
            this.Searches.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Searches.Location = new System.Drawing.Point(190, 69);
            this.Searches.Margin = new System.Windows.Forms.Padding(0);
            this.Searches.MinimumSize = new System.Drawing.Size(0, 25);
            this.Searches.Name = "Searches";
            this.Searches.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Searches.Size = new System.Drawing.Size(90, 25);
            this.Searches.TabIndex = 24;
            this.Searches.Text = "Searches";
            this.Searches.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Searches.UseVisualStyleBackColor = true;
            this.Searches.CheckedChanged += new System.EventHandler(this.Searches_CheckedChanged);
            // 
            // Favorites
            // 
            this.Favorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Favorites.AutoSize = true;
            this.Favorites.Image = ((System.Drawing.Image)(resources.GetObject("Favorites.Image")));
            this.Favorites.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Favorites.Location = new System.Drawing.Point(190, 44);
            this.Favorites.Margin = new System.Windows.Forms.Padding(0);
            this.Favorites.MinimumSize = new System.Drawing.Size(0, 25);
            this.Favorites.Name = "Favorites";
            this.Favorites.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Favorites.Size = new System.Drawing.Size(88, 25);
            this.Favorites.TabIndex = 21;
            this.Favorites.Text = "Favorites";
            this.Favorites.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.CheckedChanged += new System.EventHandler(this.Favorites_CheckedChanged);
            // 
            // Links
            // 
            this.Links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Links.AutoSize = true;
            this.Links.Image = ((System.Drawing.Image)(resources.GetObject("Links.Image")));
            this.Links.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Links.Location = new System.Drawing.Point(190, 19);
            this.Links.Margin = new System.Windows.Forms.Padding(0);
            this.Links.MinimumSize = new System.Drawing.Size(0, 25);
            this.Links.Name = "Links";
            this.Links.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Links.Size = new System.Drawing.Size(74, 25);
            this.Links.TabIndex = 18;
            this.Links.Text = "Links";
            this.Links.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Links.UseVisualStyleBackColor = true;
            this.Links.CheckedChanged += new System.EventHandler(this.Links_CheckedChanged);
            // 
            // Music
            // 
            this.Music.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Music.AutoSize = true;
            this.Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.Image = ((System.Drawing.Image)(resources.GetObject("Music.Image")));
            this.Music.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Music.Location = new System.Drawing.Point(29, 144);
            this.Music.MinimumSize = new System.Drawing.Size(0, 25);
            this.Music.Name = "Music";
            this.Music.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Music.Size = new System.Drawing.Size(82, 25);
            this.Music.TabIndex = 15;
            this.Music.Text = "Music";
            this.Music.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Music.UseVisualStyleBackColor = true;
            this.Music.CheckedChanged += new System.EventHandler(this.Music_CheckedChanged);
            // 
            // Videos
            // 
            this.Videos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Videos.AutoSize = true;
            this.Videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Videos.Image = ((System.Drawing.Image)(resources.GetObject("Videos.Image")));
            this.Videos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Videos.Location = new System.Drawing.Point(29, 119);
            this.Videos.MinimumSize = new System.Drawing.Size(0, 25);
            this.Videos.Name = "Videos";
            this.Videos.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Videos.Size = new System.Drawing.Size(83, 25);
            this.Videos.TabIndex = 12;
            this.Videos.Text = "Videos";
            this.Videos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Videos.UseVisualStyleBackColor = true;
            this.Videos.CheckedChanged += new System.EventHandler(this.Videos_CheckedChanged);
            // 
            // Pictures
            // 
            this.Pictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pictures.AutoSize = true;
            this.Pictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pictures.Image = ((System.Drawing.Image)(resources.GetObject("Pictures.Image")));
            this.Pictures.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pictures.Location = new System.Drawing.Point(29, 94);
            this.Pictures.MinimumSize = new System.Drawing.Size(0, 25);
            this.Pictures.Name = "Pictures";
            this.Pictures.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Pictures.Size = new System.Drawing.Size(93, 25);
            this.Pictures.TabIndex = 9;
            this.Pictures.Text = "Pictures";
            this.Pictures.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Pictures.UseVisualStyleBackColor = true;
            this.Pictures.CheckedChanged += new System.EventHandler(this.Pictures_CheckedChanged);
            // 
            // Documents
            // 
            this.Documents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Documents.AutoSize = true;
            this.Documents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documents.Image = ((System.Drawing.Image)(resources.GetObject("Documents.Image")));
            this.Documents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Documents.Location = new System.Drawing.Point(29, 69);
            this.Documents.MinimumSize = new System.Drawing.Size(0, 25);
            this.Documents.Name = "Documents";
            this.Documents.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Documents.Size = new System.Drawing.Size(108, 25);
            this.Documents.TabIndex = 6;
            this.Documents.Text = "Documents";
            this.Documents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Documents.UseVisualStyleBackColor = true;
            this.Documents.CheckedChanged += new System.EventHandler(this.Documents_CheckedChanged);
            // 
            // Downloads
            // 
            this.Downloads.AutoSize = true;
            this.Downloads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downloads.Image = ((System.Drawing.Image)(resources.GetObject("Downloads.Image")));
            this.Downloads.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Downloads.Location = new System.Drawing.Point(29, 44);
            this.Downloads.MinimumSize = new System.Drawing.Size(0, 25);
            this.Downloads.Name = "Downloads";
            this.Downloads.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Downloads.Size = new System.Drawing.Size(107, 25);
            this.Downloads.TabIndex = 3;
            this.Downloads.Text = "Downloads";
            this.Downloads.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Downloads.UseVisualStyleBackColor = true;
            this.Downloads.CheckedChanged += new System.EventHandler(this.Downloads_CheckedChanged);
            // 
            // Desktop
            // 
            this.Desktop.AutoSize = true;
            this.Desktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desktop.Image = ((System.Drawing.Image)(resources.GetObject("Desktop.Image")));
            this.Desktop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Desktop.Location = new System.Drawing.Point(29, 19);
            this.Desktop.MinimumSize = new System.Drawing.Size(0, 25);
            this.Desktop.Name = "Desktop";
            this.Desktop.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Desktop.Size = new System.Drawing.Size(94, 25);
            this.Desktop.TabIndex = 0;
            this.Desktop.Text = "Desktop";
            this.Desktop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Desktop.UseVisualStyleBackColor = true;
            this.Desktop.CheckedChanged += new System.EventHandler(this.Desktop_CheckedChanged);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(12, 34);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(145, 16);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "Select desired location";
            // 
            // LocationBrowserDialog
            // 
            this.LocationBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // LocationBrowseButton
            // 
            this.LocationBrowseButton.Location = new System.Drawing.Point(15, 52);
            this.LocationBrowseButton.Name = "LocationBrowseButton";
            this.LocationBrowseButton.Size = new System.Drawing.Size(75, 22);
            this.LocationBrowseButton.TabIndex = 4;
            this.LocationBrowseButton.Text = "Browse...";
            this.LocationBrowseButton.UseVisualStyleBackColor = true;
            this.LocationBrowseButton.Click += new System.EventHandler(this.LocationBrowseButton_Click);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(96, 53);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(250, 20);
            this.LocationTextBox.TabIndex = 5;
            this.LocationTextBox.Text = System.Environment.GetEnvironmentVariable("USERPROFILE") + '\\';
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(16, 269);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(83, 25);
            this.moveButton.TabIndex = 7;
            this.moveButton.Text = "Move folders";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(320, 269);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(26, 25);
            this.infoButton.TabIndex = 9;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(105, 270);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(212, 23);
            this.progressBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 309);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationBrowseButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.QuestionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Move User Folders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.FolderBrowserDialog LocationBrowserDialog;
        private System.Windows.Forms.Button LocationBrowseButton;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.CheckBox Desktop;
        private System.Windows.Forms.CheckBox Downloads;
        private System.Windows.Forms.CheckBox Documents;
        private System.Windows.Forms.CheckBox Pictures;
        private System.Windows.Forms.CheckBox Videos;
        private System.Windows.Forms.CheckBox Music;
        private System.Windows.Forms.CheckBox Links;
        private System.Windows.Forms.CheckBox Favorites;
        private System.Windows.Forms.CheckBox Searches;
        private System.Windows.Forms.CheckBox SavedGames;
        private System.Windows.Forms.CheckBox Contacts;
        private System.Windows.Forms.CheckBox Objects;
        private System.Windows.Forms.Button Desktop_Button;
        private System.Windows.Forms.TextBox Desktop_TextBox;
        private System.Windows.Forms.Button Links_Button;
        private System.Windows.Forms.TextBox Links_TextBox;
        private System.Windows.Forms.Button Favorites_Button;
        private System.Windows.Forms.TextBox Favorites_TextBox;
        private System.Windows.Forms.Button Downloads_Button;
        private System.Windows.Forms.TextBox Downloads_TextBox;
        private System.Windows.Forms.Button SavedGames_Button;
        private System.Windows.Forms.Button Searches_Button;
        private System.Windows.Forms.Button Pictures_Button;
        private System.Windows.Forms.Button Documents_Button;
        private System.Windows.Forms.TextBox SavedGames_TextBox;
        private System.Windows.Forms.TextBox Searches_TextBox;
        private System.Windows.Forms.TextBox Pictures_TextBox;
        private System.Windows.Forms.TextBox Documents_TextBox;
        private System.Windows.Forms.Button Objects_Button;
        private System.Windows.Forms.Button Contacts_Button;
        private System.Windows.Forms.Button Music_Button;
        private System.Windows.Forms.Button Videos_Button;
        private System.Windows.Forms.TextBox Objects_TextBox;
        private System.Windows.Forms.TextBox Contacts_TextBox;
        private System.Windows.Forms.TextBox Music_TextBox;
        private System.Windows.Forms.TextBox Videos_TextBox;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

