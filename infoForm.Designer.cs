namespace MoveDefaultUserFolders
{
    partial class infoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoForm));
            this.readmeLabel = new System.Windows.Forms.Label();
            this.readmeLink = new System.Windows.Forms.LinkLabel();
            this.githubLabel = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.linkedinLabel = new System.Windows.Forms.Label();
            this.linkedinLink = new System.Windows.Forms.LinkLabel();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // readmeLabel
            // 
            this.readmeLabel.AutoSize = true;
            this.readmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readmeLabel.Location = new System.Drawing.Point(12, 9);
            this.readmeLabel.Name = "readmeLabel";
            this.readmeLabel.Size = new System.Drawing.Size(84, 16);
            this.readmeLabel.TabIndex = 0;
            this.readmeLabel.Text = "Readme file:";
            // 
            // readmeLink
            // 
            this.readmeLink.AutoSize = true;
            this.readmeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readmeLink.Location = new System.Drawing.Point(93, 9);
            this.readmeLink.Name = "readmeLink";
            this.readmeLink.Size = new System.Drawing.Size(37, 16);
            this.readmeLink.TabIndex = 1;
            this.readmeLink.TabStop = true;
            this.readmeLink.Text = "Click";
            this.readmeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLabel.Image = ((System.Drawing.Image)(resources.GetObject("githubLabel.Image")));
            this.githubLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.githubLabel.Location = new System.Drawing.Point(15, 29);
            this.githubLabel.Margin = new System.Windows.Forms.Padding(0);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.githubLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.githubLabel.Size = new System.Drawing.Size(25, 26);
            this.githubLabel.TabIndex = 3;
            this.githubLabel.Text = "    ";
            this.githubLabel.Click += new System.EventHandler(this.GitHubLabel_Click);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.githubLink.LinkColor = System.Drawing.Color.Black;
            this.githubLink.Location = new System.Drawing.Point(40, 32);
            this.githubLink.Margin = new System.Windows.Forms.Padding(0);
            this.githubLink.Name = "githubLink";
            this.githubLink.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.githubLink.Size = new System.Drawing.Size(36, 21);
            this.githubLink.TabIndex = 4;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "/Teyn";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkedinLabel
            // 
            this.linkedinLabel.AutoSize = true;
            this.linkedinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedinLabel.Image = ((System.Drawing.Image)(resources.GetObject("linkedinLabel.Image")));
            this.linkedinLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkedinLabel.Location = new System.Drawing.Point(17, 55);
            this.linkedinLabel.Margin = new System.Windows.Forms.Padding(0);
            this.linkedinLabel.Name = "linkedinLabel";
            this.linkedinLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.linkedinLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkedinLabel.Size = new System.Drawing.Size(29, 26);
            this.linkedinLabel.TabIndex = 3;
            this.linkedinLabel.Text = "     ";
            this.linkedinLabel.Click += new System.EventHandler(this.GitHubLabel_Click);
            // 
            // linkedinLink
            // 
            this.linkedinLink.AutoSize = true;
            this.linkedinLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedinLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkedinLink.LinkColor = System.Drawing.Color.Black;
            this.linkedinLink.Location = new System.Drawing.Point(40, 58);
            this.linkedinLink.Margin = new System.Windows.Forms.Padding(0);
            this.linkedinLink.Name = "linkedinLink";
            this.linkedinLink.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.linkedinLink.Size = new System.Drawing.Size(55, 21);
            this.linkedinLink.TabIndex = 4;
            this.linkedinLink.TabStop = true;
            this.linkedinLink.Text = "/gabor-k/";
            this.linkedinLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseLabel.Location = new System.Drawing.Point(12, 109);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(190, 12);
            this.licenseLabel.TabIndex = 2;
            this.licenseLabel.Text = "Created by Gábor Kiss under the MIT License";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(12, 80);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.linkLabel1.Size = new System.Drawing.Size(195, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Support me by buying me a coffee!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 126);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkedinLink);
            this.Controls.Add(this.linkedinLabel);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.readmeLink);
            this.Controls.Add(this.readmeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "infoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label readmeLabel;
        private System.Windows.Forms.LinkLabel readmeLink;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label linkedinLabel;
        private System.Windows.Forms.LinkLabel linkedinLink;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}