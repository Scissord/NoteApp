using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает Заметку.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title = "Без названия";

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private DateTime _createdAt;

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private DateTime _modifiedAt;

        /// <summary>
        /// Возвращает или задает название заметки.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"Title must be less or equals 50 symbols." +
                        $" Please, try again");
                }
                _title = value;
                _modifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает категорию заметки.
        /// </summary>
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                _modifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает текст заметки.
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                _modifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
        }

        /// <summary>
        /// Возвращает время изменения заметки.
        /// </summary>
        public DateTime ModifiedAt
        {
            get
            {
                return _modifiedAt;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Note">
        /// </summary>
        /// <param name="title">Название заметки</param>
        /// <param name="category">Категория заметки</param>
        /// <param name="text">Текст заметки</param>
        public Note(string title, Category category, string text)
        {
            Title = title;
            Category = category;
            Text = text;
            _createdAt = DateTime.Now;
            _modifiedAt = DateTime.Now;
        }
    }
}
