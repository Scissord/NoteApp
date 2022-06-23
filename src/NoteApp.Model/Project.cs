using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Содержит список всех заметок.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задаёт заметку.
        /// </summary>
        public List<Note> Notes { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Сортировка всех заметок по убыванию.
        /// </summary>
        /// <param name="notes">Список заметок</param>
        /// <returns></returns>
        public List<Note> SortByModificationTime(List<Note> notes)
        {
            notes = notes.OrderByDescending(note 
                => note.ModifiedAt).ToList();
            return notes;
        }

        /// <summary>
        /// Выборка заметок по категории.
        /// </summary>
        /// <param name="notes">Список заметок</param>
        /// <param name="noteCategory">Категория заметки</param>
        /// <returns></returns>
        public List<Note> SearchByCategory(List<Note> notes, NoteCategory noteCategory)
        {
            notes = Notes.Where(note 
                => note.Category == noteCategory).ToList();
            return notes;
        }
    }
}
