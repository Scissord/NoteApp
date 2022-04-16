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
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private string _category;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private string _timeOfCreation;

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private string _lastModifiedTime;

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
                    throw new ArgumentException($"Title must be less or equals 50 symbols. Please, try again");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает или задает категорию заметки.
        /// </summary>
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
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
                _category = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Note">
        /// </summary>
        /// <param name="title">Название заметки</param>
        /// <param name="category">Категория заметки</param>
        /// <param name="text">Текст заметки</param>
        public Note(string title, string category, string text)
        {
            Title = title;
            Category = category;
            Text = text;
        }
    }
}
