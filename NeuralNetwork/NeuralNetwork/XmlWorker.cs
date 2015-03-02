using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NeuralNetwork
{
    /// <summary>
    /// Сериализатор/десериализатор объектов
    /// </summary>
    public class XmlWorker
    {
        /// <summary>
        /// Метод десериализации объектов
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="type">Тип объекта</param>
        /// <returns></returns>
        public Object Deserialize(string fileName, Type type)
        {
            var serializer = new XmlSerializer(type);
            using (var stream = new FileStream(Path.Combine(Application.CommonAppDataPath, fileName), FileMode.Open))
            {
                return serializer.Deserialize(stream);
            }
        }

        /// <summary>
        /// Метод сериализации объектов
        /// </summary>
        /// <param name="obj">Объект, который необходимо сериализовать</param>
        /// <param name="fileName">Имя файла</param>
        /// <param name="type">Тип объекта</param>
        public void Serialize(Object obj, string fileName, Type type)
        {
            //Debug.Print(Application.CommonAppDataPath.ToString());
            var writer = new XmlSerializer(type);
            var file = File.Create(Path.Combine(Application.CommonAppDataPath, fileName));
            writer.Serialize(file, obj);
            file.Close();
        }

    }
}
