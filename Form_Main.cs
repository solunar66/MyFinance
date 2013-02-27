using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CellPaintingDataGridView;
using System.Data.SqlClient;

namespace MyFinance
{
    public partial class Form_Main : Form
    {
        private string ConfigFileName = @"config\config.ini";

        public static string DbHost;
        public static string DbName;
        public static string User;
        public static string Password;

        public static Sql _Sql = new Sql();

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        public Form_Main()
        {
            InitializeComponent();

            dataGridView_day.Rows.Add(5);
            dataGridView_month.Rows.Add(5);

            tabControl_view.SelectedIndex = 1;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString("SqlServer", "Host", "", temp, 255, ConfigFileName);
            DbHost = temp.ToString();
            GetPrivateProfileString("SqlServer", "Database", "", temp, 255, ConfigFileName);
            DbName = temp.ToString();
            GetPrivateProfileString("SqlServer", "User", "", temp, 255, ConfigFileName);
            User = temp.ToString();
            GetPrivateProfileString("SqlServer", "Password", "", temp, 255, ConfigFileName);
            Password = temp.ToString();

            // 验证数据库连接
            if(!_Sql.bOpen(DbHost, DbName, User, Password, 1))
            {
                MessageBox.Show("数据库连接错误 :(\n\n请检查数据库配置，并确保./config/config.ini配置正确", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            dataGridView_year.Rows.Clear();
            dataGridView_year.Rows.Add();
            dataGridView_year.Rows[0].Height = dataGridView_year.Height - 75;
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
                case 4:
                    e.Graphics.DrawString("备注", new Font("宋体", 9), Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 5);
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

        private void dateTimePicker_month_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_lastmonth_Click(object sender, EventArgs e)
        {

        }

        private void button_nextmonth_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_year_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_lastyear_Click(object sender, EventArgs e)
        {

        }

        private void button_nextyear_Click(object sender, EventArgs e)
        {

        }

        private void button_lastdecade_Click(object sender, EventArgs e)
        {

        }

        private void button_nextdecade_Click(object sender, EventArgs e)
        {

        }
    }
}
