using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CellPaintingDataGridView;

namespace MyFinance
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            dataGridView_day.Rows.Add(4);
            dataGridView_month.Rows.Add(4);

            tabControl_view.SelectedIndex = 1;
        }

        private void button_company_Click(object sender, EventArgs e)
        {
            Form_Company company = new Form_Company();
            company.ShowDialog();
        }

        private void button_partner_Click(object sender, EventArgs e)
        {
            Form_Partner partner = new Form_Partner();
            partner.ShowDialog();
        }

        private void button_invest_Click(object sender, EventArgs e)
        {
            Form_Invest invest = new Form_Invest();
            invest.ShowDialog();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RowHeaderPaint(DataGridViewRowPostPaintEventArgs e)
        {
            switch (e.RowIndex)
            {
                case 0:
                    e.Graphics.DrawString("应收", new Font("宋体", 9), Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 5);
                    break;
                case 1:
                    e.Graphics.DrawString("支出", new Font("宋体", 9), Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 5);
                    break;
                case 2:
                    e.Graphics.DrawString("调整", new Font("宋体", 9), Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 5);
                    break;
                case 3:
                    e.Graphics.DrawString("余额", new Font("宋体", 9), Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 5);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView_month_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            RowHeaderPaint(e);
        }

        private void dataGridView_day_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            RowHeaderPaint(e);
        }
    }
}
