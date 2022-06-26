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
        private Note _note = new Note();

        /// <summary>
        /// Копия заметки
        /// </summary>
        private Note _noteCopy = new Note();

        /// <summary>
        /// Ошибка.
        /// </summary>
        private string _noteError;

        /// <summary>
        /// Создание формы.
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
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
                if (_note != null)
                {
                    _noteCopy = (Note)_note.Clone();
                }
                else 
                {
                    _noteCopy = new Note();
                }
                UpdateForm();
            }
        }

        /// <summary>
        /// Обновление формы.
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _noteCopy.Title;
            CategoryComboBox.SelectedItem = Enum.GetName(typeof(NoteCategory),
                _noteCopy.Category);
            MainTextBox.Text = _noteCopy.Text;
            CreatedDateTimePicker.Value = _noteCopy.CreatedAt;
            ModifiedDateTimePicker.Value = _noteCopy.ModifiedAt;
        }

        /// <summary>
        /// Обновление обьекта.
        /// </summary>
        private void UpdateNote()
        {
            _noteCopy.Category = (NoteCategory)Enum.Parse(typeof(NoteCategory),
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
            _noteCopy.Title = TitleTextBox.Text;
            _noteCopy.Text = MainTextBox.Text;
        }

        /// <summary>
        /// Валидация названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _rightColor;
                _noteError = "";
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _wrongColor;
                _noteError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на наличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if(_noteError != "")
            {
                MessageBox.Show(_noteError);
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
            if (CheckFormOnErrors())
            {
                UpdateNote();
                _note = _noteCopy;
                DialogResult = DialogResult.OK;
                this.Close();
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

        /// <summary>
        /// Обработчик события для выбора категории.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _noteCopy.Category = (NoteCategory)Enum.Parse(typeof(NoteCategory), 
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedIndex));
        }
    }
}
