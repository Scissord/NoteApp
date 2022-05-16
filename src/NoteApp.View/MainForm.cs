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

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Закрытое поле типа Project.
        /// </summary>
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            RemoveNote(index);
            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm();
            noteForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
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

        private void UpdateSelectObject(int index)
        {
            NotesTextBox.Text = _project.Notes[index].Text;
        }
        /// <summary>
        /// Генерация новых данных.
        /// </summary>
        private void AddNote()
        {
            var surname = System.IO.Path.GetRandomFileName();
            var surname2 = System.IO.Path.GetRandomFileName();
            Random rnd = new Random();
            int cat = rnd.Next(0, Enum.GetValues(typeof(Category)).Length);
            _project.Notes.Add(new Note(surname, (Category)cat, surname2));
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
                _project.Notes.RemoveAt(index);
            }
        }

        private void AllNotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AllNotesListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            else
            {
                UpdateSelectObject(index);
            }
        }
    }
}
