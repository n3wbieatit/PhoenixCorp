using System;
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
    public partial class FormEx : Form
    {
        public FormEx()
        {
            InitializeComponent();
        }

        public FormEx(string title, List<Record> result)
        {
            InitializeComponent();
            this.Text = title;
            rtbEx.AppendText("Прибыльные года подразделений:\n");
            rtbEx.AppendText("---------------------------------\n");
            foreach (var rec in result)
            {
                rtbEx.AppendText($"{rec.Name}: {rec.Year} ({rec.Profit})");
            }
        }

        public FormEx(string title, string[] result, double avg)
        {
            InitializeComponent();
            this.Text = title;
            rtbEx.Text = $"Средний доход всей фирмы за 5 лет = {Math.Round(avg, 2)}\n---------------------------------\n";
            foreach (string rec in result) rtbEx.AppendText(rec + "\n");
        }
    }
}
