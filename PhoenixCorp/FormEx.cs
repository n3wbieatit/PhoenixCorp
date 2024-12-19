using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixCorp
{
    public partial class FormEx : Form
    {
        public FormEx()
        {
            InitializeComponent();
        }

        // TODO: доработать конструктор
        public FormEx(string title)
        {
            InitializeComponent();
            this.Text = title;
        }
    }
}
