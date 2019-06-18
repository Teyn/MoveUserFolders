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
            this.right6 = new System.Windows.Forms.CheckBox();
            this.right5 = new System.Windows.Forms.CheckBox();
            this.right4 = new System.Windows.Forms.CheckBox();
            this.right3 = new System.Windows.Forms.CheckBox();
            this.right2 = new System.Windows.Forms.CheckBox();
            this.right1 = new System.Windows.Forms.CheckBox();
            this.left6 = new System.Windows.Forms.CheckBox();
            this.left5 = new System.Windows.Forms.CheckBox();
            this.left4 = new System.Windows.Forms.CheckBox();
            this.left1 = new System.Windows.Forms.CheckBox();
            this.left3 = new System.Windows.Forms.CheckBox();
            this.left2 = new System.Windows.Forms.CheckBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LocationBrowseButton = new System.Windows.Forms.Button();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
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
            this.YesRadioButton.Click += new System.EventHandler(this.RadioButton1_Click);
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
            this.NoRadioButton.Click += new System.EventHandler(this.RadioButton2_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.right6);
            this.GroupBox.Controls.Add(this.right5);
            this.GroupBox.Controls.Add(this.right4);
            this.GroupBox.Controls.Add(this.right3);
            this.GroupBox.Controls.Add(this.right2);
            this.GroupBox.Controls.Add(this.right1);
            this.GroupBox.Controls.Add(this.left6);
            this.GroupBox.Controls.Add(this.left5);
            this.GroupBox.Controls.Add(this.left4);
            this.GroupBox.Controls.Add(this.left1);
            this.GroupBox.Controls.Add(this.left3);
            this.GroupBox.Controls.Add(this.left2);
            this.GroupBox.Location = new System.Drawing.Point(15, 79);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(331, 327);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.TabStop = false;
            // 
            // right6
            // 
            this.right6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right6.AutoSize = true;
            this.right6.Image = ((System.Drawing.Image)(resources.GetObject("right6.Image")));
            this.right6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right6.Location = new System.Drawing.Point(190, 144);
            this.right6.Margin = new System.Windows.Forms.Padding(0);
            this.right6.MinimumSize = new System.Drawing.Size(0, 25);
            this.right6.Name = "right6";
            this.right6.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right6.Size = new System.Drawing.Size(102, 25);
            this.right6.TabIndex = 10;
            this.right6.Text = "3D Objects";
            this.right6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right6.UseVisualStyleBackColor = true;
            this.right6.Click += new System.EventHandler(this.Objects_Click);
            // 
            // right5
            // 
            this.right5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right5.AutoSize = true;
            this.right5.Image = ((System.Drawing.Image)(resources.GetObject("right5.Image")));
            this.right5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right5.Location = new System.Drawing.Point(190, 119);
            this.right5.Margin = new System.Windows.Forms.Padding(0);
            this.right5.MinimumSize = new System.Drawing.Size(0, 25);
            this.right5.Name = "right5";
            this.right5.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right5.Size = new System.Drawing.Size(87, 25);
            this.right5.TabIndex = 9;
            this.right5.Text = "Contacts";
            this.right5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right5.UseVisualStyleBackColor = true;
            this.right5.Click += new System.EventHandler(this.Objects_Click);
            // 
            // right4
            // 
            this.right4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right4.AutoSize = true;
            this.right4.Image = ((System.Drawing.Image)(resources.GetObject("right4.Image")));
            this.right4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right4.Location = new System.Drawing.Point(190, 94);
            this.right4.Margin = new System.Windows.Forms.Padding(0);
            this.right4.MinimumSize = new System.Drawing.Size(0, 25);
            this.right4.Name = "right4";
            this.right4.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right4.Size = new System.Drawing.Size(112, 25);
            this.right4.TabIndex = 8;
            this.right4.Text = "Saved Games";
            this.right4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right4.UseVisualStyleBackColor = true;
            this.right4.Click += new System.EventHandler(this.Objects_Click);
            // 
            // right3
            // 
            this.right3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right3.AutoSize = true;
            this.right3.Image = ((System.Drawing.Image)(resources.GetObject("right3.Image")));
            this.right3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right3.Location = new System.Drawing.Point(190, 69);
            this.right3.Margin = new System.Windows.Forms.Padding(0);
            this.right3.MinimumSize = new System.Drawing.Size(0, 25);
            this.right3.Name = "right3";
            this.right3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right3.Size = new System.Drawing.Size(90, 25);
            this.right3.TabIndex = 8;
            this.right3.Text = "Searches";
            this.right3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right3.UseVisualStyleBackColor = true;
            this.right3.Click += new System.EventHandler(this.Objects_Click);
            // 
            // right2
            // 
            this.right2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right2.AutoSize = true;
            this.right2.Image = ((System.Drawing.Image)(resources.GetObject("right2.Image")));
            this.right2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right2.Location = new System.Drawing.Point(190, 44);
            this.right2.Margin = new System.Windows.Forms.Padding(0);
            this.right2.MinimumSize = new System.Drawing.Size(0, 25);
            this.right2.Name = "right2";
            this.right2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right2.Size = new System.Drawing.Size(88, 25);
            this.right2.TabIndex = 7;
            this.right2.Text = "Favorites";
            this.right2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right2.UseVisualStyleBackColor = true;
            this.right2.Click += new System.EventHandler(this.Objects_Click);
            // 
            // right1
            // 
            this.right1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right1.AutoSize = true;
            this.right1.Image = ((System.Drawing.Image)(resources.GetObject("right1.Image")));
            this.right1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.right1.Location = new System.Drawing.Point(190, 19);
            this.right1.Margin = new System.Windows.Forms.Padding(0);
            this.right1.MinimumSize = new System.Drawing.Size(0, 25);
            this.right1.Name = "right1";
            this.right1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.right1.Size = new System.Drawing.Size(74, 25);
            this.right1.TabIndex = 6;
            this.right1.Text = "Links";
            this.right1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.right1.UseVisualStyleBackColor = true;
            this.right1.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left6
            // 
            this.left6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.left6.AutoSize = true;
            this.left6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left6.Image = ((System.Drawing.Image)(resources.GetObject("left6.Image")));
            this.left6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left6.Location = new System.Drawing.Point(29, 144);
            this.left6.MinimumSize = new System.Drawing.Size(0, 25);
            this.left6.Name = "left6";
            this.left6.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left6.Size = new System.Drawing.Size(82, 25);
            this.left6.TabIndex = 5;
            this.left6.Text = "Music";
            this.left6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left6.UseVisualStyleBackColor = true;
            this.left6.CheckedChanged += new System.EventHandler(this.Music_CheckedChanged);
            this.left6.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left5
            // 
            this.left5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.left5.AutoSize = true;
            this.left5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left5.Image = ((System.Drawing.Image)(resources.GetObject("left5.Image")));
            this.left5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left5.Location = new System.Drawing.Point(29, 119);
            this.left5.MinimumSize = new System.Drawing.Size(0, 25);
            this.left5.Name = "left5";
            this.left5.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left5.Size = new System.Drawing.Size(83, 25);
            this.left5.TabIndex = 4;
            this.left5.Text = "Videos";
            this.left5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left5.UseVisualStyleBackColor = true;
            this.left5.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left4
            // 
            this.left4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.left4.AutoSize = true;
            this.left4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left4.Image = ((System.Drawing.Image)(resources.GetObject("left4.Image")));
            this.left4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left4.Location = new System.Drawing.Point(29, 94);
            this.left4.MinimumSize = new System.Drawing.Size(0, 25);
            this.left4.Name = "left4";
            this.left4.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left4.Size = new System.Drawing.Size(93, 25);
            this.left4.TabIndex = 3;
            this.left4.Text = "Pictures";
            this.left4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left4.UseVisualStyleBackColor = true;
            this.left4.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left1
            // 
            this.left1.AutoSize = true;
            this.left1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left1.Image = ((System.Drawing.Image)(resources.GetObject("left1.Image")));
            this.left1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left1.Location = new System.Drawing.Point(29, 19);
            this.left1.MinimumSize = new System.Drawing.Size(0, 25);
            this.left1.Name = "left1";
            this.left1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left1.Size = new System.Drawing.Size(94, 25);
            this.left1.TabIndex = 0;
            this.left1.Text = "Desktop";
            this.left1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left1.UseVisualStyleBackColor = true;
            this.left1.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left3
            // 
            this.left3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.left3.AutoSize = true;
            this.left3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left3.Image = ((System.Drawing.Image)(resources.GetObject("left3.Image")));
            this.left3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left3.Location = new System.Drawing.Point(29, 69);
            this.left3.MinimumSize = new System.Drawing.Size(0, 25);
            this.left3.Name = "left3";
            this.left3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left3.Size = new System.Drawing.Size(108, 25);
            this.left3.TabIndex = 2;
            this.left3.Text = "Documents";
            this.left3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left3.UseVisualStyleBackColor = true;
            this.left3.CheckedChanged += new System.EventHandler(this.Documents_CheckedChanged);
            this.left3.Click += new System.EventHandler(this.Objects_Click);
            // 
            // left2
            // 
            this.left2.AutoSize = true;
            this.left2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left2.Image = ((System.Drawing.Image)(resources.GetObject("left2.Image")));
            this.left2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.left2.Location = new System.Drawing.Point(29, 44);
            this.left2.MinimumSize = new System.Drawing.Size(0, 25);
            this.left2.Name = "left2";
            this.left2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.left2.Size = new System.Drawing.Size(107, 25);
            this.left2.TabIndex = 1;
            this.left2.Text = "Downloads";
            this.left2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.left2.UseVisualStyleBackColor = true;
            this.left2.Click += new System.EventHandler(this.Objects_Click);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(12, 34);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(145, 16);
            this.LocationLabel.TabIndex = 4;
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
            this.LocationBrowseButton.TabIndex = 5;
            this.LocationBrowseButton.Text = "Browse...";
            this.LocationBrowseButton.UseVisualStyleBackColor = true;
            this.LocationBrowseButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(96, 53);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(250, 20);
            this.LocationTextBox.TabIndex = 6;
            this.LocationTextBox.Text = "C:\\Users\\teyn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 361);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationBrowseButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.QuestionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //this.Desktop.Image = new System.Drawing.Icon("F:/Asztal/MoveFolders/MoveDefaultUserFolders/MoveDefaultUserFolders/Icons/Desktop.ico").ToBitmap();
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.FolderBrowserDialog LocationBrowserDialog;
        private System.Windows.Forms.Button LocationBrowseButton;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.CheckBox left1;
        private System.Windows.Forms.CheckBox left2;
        private System.Windows.Forms.CheckBox left3;
        private System.Windows.Forms.CheckBox left4;
        private System.Windows.Forms.CheckBox left5;
        private System.Windows.Forms.CheckBox left6;
        private System.Windows.Forms.CheckBox right1;
        private System.Windows.Forms.CheckBox right2;
        private System.Windows.Forms.CheckBox right3;
        private System.Windows.Forms.CheckBox right4;
        private System.Windows.Forms.CheckBox right5;
        private System.Windows.Forms.CheckBox right6;
    }
}

