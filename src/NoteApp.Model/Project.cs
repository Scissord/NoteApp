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
        
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
