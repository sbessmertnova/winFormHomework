using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            get {
                if (index>0&&index<list.Count)
                {
                    return list[index];
                }
                else
                {
                    MessageBox.Show($"Вы пытаетесь получить {index+1} элемент из массива, состоящего из {list.Count} элементов", "Получение вопроса по индексу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        /// <summary>
        /// получить список вопросов
        /// </summary>
        public List<Question> Questions
        {
            get => list;
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
        public TrueFalseDatabase(string fileName, List<Question> list)
        {
            this.fileName = fileName;
            this.list = list;
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
            var info = new FileInfo(fileName);
            if (info.Length> 1e+8)
            {
                MessageBox.Show("Файл не должен превышать 100мб", "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
