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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Desktop = new System.Windows.Forms.CheckBox();
            this.Documents = new System.Windows.Forms.CheckBox();
            this.Downloads = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Move selection to the same location?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(246, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(302, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Desktop);
            this.groupBox1.Controls.Add(this.Documents);
            this.groupBox1.Controls.Add(this.Downloads);
            this.groupBox1.Location = new System.Drawing.Point(15, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Desktop
            // 
            this.Desktop.AutoSize = true;
            this.Desktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desktop.Image = ((System.Drawing.Image)(resources.GetObject("Desktop.Image")));
            this.Desktop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Desktop.Location = new System.Drawing.Point(6, 19);
            this.Desktop.Margin = new System.Windows.Forms.Padding(0);
            this.Desktop.MinimumSize = new System.Drawing.Size(0, 25);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(91, 25);
            this.Desktop.TabIndex = 0;
            this.Desktop.Text = "Desktop";
            this.Desktop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Desktop.UseVisualStyleBackColor = true;
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
            this.Documents.Location = new System.Drawing.Point(6, 69);
            this.Documents.Margin = new System.Windows.Forms.Padding(0);
            this.Documents.MinimumSize = new System.Drawing.Size(0, 25);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(105, 25);
            this.Documents.TabIndex = 2;
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
            this.Downloads.Location = new System.Drawing.Point(6, 44);
            this.Downloads.Margin = new System.Windows.Forms.Padding(0);
            this.Downloads.MinimumSize = new System.Drawing.Size(0, 25);
            this.Downloads.Name = "Downloads";
            this.Downloads.Size = new System.Drawing.Size(108, 25);
            this.Downloads.TabIndex = 1;
            this.Downloads.Text = "Downloads";
            this.Downloads.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Downloads.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select desired location";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "C:\\Users\\teyn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 281);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //this.Desktop.Image = new System.Drawing.Icon("F:/Asztal/MoveFolders/MoveDefaultUserFolders/MoveDefaultUserFolders/Icons/Desktop.ico").ToBitmap();
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Desktop;
        private System.Windows.Forms.CheckBox Downloads;
        private System.Windows.Forms.CheckBox Documents;
    }
}

