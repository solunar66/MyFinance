using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFinance
{
    public partial class Form_Partner : Form
    {
        DataSet dsCompany = new DataSet();
        DataSet dsProject = new DataSet();
        DataSet dsInvest = new DataSet();
        DataSet dsPartner = new DataSet();

        public Form_Partner()
        {
            InitializeComponent();
        }

        private void Form_Partner_Load(object sender, EventArgs e)
        {
            dsCompany.Clear();
            dsProject.Clear();
            dsInvest.Clear();
            dsPartner.Clear();
            if (!Form_Main._Sql.bOpen(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, 1))
            {
                MessageBox.Show("数据库连接错误 :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            // 清理界面内容
            comboBox_partner.Items.Clear();
            textBox_partner.Text = "";
            numericUpDown_total.Value = 0;
            dateTimePicker_start.Value = new DateTime(2000, 01, 01);
            dateTimePicker_end.Value = new DateTime(2000, 01, 01);
            numericUpDown_field.Value = 0;
            checkBox_undefined.Checked = false;
            textBox_comment.Text = "";
            groupBox1.Text = "股东信息";
            groupBox1.ForeColor = Color.FromName("InactiveCaption");

            // 取股东信息
            // 按名称降序
            dsPartner = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Partner", "id > 0 order by name desc", 1);
            if (dsPartner == null)
            { MessageBox.Show("数据库表Table_Partner读取错误！"); return; }
            // 升序加入选项
            for (int i = 0; i < dsPartner.Tables[0].Rows.Count; i++)
            {
                comboBox_partner.Items.Add(dsPartner.Tables[0].Rows[i]["name"].ToString());
            }
            // 取公司信息备用
            dsCompany = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Company", "id > 0", 1);
            if (dsCompany == null)
            { MessageBox.Show("数据库表dsCompany读取错误！"); return; }
            // 取投资项备用
            dsProject = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Project", "id > 0", 1);
            if (dsProject == null)
            { MessageBox.Show("数据库表Table_Project读取错误！"); return; }
            // 取投资关系备用
            dsInvest = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Invest", "id > 0", 1);
            if (dsInvest == null)
            { MessageBox.Show("数据库表Table_Invest读取错误！"); return; }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "新建股东信息";
            groupBox1.ForeColor = Color.Red;

            comboBox_partner.Items.Clear();
            textBox_partner.Text = "";
            numericUpDown_total.Value = 0;
            dateTimePicker_start.Value = new DateTime(2000, 01, 01);
            dateTimePicker_end.Value = new DateTime(2000, 01, 01);
            numericUpDown_field.Value = 0;
            checkBox_undefined.Checked = false;
            textBox_comment.Text = "";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // 新建股东
            if (groupBox1.ForeColor == Color.Red)
            {
                if (textBox_partner.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新股东姓名！", "添加新股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_partner.Select();
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("确认添加新股东: " + textBox_partner.Text + " ?", "添加新股东", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        dsPartner.Tables[0].Select("name = " + textBox_partner.Text);
                        MessageBox.Show("已存在同名股东！", "添加新股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_partner.Select();
                        return;
                    }
                    catch
                    { }

                    if (Form_Main._Sql.AddRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Partner",
                                                "name, volume, start_date, end_date, yield, settle_date, settle_type, comment",
                                                "'" + textBox_partner.Text +
                                                "'," + numericUpDown_total.Value.ToString() +
                                                ",'" + dateTimePicker_start.Value.ToShortDateString() +
                                                "','" + dateTimePicker_end.Value.ToShortDateString() +
                                                "'," + (numericUpDown_field.Value/100).ToString() +
                                                "," + (comboBox_day.SelectedItem == null ? "1" : comboBox_day.SelectedItem.ToString()) +
                                                "," + (checkBox_undefined.Checked ? "0" : (comboBox_cycle.SelectedIndex + 1).ToString()) +
                                                ",'" + textBox_comment.Text + "'",
                                                1))
                    {
                        MessageBox.Show("新股东添加成功！", "添加新股东成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Partner_Load(this, null);
                    }
                    else
                    { MessageBox.Show("数据库写入异常！", "添加新股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (comboBox_partner.SelectedItem != null) // 更新已有股东
            {
                if (DialogResult.Yes == MessageBox.Show("确认更新股东信息:  " + comboBox_partner.SelectedItem.ToString() + "  ?", "更新股东信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (Form_Main._Sql.UpdaterDB(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Partner",
                                                "name='" + textBox_partner.Text + "'," +
                                                "volume=" + numericUpDown_total.Value.ToString() + "," +
                                                "start_date='" + dateTimePicker_start.Value.ToShortDateString() + "'," +
                                                "end_date='" + dateTimePicker_end.Value.ToShortDateString() + "'," +
                                                "yield=" + (numericUpDown_field.Value / 100).ToString() + "," +
                                                "settle_date=" + (comboBox_day.SelectedItem == null ? "1" : comboBox_day.SelectedItem.ToString()) + "," +
                                                "settle_type=" + (checkBox_undefined.Checked ? "0" : (comboBox_cycle.SelectedIndex + 1).ToString()) + "," +
                                                "comment='" + textBox_comment.Text + "'",
                                                "name='" + comboBox_partner.SelectedItem.ToString() + "'",
                                                1))
                    {
                        MessageBox.Show("" + textBox_partner.Text + " 股东信息更新添加成功！", "更新股东成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Partner_Load(this, null);
                    }
                    else
                    { MessageBox.Show("数据库写入异常！", "更新股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("要添加新股东，请先点击\"新建股东\"", "保存错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (groupBox1.ForeColor == Color.Red)
            {
                MessageBox.Show("无法删除未添加的股东！", "删除股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (comboBox_partner.SelectedItem == null)
                {
                    MessageBox.Show("请选择要删除的股东！", "删除股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("确认删除股东: " + textBox_partner.Text + " ?", "删除股东", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        // 检查该股东是否有相关投资项目存在
                        // 若有 需先删除所投资的项目
                        // 再删除股东
                        if (dataGridView1.Rows.Count > 0)
                        {
                            MessageBox.Show("删除股东失败！\n\n请先删除 " + comboBox_partner.SelectedItem.ToString() + " 股东所投资的项目!", "删除股东失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Partner",
                                                    "name='" + comboBox_partner.SelectedItem.ToString() + "'",
                                                    1))
                        {
                            MessageBox.Show("删除股东成功！", "删除股东成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Partner_Load(this, null);
                        }
                        else
                        { MessageBox.Show("数据库写入异常！", "删除股东错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("关闭对话框将丢失未保存的修改, 是否继续关闭？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            this.Close();
        }

        private void comboBox_partner_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] partner = dsPartner.Tables[0].Select("name='" + comboBox_partner.SelectedItem.ToString() + "'");
            textBox_partner.Text = partner[0]["name"].ToString();
            numericUpDown_total.Value = int.Parse(partner[0]["volume"].ToString());
            dateTimePicker_start.Value = DateTime.Parse(partner[0]["start_date"].ToString());
            dateTimePicker_end.Value = DateTime.Parse(partner[0]["end_date"].ToString());
            numericUpDown_field.Value = (decimal)float.Parse(partner[0]["yield"].ToString()) * 100;
            int settle_type = int.Parse(partner[0]["settle_type"].ToString());
            if (settle_type == 0)
            { checkBox_undefined.Checked = true; }
            else
            {
                checkBox_undefined.Checked = false;
                comboBox_cycle.SelectedIndex = settle_type - 1;
                comboBox_day.SelectedIndex = int.Parse(partner[0]["settle_date"].ToString()) - 1;
            }
            textBox_comment.Text = partner[0]["comment"].ToString();

            DataRow[] invests = dsInvest.Tables[0].Select("partner_id=" + dsPartner.Tables[0].Select("name='" + textBox_partner.Text + "'")[0]["id"]);
            if (invests == null)
            { MessageBox.Show("数据库表Table_Invest查询错误！"); return; }
            dataGridView1.Rows.Clear();
            if (invests.Length == 0) return;

            dataGridView1.Rows.Add(invests.Length);
            for (int i = 0; i < invests.Length; i++)
            {
                DataRow row = invests[i];
                DataRow project = dsProject.Tables[0].Select("id=" + row["project_id"].ToString())[0];
                DataRow company = dsCompany.Tables[0].Select("id=" + project["company"])[0];
                dataGridView1.Rows[i].Cells[0].Value = project["name"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = company["name"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = (float.Parse(project["yield"].ToString()) * 100).ToString() + "%";
                dataGridView1.Rows[i].Cells[3].Value = row["partner_volume"].ToString() + "万元";
                dataGridView1.Rows[i].Cells[4].Value = row["comment"].ToString();
            }
        }

        private void checkBox_undefined_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_undefined.Checked)
            {
                label9.ForeColor = Color.FromName("InactiveCaption");
                label10.ForeColor = Color.FromName("InactiveCaption");
                label11.ForeColor = Color.FromName("InactiveCaption");
                comboBox_cycle.Enabled = false;
                comboBox_day.Enabled = false;
            }
            else
            {
                label9.ForeColor = Color.FromName("ControlText");
                label10.ForeColor = Color.FromName("ControlText");
                label11.ForeColor = Color.FromName("ControlText");
                comboBox_cycle.Enabled = true;
                comboBox_day.Enabled = true;
            }
        }
    }
}
