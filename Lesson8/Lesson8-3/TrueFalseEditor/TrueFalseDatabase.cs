using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrueFalseEditor
{
    public class TrueFalseDatabase
    {

        #region Private Fields

        private List<Question> list;
        private string fileName;

        #endregion

        #region Public Properties

        /// <summary>
        /// Задать новое имя файла
        /// </summary>
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>
        /// Получить вопрос по индексу
        /// </summary>
        /// <param name="index">Индекс вопроса</param>
        /// <returns>Вопрос</returns>
        public Question this[int index]
        {
            get { return list[index]; }
        }

        /// <summary>
        /// Получить кол-во вопросов
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }


        #endregion

        #region Constructors

        public TrueFalseDatabase(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Добавить новый вопрос в коллекцию
        /// </summary>
        /// <param name="text">Текст вопроса</param>
        /// <param name="trueFalse">Ответ</param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Удалить вопрос по индексу
        /// </summary>
        /// <param name="index">Индекс вопроса</param>
        public void Remove(int index)
        {
            if (index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>
        /// Загрузить вопросы из файла
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
        }

        /// <summary>
        /// Сохранить вопросы в файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, list);
            fileStream.Close();
        }

        #endregion

    }
}
