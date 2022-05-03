using NoteApp.Model;
using System;
using System.Collections.Generic;

namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Закрытое поле типа Project.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Обновить элемент ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            AllNotesListBox.Items.Clear();
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                AllNotesListBox.Items.Add(_project.Notes[i].Title);
            }
        }

        /// <summary>
        /// Генерация новых данных.
        /// </summary>
        private void AddNote()
        {
            List<string> words = new List<string>();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();    
            Random rnd = new Random();

            for (int i = 1; i < 2; i++)
            {
                string word = "";
                for (int j = 1; j <= 7; j++)
                {
                    // Выбор случайного числа от 0 до 25
                    // для выбора буквы из массива букв.
                    int letter_num = rnd.Next(0, letters.Length - 1);

                    // Добавить письмо.
                    word += letters[letter_num];
                }

                // Добавьте слово в список.
                words.Add(word);
            }
            int cat = rnd.Next(0, 6);
            _project.Notes.Add(new Note(words[0], Category, words[1]));
        }

        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            else
            {
                AllNotesListBox.Items.RemoveAt(index);
            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AllNotesListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryAnswerLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoseNotesComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllNotesListBox
            // 
            this.AllNotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllNotesListBox.FormattingEnabled = true;
            this.AllNotesListBox.Location = new System.Drawing.Point(12, 54);
            this.AllNotesListBox.Name = "AllNotesListBox";
            this.AllNotesListBox.Size = new System.Drawing.Size(267, 355);
            this.AllNotesListBox.TabIndex = 0;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 29);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 4;
            this.ShowCategoryLabel.Text = "Show Category:";
            this.ShowCategoryLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(295, 54);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryAnswerLabel
            // 
            this.CategoryAnswerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryAnswerLabel.AutoSize = true;
            this.CategoryAnswerLabel.Location = new System.Drawing.Point(345, 54);
            this.CategoryAnswerLabel.Name = "CategoryAnswerLabel";
            this.CategoryAnswerLabel.Size = new System.Drawing.Size(33, 13);
            this.CategoryAnswerLabel.TabIndex = 6;
            this.CategoryAnswerLabel.Text = "Work";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(295, 76);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 7;
            this.CreatedLabel.Text = "Created:";
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(446, 76);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 8;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenu,
            this.EditToolStripMenu,
            this.HelpToolStripMenu});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 10;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenu});
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            this.FileToolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenu.Text = "File";
            // 
            // ExitToolStripMenu
            // 
            this.ExitToolStripMenu.Name = "ExitToolStripMenu";
            this.ExitToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenu.Text = "Exit";
            // 
            // EditToolStripMenu
            // 
            this.EditToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenu,
            this.EditNoteToolStripMenu,
            this.RemoveNoteToolStripMenu});
            this.EditToolStripMenu.Name = "EditToolStripMenu";
            this.EditToolStripMenu.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenu.Text = "Edit";
            // 
            // AddNoteToolStripMenu
            // 
            this.AddNoteToolStripMenu.Name = "AddNoteToolStripMenu";
            this.AddNoteToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.AddNoteToolStripMenu.Text = "Add Note";
            this.AddNoteToolStripMenu.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenu
            // 
            this.EditNoteToolStripMenu.Name = "EditNoteToolStripMenu";
            this.EditNoteToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.EditNoteToolStripMenu.Text = "Edit Note";
            this.EditNoteToolStripMenu.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenu
            // 
            this.RemoveNoteToolStripMenu.Name = "RemoveNoteToolStripMenu";
            this.RemoveNoteToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.RemoveNoteToolStripMenu.Text = "Remove Note";
            // 
            // HelpToolStripMenu
            // 
            this.HelpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenu});
            this.HelpToolStripMenu.Name = "HelpToolStripMenu";
            this.HelpToolStripMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenu.Text = "Help";
            // 
            // AboutToolStripMenu
            // 
            this.AboutToolStripMenu.Name = "AboutToolStripMenu";
            this.AboutToolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenu.Text = "About";
            this.AboutToolStripMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ChoseNotesComboBox
            // 
            this.ChoseNotesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChoseNotesComboBox.FormattingEnabled = true;
            this.ChoseNotesComboBox.Location = new System.Drawing.Point(91, 27);
            this.ChoseNotesComboBox.Name = "ChoseNotesComboBox";
            this.ChoseNotesComboBox.Size = new System.Drawing.Size(188, 21);
            this.ChoseNotesComboBox.TabIndex = 11;
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(348, 73);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.CreatedDateTimePicker.TabIndex = 12;
            this.CreatedDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(502, 73);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.ModifiedDateTimePicker.TabIndex = 13;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentLabel.ForeColor = System.Drawing.Color.Black;
            this.ContentLabel.Location = new System.Drawing.Point(294, 29);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(286, 20);
            this.ContentLabel.TabIndex = 14;
            this.ContentLabel.Text = "Требования к оформлению кода";
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.BackgroundImage")));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 421);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Padding = new System.Windows.Forms.Padding(40);
            this.AddNoteButton.Size = new System.Drawing.Size(20, 20);
            this.AddNoteButton.TabIndex = 15;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.BackgroundImage")));
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditNoteButton.Location = new System.Drawing.Point(35, 421);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(20, 20);
            this.EditNoteButton.TabIndex = 16;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.BackgroundImage")));
            this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteNoteButton.Location = new System.Drawing.Point(58, 421);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(20, 20);
            this.DeleteNoteButton.TabIndex = 17;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Name = "contextMenuStrip1";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(298, 99);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(490, 342);
            this.NotesTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.ChoseNotesComboBox);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.CategoryAnswerLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.AllNotesListBox);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllNotesListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CategoryAnswerLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenu;
        private System.Windows.Forms.ComboBox ChoseNotesComboBox;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenu;
        private System.Windows.Forms.TextBox NotesTextBox;
    }
}

