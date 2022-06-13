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

namespace NoteApp
{
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Цвет без ошибки.
        /// </summary>
        private readonly Color _rightColor = Color.White;

        /// <summary>
        /// Цвет с ошибкой.
        /// </summary>
        private readonly Color _wrongColor = Color.LightPink;

        /// <summary>
        /// Заметка.
        /// </summary>
        private Note _note = new Note("", Category.Job, "");

        /// <summary>
        /// Ошибка.
        /// </summary>
        private string _titleError;

        /// <summary>
        /// Создание формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            UpdateForm();
        }

        /// <summary>
        /// Конструктор класса Note.
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }

        /// <summary>
        /// Обновление формы.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Title;
            CategoryComboBox.SelectedItem = _note.Category.ToString();
            MainTextBox.Text = _note.Text;
        }

        /// <summary>
        /// Обновление обьекта.
        /// </summary>
        private void UpdateNote()
        {
            _note.Title = TitleTextBox.Text;
            _note.Category = (Category)Enum.Parse(typeof(Category),
                CategoryComboBox.SelectedValue.ToString());
            _note.Text = MainTextBox.Text;
        }

        /// <summary>
        /// Валидация названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _rightColor;
                _titleError = "";
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _wrongColor;
                _titleError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на наличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if(_titleError != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Кнопка ОК.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormOnErrors();
                UpdateNote();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка ввода");
            }
        }

        /// <summary>
        /// Кнопка Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
