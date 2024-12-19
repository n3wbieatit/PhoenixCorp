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
    public partial class MainForm : Form
    {
        Functions functions = new Functions();
        // Путь к файлу БД
        string path = "";

        public MainForm()
        {
            InitializeComponent();
            functions.CreateDefaultFile();   
        }
    }
}
