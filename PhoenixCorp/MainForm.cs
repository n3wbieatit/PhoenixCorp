﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoenixLibrary;

namespace PhoenixCorp
{
    public partial class MainForm : Form
    {
        #region Входные данные

        Functions functions = new Functions();
        // Путь к файлу БД
        string path = "";
        // Коллекция записей
        List<Record> records = new List<Record>();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            path = functions.CreateDefaultFile();
            records = functions.GetInformation(path);
            ShowInfo(records);
        }

        #region Функции главного окна

        /// <summary>
        /// Показать все данные из БД
        /// </summary>
        /// <param name="records">Коллекция записей</param>
        private void ShowInfo(List<Record> records)
        {
            if (path == "" && records.Count == 0)
                rtbDatabaseInformation.Text = "ФАЙЛ НЕ ОТКРЫТ";
            else if (path != "" && records.Count > 0)
                rtbDatabaseInformation.Text = "ОТКРЫТА БАЗА ДАННЫХ: " + path;
            else
            {
                rtbDatabaseInformation.AppendText("Записи отсутствуют! Пожалуйста, добавьте новую запись");
                return;
            }

            rtbDatabaseInformation.AppendText("\n*****************************************\n");

            int i = 1;
            foreach (var rec in records)
            {
                rtbDatabaseInformation.AppendText($"ЗАПИСЬ №{i++}\n");
                rtbDatabaseInformation.AppendText($"ID: {rec.ID}\n");
                rtbDatabaseInformation.AppendText($"НАЗВАНИЕ ПОДРАЗДЕЛЕНИЯ: {rec.Name}\n");
                rtbDatabaseInformation.AppendText($"ГОД: {rec.Year}\n");
                rtbDatabaseInformation.AppendText($"МЕСЯЦ: {rec.Month}\n");
                rtbDatabaseInformation.AppendText($"ДОХОД: {rec.Profit}\n");
                rtbDatabaseInformation.AppendText("--------------------------------------------------------\n");
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "Добавить запись"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (tbAddDepName.Text == "")
            {
                MessageBox.Show("Введите данные в поле \"Название подразделения\"!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Record tempRecord = new Record(tbAddDepName.Text, (int)numUDAddYear.Value,
                (int)numUDAddMonth.Value, (double)numUDAddProfit.Value);

            if (records.Exists(rec => rec.Name == tempRecord.Name &&
                rec.Year == tempRecord.Year && rec.Month == tempRecord.Month))
            {
                MessageBox.Show("Данная запись уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbAddFirst.Checked)
            {
                functions.AddRecord(0, ref records, tempRecord, path);
            }
            else if (rbAddLast.Checked)
            {
                functions.AddRecord(records.Count, ref records, tempRecord, path);
            }
            else if (rbAddNumRec.Checked)
            {
                if ((int)numUDAddNumRec.Value > records.Count)
                {
                    MessageBox.Show("Невозможно добавить запись с данным номером!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                functions.AddRecord((int)numUDAddNumRec.Value - 1, ref records, tempRecord, path);
            }
            ShowInfo(records);
        }

        /// <summary>
        /// Событие нажатия на кнопку "Изменить запись"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRecord_Click(object sender, EventArgs e)
        {
            if (tbChangeDepName.Text == "")
            {
                MessageBox.Show("Введите данные в поле \"Название подразделения\"!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Record tempRecord = new Record(tbChangeDepName.Text, (int)numUDChangeYear.Value,
                (int)numUDChangeMonth.Value, (double)numUDChangeProfit.Value);

            if (rbChangeNumRec.Checked)
            {
                if ((int)numUDChangeNumRec.Value > records.Count)
                {
                    MessageBox.Show("Невозможно изменить запись с данным номером!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int index = (int)numUDChangeNumRec.Value - 1;
                functions.ChangeRecord(index, ref records, path, tempRecord);
            }
            else if (rbChangeID.Checked)
            {
                if (records.Exists(rec => rec.ID == ulong.Parse(tbChangeID.Text)))
                {
                    int index = records.FindIndex(rec => rec.ID == ulong.Parse(tbChangeID.Text));
                    functions.ChangeRecord(index, ref records, path, tempRecord);
                }
                else
                {
                    MessageBox.Show("Невозможно изменить запись с данным ID!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ShowInfo(records);
        }

        /// <summary>
        /// Событие нажатия на кнопку "Удалить запись"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Записи в БД отсутствуют! Невозможно выполнить операцию!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbRemoveNumRec.Checked)
            {
                if ((int)numUDRemoveNumRec.Value > records.Count)
                {
                    MessageBox.Show("Записи с данным номером не существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int index = (int)numUDRemoveNumRec.Value - 1;
                functions.RemoveRecord(index, ref records, path);
                functions.WriteRecord(records, path);
            }
            else if (rbRemoveID.Checked)
            {
                if (records.Exists(rec => rec.ID == ulong.Parse(tbRemoveID.Text)))
                {
                    int index = records.FindIndex(rec => rec.ID == ulong.Parse(tbRemoveID.Text));
                    functions.RemoveRecord(index, ref records, path);
                    functions.WriteRecord(records, path);
                }
                else
                {
                    MessageBox.Show("Записи с данным ID не существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            ShowInfo(records);
        }

        /// <summary>
        /// Выполнение первого задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostProfit_Click(object sender, EventArgs e)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Отсутствуют записи в БД!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormEx formEx = new FormEx("Самые прибыльные годы", "Самые прибыльные годы подразделений:", functions.GetMostYear(records));
            formEx.ShowDialog();
        }

        /// <summary>
        /// Выполнение второго задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorstPeriod_Click(object sender, EventArgs e)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Отсутствуют записи в БД!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double avg = 0;
            string[] result = functions.WorstPeriodsInfo(records, out avg);
            FormEx formEx = new FormEx("Длительные периоды спада", result, avg);
            formEx.ShowDialog();
        }

        /// <summary>
        /// Выполнение третьего задания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinProfit_Click(object sender, EventArgs e)
        {
            if (records.Count == 0)
            {
                MessageBox.Show("Отсутствуют записи в БД!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormEx formEx = new FormEx("Самые худшие годы", "Самые не прибыльные годы подразделений:", functions.GetWorstYear(records));
            formEx.ShowDialog();
        }

        #endregion

        #region Пункты меню

        /// <summary>
        /// Событие действия "Открыть файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "Binary files(*.bin)|*.bin|Text Files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                // Отмена действия
                return;

            path = openFileDialog.FileName;
            records = functions.GetInformation(path);
            ShowInfo(records);
        }

        /// <summary>
        /// Событие действия "Сохранить файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "Binary files(*.bin)|*.bin|Text Files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                // Отмена действия
                return;

            path = saveFileDialog.FileName;
            functions.WriteRecord(records, path);
            ShowInfo(records);
        }

        /// <summary>
        /// Событие действия "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolAbout_Click(object sender, EventArgs e)
        {
            FormAbout dialog = new FormAbout();
            dialog.ShowDialog();
        }

        #endregion

        #region Ввод значений в "числовые" поля

        /// <summary>
        /// Событие ввода в строку изменения записи "По ID:"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbChangeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar.Equals((char)8)) return;
            e.Handled = true;
        }

        /// <summary>
        /// Событие ввода в строку удаления записи "По ID:"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbRemoveID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar.Equals((char)8)) return;
            e.Handled = true;
        }

        #endregion

        #region События выбора радиокнопок

        private void rbAddFirst_CheckedChanged(object sender, EventArgs e)
        {
            numUDAddNumRec.Enabled = false;
        }

        private void rbAddNumRec_CheckedChanged(object sender, EventArgs e)
        {
            numUDAddNumRec.Enabled = true;
        }

        private void rbAddLast_CheckedChanged(object sender, EventArgs e)
        {
            numUDAddNumRec.Enabled = false;
        }


        private void rbChangeNumRec_CheckedChanged(object sender, EventArgs e)
        {
            tbChangeID.Enabled = false;
            numUDChangeNumRec.Enabled = true;
        }

        private void rbChangeID_CheckedChanged(object sender, EventArgs e)
        {
            tbChangeID.Enabled = true;
            numUDChangeNumRec.Enabled = false;
        }


        private void rbRemoveNumRec_CheckedChanged(object sender, EventArgs e)
        {
            numUDRemoveNumRec.Enabled = true;
            tbRemoveID.Enabled = false;
        }

        private void rbRemoveID_CheckedChanged(object sender, EventArgs e)
        {
            numUDRemoveNumRec.Enabled = false;
            tbRemoveID.Enabled = true;
        }

        #endregion
    }
}
