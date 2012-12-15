using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFinance
{
    public partial class Form_Invest : Form
    {
        public Form_Invest()
        {
            InitializeComponent();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
