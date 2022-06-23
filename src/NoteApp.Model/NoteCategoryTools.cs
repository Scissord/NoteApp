using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Словари для категории заметок.
    /// </summary>
    public class NoteCategoryTools
    {
        /// <summary>
        /// Словарь Category - String
        /// </summary>
        public Dictionary<NoteCategory, string> CategoriesByEnum = new Dictionary<NoteCategory, string>
        {
            { NoteCategory.Documents, "Documents" },

            { NoteCategory.Finance, "Finance" },

            { NoteCategory.HealthAndSports, "Health and Sports" },

            { NoteCategory.Home, "Home" },

            { NoteCategory.People, "People" },

            { NoteCategory.Work, "Work" },

            { NoteCategory.Other, "Other" }
        };

        /// <summary>
        /// Словарь String - Category
        /// </summary>
        public Dictionary<string, NoteCategory> CategoriesByString = new Dictionary<string, NoteCategory>
        {
            { "Documents", NoteCategory.Documents },

            { "Finance", NoteCategory.Finance },

            { "Health and Sports", NoteCategory.HealthAndSports },

            { "Home", NoteCategory.Home },

            { "People", NoteCategory.People },

            { "Work", NoteCategory.Work },

            { "Other", NoteCategory.Other }
        };
    }
}
