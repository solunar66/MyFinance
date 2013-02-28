using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MyFinance
{
    public partial class Form_Invest : Form
    {
        DataSet dsCompany = new DataSet();
        DataSet dsProject = new DataSet();
        DataSet dsInvest = new DataSet();
        DataSet dsPartner = new DataSet();

        public Form_Invest()
        {
            InitializeComponent();
        }

        private void Form_Invest_Load(object sender, EventArgs e)
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
            label1.ForeColor = Color.FromName("ControlText");
            label1.Text = "选择公司";
            comboBox_company.Items.Clear();
            comboBox_project.Items.Clear();
            textBox_project.Text = "";
            textBox_contact.Text = "";
            textBox_telephone.Text = "";
            dateTimePicker_start.Value = new DateTime(2000, 01, 01);
            dateTimePicker_end.Value = new DateTime(2100, 12, 31);
            comboBox_cycle.SelectedIndex = 0;
            comboBox_day.SelectedIndex = 0;            
            numericUpDown_volume.Value = 0;
            numericUpDown_yield.Value = 0;
            textBox_comment.Text = "";
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count >= 7) { dataGridView1.Columns.RemoveAt(0); }
            groupBox1.Text = "项目信息";
            groupBox1.ForeColor = Color.FromName("InactiveControl");

            // 取数据库表信息备用
            dsCompany = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Company", "id > 0 order by name desc", 1);
            dsPartner = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Partner", "id > 0 order by name desc", 1);
            dsProject = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Project", "id > 0", 1);
            dsInvest = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Invest", "id > 0", 1);
            if (dsCompany == null || dsProject == null || dsInvest == null || dsPartner == null)
            { MessageBox.Show("数据库表读取错误！"); return; }

            // 填充公司信息
            for (int i = 0; i < dsCompany.Tables[0].Rows.Count; i++)
            {
                comboBox_company.Items.Add(dsCompany.Tables[0].Rows[i]["name"].ToString());
            }

            // 填充投资关系表内股东框
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.HeaderText = "股东";
            ArrayList partners = new ArrayList();
            for (int i = 0; i < dsPartner.Tables[0].Rows.Count; i++)
            {
                partners.Add(new DictionaryEntry(dsPartner.Tables[0].Rows[i]["name"].ToString(), int.Parse(dsPartner.Tables[0].Rows[i]["id"].ToString())));
            }
            column.DataSource = partners;
            column.DisplayMember = "Key";
            column.ValueMember = "Value";
            dataGridView1.Columns.Insert(0, column);
        }

        private void comboBox_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_project.Items.Clear();

            string companyID = dsCompany.Tables[0].Select("name='" + comboBox_company.SelectedItem.ToString() + "'")[0]["id"].ToString();
            DataRow[] projects = dsProject.Tables[0].Select("company=" + companyID, "name DESC");

            for (int i = 0; i < projects.Length; i++)
            {
                comboBox_project.Items.Add(projects[i]["name"].ToString());
            }
        }

        private void comboBox_project_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow project = dsProject.Tables[0].Select("name='" + comboBox_project.SelectedItem.ToString() + "'")[0];

            textBox_project.Text = project["name"].ToString();
            textBox_contact.Text = project["contact"].ToString();
            textBox_telephone.Text = project["telephone"].ToString();
            dateTimePicker_start.Value = DateTime.Parse(project["start_date"].ToString());
            dateTimePicker_end.Value = DateTime.Parse(project["end_date"].ToString());
            int settle_type = int.Parse(project["settle_type"].ToString());
            if (settle_type == 0)
            { checkBox_undefined.Checked = true; }
            else
            {
                checkBox_undefined.Checked = false;
                comboBox_cycle.SelectedIndex = settle_type - 1;
                comboBox_day.SelectedIndex = int.Parse(project["settle_date"].ToString()) - 1;
            }
            numericUpDown_yield.Value = decimal.Parse(project["yield"].ToString())*100;
            textBox_comment.Text = project["comment"].ToString();

            int volume = 0;
            DataRow[] invests = dsInvest.Tables[0].Select("project_id=" + dsProject.Tables[0].Select("name='" + comboBox_project.SelectedItem.ToString() + "'")[0]["id"].ToString());
            dataGridView1.Rows.Clear();
            for (int i = 0; i < invests.Length; i++)
            {
                dataGridView1.Rows.Insert(0, 1);
                DataGridViewRow row = dataGridView1.Rows[0];
                // 记录本行对应的投资关系数据id
                row.Tag = invests[i]["id"].ToString();
                DataRow partner = dsPartner.Tables[0].Select("id=" + invests[i]["partner_id"].ToString())[0];
                row.Cells[0].Value = int.Parse(invests[i]["partner_id"].ToString());
                row.Cells[1].Value = int.Parse(invests[i]["partner_volume"].ToString());
                row.Cells[2].Value = DateTime.Parse(invests[i]["partner_start_date"].ToString()).ToShortDateString();
                row.Cells[3].Value = DateTime.Parse(invests[i]["partner_end_date"].ToString()).ToShortDateString();
                int settletype = int.Parse(partner["settle_type"].ToString());
                if (settletype == 0)
                { row.Cells[4].Value = DataType.Get_SettleType(settletype); }
                else
                { row.Cells[4].Value = DataType.Get_SettleType(settletype) + "的第" + partner["settle_date"].ToString() + "日"; }
                row.Cells[5].Value = (float.Parse(partner["yield"].ToString()) * 100).ToString() + "%";
                row.Cells[6].Value = invests[i]["comment"].ToString();

                volume += int.Parse(invests[i]["partner_volume"].ToString());
            }

            numericUpDown_volume.Value = volume;
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label1.Text = "请选择公司";

            // 清理界面内容
            comboBox_project.Items.Clear();
            textBox_project.Text = "";
            textBox_contact.Text = "";
            textBox_telephone.Text = "";
            dateTimePicker_start.Value = new DateTime(2000, 01, 01);
            dateTimePicker_end.Value = new DateTime(2100, 12, 31);
            checkBox_undefined.Checked = false;
            comboBox_cycle.SelectedIndex = 0;
            comboBox_day.SelectedIndex = 0;
            numericUpDown_volume.Value = 0;
            numericUpDown_yield.Value = 0;
            textBox_comment.Text = "";
            dataGridView1.Rows.Clear();

            groupBox1.Text = "请输入新建投资项目信息";
            groupBox1.ForeColor = Color.Red;
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (groupBox1.ForeColor == Color.Red)
            {
                MessageBox.Show("无法删除未添加的项目！", "删除项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (comboBox_project.SelectedItem == null)
                {
                    MessageBox.Show("请选择要删除的项目！", "删除项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("确认删除项目: " + textBox_project.Text + " ?\n\n( 该项目关联的投资信息也将被一起删除 )", "删除项目", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string projectID = dsProject.Tables[0].Select("name='" + comboBox_project.SelectedItem.ToString() + "'")[0]["id"].ToString();
                        
                        if (Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                                    "project_id=" + projectID, 1) &&
                            Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Project",
                                                    "id=" + projectID, 1))
                        {
                            MessageBox.Show("删除项目成功！", "删除项目成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Invest_Load(this, null);
                        }
                        else
                        { MessageBox.Show("数据库写入异常！", "删除项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // 新建投资项目
            if (groupBox1.ForeColor == Color.Red)
            {
                if (textBox_project.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新项目姓名！", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_project.Select();
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("确认添加新项目: " + textBox_project.Text + " 到 " + comboBox_company.SelectedItem.ToString() + " 公司?", "添加新项目", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (dsProject.Tables[0].Select("name = '" + textBox_project.Text + "'").Length != 0)
                    {
                        MessageBox.Show("已存在同名项目！", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_project.Select();
                        return;
                    }
                    // 保存新项目信息
                    if (Form_Main._Sql.AddRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Project",
                                                "name, company, contact, telephone, start_date, end_date, settle_date, settle_type, yield, comment",
                                                "'" + textBox_project.Text +
                                                "'," + dsCompany.Tables[0].Select("name='" + comboBox_company.SelectedItem.ToString() + "'")[0]["id"].ToString() +
                                                ",'" + textBox_contact.Text +
                                                "','" + textBox_telephone.Text +
                                                "','" + dateTimePicker_start.Value.ToShortDateString() +
                                                "','" + dateTimePicker_end.Value.ToShortDateString() +
                                                "'," + (comboBox_day.SelectedItem == null ? "1" : comboBox_day.SelectedItem.ToString()) +
                                                "," + (checkBox_undefined.Checked ? "0" : (comboBox_cycle.SelectedIndex + 1).ToString()) +
                                                "," + (numericUpDown_yield.Value/100).ToString() +
                                                ",'" + textBox_comment.Text + "'", 1))
                    {
                        // 保存新项目关联的所有投资信息
                        string projectID = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password,
                                            "*", "Table_Project", "name='" + textBox_project.Text + "'", 1).Tables[0].Rows[0]["id"].ToString();
                        string values = "";
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value == null) break;
                            values += row.Cells[0].Value.ToString() +
                                      "," + projectID +
                                      "," + row.Cells[1].Value.ToString() +
                                      ",'" + (row.Cells[2].Value == null ? "2000-01-01":row.Cells[2].Value.ToString()) +
                                      "','" + (row.Cells[3].Value == null ? "2100-12-31" : row.Cells[3].Value.ToString()) +
                                      "','" + (row.Cells[6].Value == null ? "" : row.Cells[6].Value.ToString()) + "'),(";
                        }
                        values = values.Substring(0, values.Length - 3);
                        if (Form_Main._Sql.AddRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                                    "partner_id, project_id, partner_volume, partner_start_date, partner_end_date, comment",
                                                    values, 1))
                        {
                            MessageBox.Show("新项目添加成功！", "添加新项目成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Invest_Load(this, null);
                        }
                        else
                        {
                            MessageBox.Show("数据库写入异常！\n\n保存新项目相关投资信息失败！", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                                    "project_id=" + projectID, 1);
                        }
                    }
                    else
                    { MessageBox.Show("数据库写入异常！\n\n保存新项目信息失败！", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (comboBox_project.SelectedItem != null) // 更新已有项目
            {
                if (DialogResult.Yes == MessageBox.Show("确认更新项目信息:  " + comboBox_project.SelectedItem.ToString() + "  ?", "更新项目信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // 更新项目信息
                    if (Form_Main._Sql.UpdaterDB(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Project",
                                                "name='" + textBox_project.Text +
                                                "',company=" + dsCompany.Tables[0].Select("name='" + comboBox_company.SelectedItem.ToString() + "'")[0]["id"].ToString() +
                                                ",contact='" + textBox_contact.Text +
                                                "',telephone='" + textBox_telephone.Text +
                                                "',start_date='" + dateTimePicker_start.Value.ToShortDateString() +
                                                "',end_date='" + dateTimePicker_end.Value.ToShortDateString() +
                                                "',settle_date=" + (comboBox_day.SelectedItem == null ? "1" : comboBox_day.SelectedItem.ToString()) +
                                                ",settle_type=" + (checkBox_undefined.Checked ? "0" : (comboBox_cycle.SelectedIndex + 1).ToString()) +
                                                ",yield=" + (numericUpDown_yield.Value/100).ToString() +
                                                ",comment='" + textBox_comment.Text + "'",
                                                "name='" + comboBox_project.SelectedItem.ToString() + "'", 1))
                    {
                        // 更新项目关联的所有投资信息
                        string projectID = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password,
                                            "*", "Table_Project", "name='" + textBox_project.Text + "'", 1).Tables[0].Rows[0]["id"].ToString();
                        // 更新投资关系

                        // --- 有对应: 更新记录
                        DataRow[] invests = dsInvest.Tables[0].Select("project_id=" + projectID);
                        foreach (DataRow invest in invests)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                // 找到对应行, 更新记录
                                if ( row.Tag != null && ((string)row.Tag).Equals(invest["id"].ToString()))
                                {
                                    if (!Form_Main._Sql.UpdaterDB(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                        "partner_id=" + row.Cells[0].Value.ToString() + "," +
                                        "project_id=" + projectID + "," +
                                        "partner_volume=" + row.Cells[1].Value.ToString() + "," +
                                        "partner_start_date='" + (row.Cells[2].Value == null ? "2000/01/01":row.Cells[2].Value.ToString()) + "'," +
                                        "partner_end_date='" + (row.Cells[3].Value == null ? "2100/12/31":row.Cells[3].Value.ToString()) + "'," +
                                        "comment='" + row.Cells[6].Value.ToString() + "'",
                                        "id=" + invest["id"].ToString(), 1))
                                    {
                                        MessageBox.Show("数据库写入异常！\n\n保存新项目相关投资信息失败！\n\n(更新投资关系记录失败)", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    // 清除已操作的行
                                    dataGridView1.Rows.Remove(row);
                                    // 清除已操作的记录
                                    invest.Delete();
                                }
                            }
                            // --- 未找到对应行, 删除记录
                            if(invest.RowState != DataRowState.Deleted)
                            {
                                if (!Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                    "id=" + invest["id"].ToString(), 1))
                                {
                                    MessageBox.Show("数据库写入异常！\n\n保存新项目相关投资信息失败！\n\n(删除投资关系记录失败)", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        // --- 未找到对应的已有记录 (新添加投资关系)
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // 新添加的行, 新建记录
                            if ( row.Cells[0].Value != null &&
                                !Form_Main._Sql.AddRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Invest",
                                                "partner_id, project_id, partner_volume, partner_start_date, partner_end_date, comment",
                                                row.Cells[0].Value.ToString() + "," +
                                                projectID + "," +
                                                row.Cells[1].Value.ToString() + ",'" +
                                                (row.Cells[2].Value == null ? "2000/01/01" : row.Cells[2].Value.ToString()) + "','" +
                                                (row.Cells[3].Value == null ? "2100/12/31" : row.Cells[3].Value.ToString()) + "','" +
                                                (row.Cells[6].Value == null ? "" : row.Cells[6].Value.ToString()) + "'", 1))
                            {
                                MessageBox.Show("数据库写入异常！\n\n保存新项目相关投资信息失败！\n\n(新建投资关系记录失败)", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        MessageBox.Show("项目更新成功！", "更新项目成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Invest_Load(this, null);
                    }
                    else
                    { MessageBox.Show("数据库写入异常！\n\n保存新项目信息失败！", "添加新项目错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("请先选择要编辑的项目\n\n要添加新项目，请先点击\"新建项目\"", "保存错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("关闭对话框将丢失未保存的修改, 是否继续关闭？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            this.Close();
        }

        private void 删除本条信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "删除投资关系信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("未选中要删除的信息！", "删除投资关系信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 右键选中当前行
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    //dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:// 股东姓名
                    break;
                case 1:// 股东投资金额
                    try
                    {
                        int volume = int.Parse(e.FormattedValue.ToString());
                        if (volume < 0) throw new Exception("投资金额不能为负数！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("请重新输入股东投资金额！\n\n" + ex.Message, "金额输入不合法", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case 2:// 起始时间
                case 3:// 终止时间
                    try
                    {
                        DateTime.Parse(e.FormattedValue.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("请重新输入日期！\n\n格式应为 YYYY/MM/DD, 例如 2000/12/31", "日期输入不合法", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    break;
                case 4:// 股东付息日
                    break;
                case 5:// 股东回报率
                    break;
                case 6:// 备注
                    break;
                default:
                    break;
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
