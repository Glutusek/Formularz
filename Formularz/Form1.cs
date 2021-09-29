using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            todayDateTime.Value = DateTime.Now;
            nowTime.Value = DateTime.Now;
        }

        private void todayTimer_Tick(object sender, EventArgs e)
        {
            todayDateTime.Value = DateTime.Now;
            nowTime.Value = DateTime.Now;
        }
    }
}
