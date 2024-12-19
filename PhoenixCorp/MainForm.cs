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
        Functions functions = new Functions();
        public MainForm()
        {
            InitializeComponent();
            if (functions.CreateFile())
                MessageBox.Show("File is created");
            else
                MessageBox.Show("File is existed");
        }
    }
}
