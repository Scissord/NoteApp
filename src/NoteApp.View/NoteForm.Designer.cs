namespace NoteApp
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel2 = new System.Windows.Forms.Label();
            this.CreatedLabel2 = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.CategoryAskingLabel = new System.Windows.Forms.ComboBox();
            this.ModifiedLabel2 = new System.Windows.Forms.Label();
            this.CreatedDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NotesTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel2
            // 
            this.CategoryLabel2.AutoSize = true;
            this.CategoryLabel2.Location = new System.Drawing.Point(12, 41);
            this.CategoryLabel2.Name = "CategoryLabel2";
            this.CategoryLabel2.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel2.TabIndex = 1;
            this.CategoryLabel2.Text = "Category:";
            // 
            // CreatedLabel2
            // 
            this.CreatedLabel2.AutoSize = true;
            this.CreatedLabel2.Location = new System.Drawing.Point(12, 67);
            this.CreatedLabel2.Name = "CreatedLabel2";
            this.CreatedLabel2.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel2.TabIndex = 2;
            this.CreatedLabel2.Text = "Created:";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Location = new System.Drawing.Point(70, 12);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(528, 20);
            this.ContentTextBox.TabIndex = 3;
            // 
            // CategoryAskingLabel
            // 
            this.CategoryAskingLabel.FormattingEnabled = true;
            this.CategoryAskingLabel.Location = new System.Drawing.Point(70, 38);
            this.CategoryAskingLabel.Name = "CategoryAskingLabel";
            this.CategoryAskingLabel.Size = new System.Drawing.Size(121, 21);
            this.CategoryAskingLabel.TabIndex = 4;
            // 
            // ModifiedLabel2
            // 
            this.ModifiedLabel2.AutoSize = true;
            this.ModifiedLabel2.Location = new System.Drawing.Point(173, 67);
            this.ModifiedLabel2.Name = "ModifiedLabel2";
            this.ModifiedLabel2.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel2.TabIndex = 5;
            this.ModifiedLabel2.Text = "Modified:";
            // 
            // CreatedDateTimePicker2
            // 
            this.CreatedDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker2.Location = new System.Drawing.Point(70, 64);
            this.CreatedDateTimePicker2.Name = "CreatedDateTimePicker2";
            this.CreatedDateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.CreatedDateTimePicker2.TabIndex = 6;
            // 
            // ModifiedDateTimePicker2
            // 
            this.ModifiedDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker2.Location = new System.Drawing.Point(229, 64);
            this.ModifiedDateTimePicker2.Name = "ModifiedDateTimePicker2";
            this.ModifiedDateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.ModifiedDateTimePicker2.TabIndex = 7;
            this.ModifiedDateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(442, 452);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(523, 452);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NotesTextBox2
            // 
            this.NotesTextBox2.Location = new System.Drawing.Point(15, 90);
            this.NotesTextBox2.Multiline = true;
            this.NotesTextBox2.Name = "NotesTextBox2";
            this.NotesTextBox2.Size = new System.Drawing.Size(583, 356);
            this.NotesTextBox2.TabIndex = 11;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 487);
            this.Controls.Add(this.NotesTextBox2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ModifiedDateTimePicker2);
            this.Controls.Add(this.CreatedDateTimePicker2);
            this.Controls.Add(this.ModifiedLabel2);
            this.Controls.Add(this.CategoryAskingLabel);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.CreatedLabel2);
            this.Controls.Add(this.CategoryLabel2);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel2;
        private System.Windows.Forms.Label CreatedLabel2;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.ComboBox CategoryAskingLabel;
        private System.Windows.Forms.Label ModifiedLabel2;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker2;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker2;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NotesTextBox2;
    }
}