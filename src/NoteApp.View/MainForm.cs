using NoteApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Закрытое поле типа Project.
        /// </summary>
        private Project _project = new Project();

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
        /// Обновить выбранную заметку.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateSelectNote(int index)
        {
            Note selectedNote = _project.Notes[index];
            NotesTextBox.Text = selectedNote.Text;
            ContentLabel.Text = selectedNote.Title;
            CategoryAnswerLabel.Text = selectedNote.Category.ToString();
            CreatedDateTimePicker.Value = selectedNote.CreatedAt;
            ModifiedDateTimePicker.Value = selectedNote.ModifiedAt;
        }

        /// <summary>
        /// Очистить выбранную заметку.
        /// </summary>
        private void ClearSelectedNote()
        {
            NotesTextBox.Clear();
        }

        /// <summary>
        /// Генерация новых данных.
        /// </summary>
        private void AddNote()
        {
            var title = System.IO.Path.GetRandomFileName();
            var text = System.IO.Path.GetRandomFileName();
            Random random = new Random();
            int category = random.Next(0, Enum.GetValues(typeof(Category)).Length);
            _project.Notes.Add(new Note(title, (Category)category, text));
        }

        /// <summary>
        /// Удалить выбранную заметку.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show(@"Do you really want to remove" +
                    $"{ _project.Notes[AllNotesListBox.SelectedIndex].Title}", "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    AllNotesListBox.Items.RemoveAt(index);
                    _project.Notes.RemoveAt(index);
                }
            }

        }

        /// <summary>
        /// Изменение выбранной заметки.
        /// </summary>
        private void AllNotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            if (index == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectNote(index);
            }
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult result = MessageBox.Show(@"Do you really want to exit?", "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Запуск главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ChoseNotesComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        /// <summary>
        /// Обработчик события для удаления заметки.
        /// </summary>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            RemoveNote(index);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события для изменения заметки.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события Strip Menu для удаления заметки.
        /// </summary>
        private void RemoveNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            RemoveNote(index);
            UpdateListBox();
        }
        
        /// <summary>
        /// Завершение программы.
        /// </summary>
        private void ExitToolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Обработчик события для добавления заметки.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события Strip Menu для добавления заметки.
        /// </summary>
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события Strip Menu для изменения заметки.
        /// </summary>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
