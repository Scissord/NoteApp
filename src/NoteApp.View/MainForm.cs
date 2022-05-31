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
        /// Запуск главного окна.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка главного окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик события для удаления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            RemoveNote(index);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события для изменения заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события Strip Menu для добавления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события Strip Menu для изменения заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события для вызова формы с информацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик события Strip Menu для удаления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            RemoveNote(index);
            UpdateListBox();
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
        /// Обновить выбранную заметку.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateSelectNote(int index)
        {
            NotesTextBox.Text = _project.Notes[index].Text;
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
            var surname = System.IO.Path.GetRandomFileName();
            var surname2 = System.IO.Path.GetRandomFileName();
            Random round = new Random();
            int category = round.Next(0, Enum.GetValues(typeof(Category)).Length);
            _project.Notes.Add(new Note(surname, (Category)category, surname2));
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Завершение программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Обработчик события для добавления заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}
