using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixLibrary
{
    [Serializable]
    // Класс записи о данных подразделения
    public class Record
    {
        #region Поля

        // ID
        private ulong id;

        // Название подразделения
        private string name;

        // Год, месяц
        private int year, month;

        // Доход
        private double profit;

        // Статус удаления. По умолчанию: false
        private bool isDeleted = false;

        #endregion

        #region Свойства

        public ulong ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2020 && value <= 2024)
                    year = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
            }
        }

        public double Profit
        {
            get { return profit; }
            set
            {
                if (value >= 0)
                    profit = value;
            }
        }

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название подразделения</param>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц</param>
        /// <param name="profit">Доход</param>
        public Record(string name, int year, int month, double profit)
        {
            this.name = name;
            this.year = year;
            this.month = month;
            this.profit = profit;
            id = setID();
        }

        #region Методы

        /// <summary>
        /// Задание ID по времени
        /// </summary>
        /// <returns>Целое число</returns>
        private ulong setID()
        {
            DateTime m = DateTime.Now;
            return (ulong)m.Ticks/1000000000;
        }

        /// <summary>
        /// Метод проверки на наличие записи
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        /// <returns>True or False</returns>
        public bool IsExist(List<Record> records)
        {
            foreach (var rec in records)
            {
                if (rec.Name == this.Name && rec.Year == this.Year && rec.Month == this.Month)
                    return true;
            }
            return false;
        }

        #endregion
    }
}
