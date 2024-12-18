using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixCorp
{
    [Serializable]
    public class Department
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

        #endregion
    }
}
