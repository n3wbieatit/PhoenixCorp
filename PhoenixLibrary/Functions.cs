using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
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
        public string CreateDefaultFile()
        {
            try
            {
                using (FileStream fstream = new FileStream(defaultPath, FileMode.CreateNew))
                {
                    FileInfo info = new FileInfo(defaultPath);
                    defaultPath = info.FullName;
                }
            }
            catch (IOException)
            {
                FileInfo info = new FileInfo(defaultPath);
                defaultPath = info.FullName;
            }
            return defaultPath;
        }

        /// <summary>
        /// Функция получения информации из файла БД
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Коллекция записей</returns>
        public List<Record> GetInformation(string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    try
                    {
                        return binary.Deserialize(fstream) as List<Record>;
                    }
                    catch (SerializationException)
                    {
                        return new List<Record>(0);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return new List<Record>(0);
            }
        }

        /// <summary>
        /// Функция добавления записи в БД
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <param name="path">Путь к файлу БД</param>
        public void WriteRecord(List<Record> records, string path)
        {
            try
            {
                using (FileStream fstream = new FileStream(path, FileMode.CreateNew))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    binary.Serialize(fstream, records);
                }
            }
            catch (IOException)
            {
                using (FileStream fstream = new FileStream(path, FileMode.Truncate))
                {
                    BinaryFormatter binary = new BinaryFormatter();
                    binary.Serialize(fstream, records);
                }
            }
        }

        /// <summary>
        /// Функция добавления новой записи в БД
        /// </summary>
        /// <param name="index">Индекс добавления</param>
        /// <param name="records">Коллекция записей</param>
        /// <param name="temp">Временная запись</param>
        /// <param name="path">Путь к БД</param>
        public void AddRecord(int index, ref List<Record> records, Record temp, string path)
        {
            records.Insert(index, temp);
            WriteRecord(records, path);
        }

        /// <summary>
        /// Функция изменения записи
        /// </summary>
        /// <param name="index">Индекс записи</param>
        /// <param name="records">Коллекция записей</param>
        /// <param name="path">Путь к файлу БД</param>
        /// <param name="temp">Временная запись</param>
        public void ChangeRecord(int index, ref List<Record> records, string path, Record temp)
        {
            records[index] = temp;
            WriteRecord(records, path);
        }

        /// <summary>
        /// Функция удаления записи по индексу
        /// </summary>
        /// <param name="index">Индекс записи</param>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Значение true, если элемент temp успешно удален,
        /// в противном случае — значение false</returns>
        public void RemoveRecord(int index, ref List<Record> records, string path)
        {
            records.RemoveAt(index);
            WriteRecord(records, path);
        }

        /// <summary>
        /// Функция отбора у подразделений самых доходных годов
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Коллекция</returns>
        public List<Record> GetMostYear(List<Record> records)
        {
            // Коллекция суммарных доходов подразделений за каждый год
            List<Record> allYears = new List<Record>();
            foreach (var rec in records)
            {
                Record temp = new Record(rec.Name, rec.Year, rec.Month, 0);
                temp.ID = rec.ID;
                foreach (var item in records)
                {
                    if (temp.Name == item.Name && temp.Year == item.Year)
                        temp.Profit += item.Profit;
                }
                if (!allYears.Contains(temp))
                    allYears.Add(temp);
            }
            List<Record> result = new List<Record>();
            // Фильтрация
            foreach (var record in allYears)
            {
                foreach (var item in allYears)
                {
                    if (record.Name == item.Name)
                    {
                        if (record.Profit > item.Profit)
                        {
                            if (!result.Exists(rec => rec.Name == record.Name))
                                result.Add(record);
                            else
                                result[result.Count - 1] = record;
                        }
                        else
                        {
                            if (!result.Exists(rec => rec.Name == item.Name))
                                result.Add(item);
                            else
                            {
                                if (result[result.Count - 1].Profit < item.Profit)
                                    result[result.Count - 1] = item;
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Функция отбора у подразделений самых доходных годов
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Коллекция</returns>
        public List<Record> GetWorstYear(List<Record> records)
        {
            // Коллекция суммарных доходов подразделений за каждый год
            List<Record> allYears = new List<Record>();
            foreach (var rec in records)
            {
                Record temp = new Record(rec.Name, rec.Year, rec.Month, 0);
                temp.ID = rec.ID;
                foreach (var item in records)
                {
                    if (temp.Name == item.Name && temp.Year == item.Year)
                        temp.Profit += item.Profit;
                }
                if (!allYears.Contains(temp))
                    allYears.Add(temp);
            }
            List<Record> result = new List<Record>();
            // Фильтрация
            foreach (var record in allYears)
            {
                foreach (var item in allYears)
                {
                    if (record.Name == item.Name)
                    {
                        if (record.Profit < item.Profit)
                        {
                            if (!result.Exists(rec => rec.Name == record.Name))
                                result.Add(record);
                            else
                                result[result.Count - 1] = record;
                        }
                        else
                        {
                            if (!result.Exists(rec => rec.Name == item.Name))
                                result.Add(item);
                            else
                            {
                                if (result[result.Count - 1].Profit > item.Profit)
                                    result[result.Count - 1] = item;
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Функция расчета наиболее длинного периода, когда средний доход подразделения был ниже среднего дохода всей фирмы
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <param name="av">Средний доход</param>
        /// <returns>Массив строк</returns>
        public string[] WorstPeriodsInfo(List<Record> records, out double avg)
        {
            int i = 0;
            string[] allTitles = GetAllNames(records);
            string[] result = new string[allTitles.Length];
            avg = TotalAverage(records);
            foreach (string depName in allTitles)
            {
                double[] profit = DepProfit(records, depName);
                int start, finish;
                double min = -1;
                int[] period = { -1, -1 };
                for (start = 0; start < 60; start++)
                {
                    double sum = 0;
                    double tmp = -1;
                    for (finish = start; finish < 60; finish++)
                    {
                        sum += profit[finish];
                        tmp = sum / (finish - start + 1);
                        if (period[1] - period[0] <= finish - start || min == -1)
                        {
                            if (tmp < avg)
                            {
                                period[0] = start;
                                period[1] = finish;
                                min = tmp;
                            }
                        }
                    }
                    if (59 - start < period[1] - period[0] + 1) break;
                }
                if (min == -1)
                    result[i++] = depName + ": средний доход отделения всегда больше среднего дохода всей фирмы";
                else
                    result[i++] = depName + $": {(period[0] % 12) + 1}.{period[0] / 12 + 2020} " +
                        $"- {(period[1] % 12) + 1}.{period[1] / 12 + 2020} (средний доход: {Math.Round(min, 2)})";
            }
            return result;
        }

        /// <summary>
        /// Функция получения всех названий подразделений
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Массив названий</returns>
        private string[] GetAllNames(List<Record> records)
        {
            string[] result = new string[0];
            bool[] check = new bool[records.Count];
            for (int i = 0; i < records.Count; i++)
            {
                if (check[i]) continue;
                for (int j = 0; j < records.Count; j++)
                {
                    if (records[i].Name == records[j].Name)
                        check[j] = true;
                }
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = records[i].Name;
            }
            return result;
        }

        /// <summary>
        /// Функция расчета среднего дохода всей фирмы за 5 лет (60 месяцев)
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <returns>Средний доход</returns>
        private double TotalAverage(List<Record> records)
        {
            double total = 0;
            foreach (var rec in records)
                total += rec.Profit;
            return total / 60;
        }

        /// <summary>
        /// Функция расчета дохода подразделения за 5 лет (60 месяцев) по месяцам
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <param name="depName">Название подразделения</param>
        /// <returns>Массив доходов</returns>
        private double[] DepProfit(List<Record> records, string depName)
        {
            double[] result = new double[60];
            foreach (var rec in records)
                if (rec.Name == depName)
                    result[(rec.Year - 2019) * rec.Month - 1] = rec.Profit;
            return result;
        }
    }
}
