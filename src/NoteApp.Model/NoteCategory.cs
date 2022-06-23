using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Перечесление категории заметки.
    /// </summary>
    public enum NoteCategory
    {
        /// <summary>
        /// Категория заметки - Работа.
        /// </summary>
        Work,

        /// <summary>
        /// Категория заметки - Дом.
        /// </summary>
        Home,

        /// <summary>
        /// Категория заметки - Здоровье и спорт.
        /// </summary>
        HealthAndSports,

        /// <summary>
        /// Категория заметки - Люди.
        /// </summary>
        People,

        /// <summary>
        /// Категория заметки - Документы.
        /// </summary>
        Documents,

        /// <summary>
        /// Категория заметки - Финансы.
        /// </summary>
        Finance,

        /// <summary>
        /// Категория Заметки - Другое.
        /// </summary>
        Other
    }
}
