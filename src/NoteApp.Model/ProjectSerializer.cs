using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс, реализующий сохранение в файл и загрузку проекта из файла.
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Путь к папке с сохраненными заметками.
        /// </summary>
        private static readonly string _path = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + "\\knm\\NoteApp";

        /// <summary>
        /// Экземпляр класса потока.
        /// </summary>
        private Stream _stream;

        /// <summary>
        /// Путь до файла userdata.json.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Сохраняет данные из экземпляра класса в userdata.json.
        /// </summary>
        /// <param name="project">Сохранённый экземпляр класса Project.</param>
        public void SaveToFile(Project project)
        {
            if (!(Directory.Exists(_path)))
            {
                Directory.CreateDirectory(_path);
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
            }
            JsonSerializer serializer = new JsonSerializer();
            using (_stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StreamWriter myWriter = new StreamWriter(_stream);
                using (JsonWriter writer = new JsonTextWriter(myWriter))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }
        
        /// <summary>
        /// Загружает данные из userdata.json в экземпляр класса Project.
        /// </summary>
        /// <returns>Инициализованный экземпляр класса Project.</returns>
        public Project LoadFromFile()
        {
            Project project = null;
            if (!(Directory.Exists(_path)))
            {
                Directory.CreateDirectory(_path);
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
            }
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                using (_stream = File.Open(@FileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    StreamReader myReader = new StreamReader(_stream);
                    using (JsonReader reader = new JsonTextReader(myReader))
                    {
                        project = (Project)serializer.Deserialize(reader, typeof(Project));
                    }
                }
            }
            catch
            {
                project = new Project();
            }
            if (project == null)
            {
                project = new Project();
            }
            return project;
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="ProjectSerializer">
        /// </summary>
        public ProjectSerializer()
        {
            FileName = _path + "\\notes.json";
        }
    }
}
