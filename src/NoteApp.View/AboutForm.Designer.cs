namespace NoteApp
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.NoteAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLink = new System.Windows.Forms.LinkLabel();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.MyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteAppLabel
            // 
            this.NoteAppLabel.AutoSize = true;
            this.NoteAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteAppLabel.Location = new System.Drawing.Point(24, 23);
            this.NoteAppLabel.Name = "NoteAppLabel";
            this.NoteAppLabel.Size = new System.Drawing.Size(79, 20);
            this.NoteAppLabel.TabIndex = 0;
            this.NoteAppLabel.Text = "NoteApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(25, 52);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(40, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(25, 84);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(153, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Kumarbekov Nurdaulet";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(25, 114);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(97, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "email for feedback:";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(25, 139);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(43, 13);
            this.GithubLabel.TabIndex = 4;
            this.GithubLabel.Text = "GitHub:";
            // 
            // EmailLink
            // 
            this.EmailLink.AutoSize = true;
            this.EmailLink.Location = new System.Drawing.Point(128, 114);
            this.EmailLink.Name = "EmailLink";
            this.EmailLink.Size = new System.Drawing.Size(88, 13);
            this.EmailLink.TabIndex = 5;
            this.EmailLink.TabStop = true;
            this.EmailLink.Text = "mrnurdik@mail.ru";
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Location = new System.Drawing.Point(74, 139);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(140, 13);
            this.GitHubLink.TabIndex = 6;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "https://github.com/Scissord";
            // 
            // MyNameLabel
            // 
            this.MyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MyNameLabel.AutoSize = true;
            this.MyNameLabel.Location = new System.Drawing.Point(25, 296);
            this.MyNameLabel.Name = "MyNameLabel";
            this.MyNameLabel.Size = new System.Drawing.Size(143, 13);
            this.MyNameLabel.TabIndex = 7;
            this.MyNameLabel.Text = "2022 Kumarbekov Nurdaulet";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 318);
            this.Controls.Add(this.MyNameLabel);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.EmailLink);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NoteAppLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.LinkLabel EmailLink;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.Label MyNameLabel;
    }
}