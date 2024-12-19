using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixLibrary
{
    public class Functions
    {
        public string defaultPath = "database.bin";
        public Functions() { }

        /// <summary>
        /// Функция создания файла по умолчанию базы данных
        /// </summary>
        public void CreateDefaultFile()
        {
            if (!File.Exists(defaultPath))
                File.Create(defaultPath);
        }

        /// <summary>
        /// Функция получения информации из файла БД
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Коллекцию записей</returns>
        public List<Record> GetInformation(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    return binary.Deserialize(fstream) as List<Record>;
                }
            }
            catch (FileNotFoundException)
            {
                return new List<Record>(0);
            }
        }

        /// <summary>
        /// Функция добавления новой записи
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="depName">Название подразделения</param>
        /// <param name="depYear">Год</param>
        /// <param name="depMonth">Месяц</param>
        /// <param name="depProfit">Доход</param>
        /// <param name="records">Коллекция записей о подразделениях</param>
        /// <returns>Значение true, если элемент temp успешно добавлен,
            /// в противном случае — значение false</returns>
        public bool AddNewRecord(int index, string depName, int depYear,
            int depMonth, double depProfit, ref List<Record> records)
        {
            Record temp = new Record(depName, depYear, depMonth, depProfit);

            if (temp.IsExist(records))
                return false;
            else
            {
                records.Insert(index, temp);
                // Запись последнего добавленного подразделения во временной файл
                using (FileStream fstream = new FileStream("addTemp.bin", FileMode.Create))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    // Запись в файл
                    binary.Serialize(fstream, temp);
                }
                return true;
            }
        }

        /// <summary>
        /// Функция изменения записи по индексу
        /// </summary>
        /// <param name="index">Индекс записи</param>
        /// <param name="depName">Название подразделения</param>
        /// <param name="depYear">Год</param>
        /// <param name="depMonth">Месяц</param>
        /// <param name="depProfit">Доход</param>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Значение true, если элемент temp успешно изменен,
            /// в противном случае — значение false</returns>
        public bool ChangeRecord(int index, string depName, int depYear,
            int depMonth, double depProfit, ref List<Record> records)
        {
            Record temp = new Record(depName, depYear, depMonth, depProfit);

            if (temp.IsExist(records))
            {
                records[index] = temp;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Функция изменения записи по ID
        /// </summary>
        /// <param name="id">ID записи</param>
        /// <param name="depName">Название подразделения</param>
        /// <param name="depYear">Год</param>
        /// <param name="depMonth">Месяц</param>
        /// <param name="depProfit">Доход</param>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Значение true, если элемент temp успешно изменен,
            /// в противном случае — значение false</returns>
        public bool ChangeRecord(ulong id, string depName, int depYear,
            int depMonth, double depProfit, ref List<Record> records)
        {
            Record temp = new Record(depName, depYear, depMonth, depProfit);

            if (temp.IsExist(records))
            {
                for (int i = 0; i < records.Count; i++)
                {
                    if (records[i].ID == id)
                        records[i] = temp;
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Функция удаления записи по индексу
        /// </summary>
        /// <param name="index">Индекс записи</param>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Значение true, если элемент temp успешно удален,
            /// в противном случае — значение false</returns>
        public bool RemoveRecord(int index, ref List<Record> records)
        {
            try
            {
                Record temp = records[index];
                records.RemoveAt(index);
                // Запись удаленных данных в файл
                try
                {
                    using (FileStream fstream = new FileStream("removeTemp.bin", FileMode.CreateNew))
                    {
                        BinaryFormatter binary = new BinaryFormatter();
                        // Запись в файл
                        binary.Serialize(fstream, temp);
                    }
                }
                catch (IOException)
                {
                    using (FileStream fstream = new FileStream("removeTemp.bin", FileMode.Append))
                    {
                        BinaryFormatter binary = new BinaryFormatter();
                        // Запись в файл
                        binary.Serialize(fstream, temp);
                    }
                }
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        /// <summary>
        /// Функция удаления записи по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Значение true, если элемент temp успешно удален,
            /// в противном случае — значение false</returns>
        public bool RemoveRecord(ulong ID, ref List<Record> records)
        {
            try
            {
                Record temp = records.Find(rec => rec.ID == ID);
                records.RemoveAll(rec => rec.ID == ID);
                // Запись удаленных данных в файл
                try
                {
                    using (FileStream fstream = new FileStream("removeTemp.bin", FileMode.CreateNew))
                    {
                        BinaryFormatter binary = new BinaryFormatter();
                        // Запись в файл
                        binary.Serialize(fstream, temp);
                    }
                }
                catch (IOException)
                {
                    using (FileStream fstream = new FileStream("removeTemp.bin", FileMode.Append))
                    {
                        BinaryFormatter binary = new BinaryFormatter();
                        // Запись в файл
                        binary.Serialize(fstream, temp);
                    }
                }
                return true;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        // TODO: сделать функцию
        public Dictionary<string, string> GetMostPeriod(ref List<Record> records)
        {
            // Словарь: "название подразделения: год" -> доход
            Dictionary<string, double> result = new Dictionary<string, double>();

            foreach (var rec in records)
            {
                double sum = 0;
                string name = rec.Name;
                int year = rec.Year;
                foreach (var temp in records)
                {
                    if (name == temp.Name && year == temp.Year)
                        sum += temp.Profit;
                }

                if (!result.ContainsKey($"{name}: {year}"))
                    result.Add($"{name}: {year}", sum);
            }
            
        }
    }
}
