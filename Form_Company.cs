using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFinance
{
    public partial class Form_Company : Form
    {
        DataSet dsCompany = new DataSet();
        DataSet dsProject = new DataSet();
        DataSet dsInvest = new DataSet();

        public Form_Company()
        {
            InitializeComponent();
        }

        private void Form_Company_Load(object sender, EventArgs e)
        {
            dsCompany.Clear();
            dsProject.Clear();
            dsInvest.Clear();
            if (!Form_Main._Sql.bOpen(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, 1))
            {
                MessageBox.Show("数据库连接错误 :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            // 清理界面内容
            comboBox1.Items.Clear();
            textBox_company.Text = "";
            textBox_contact.Text = "";
            textBox_telephone.Text = "";
            numericUpDown_total.Value = 0;
            textBox_comment.Text = "";
            dataGridView1.Rows.Clear();
            groupBox1.Text = "公司信息";
            groupBox1.ForeColor = Color.FromName("InactiveCaption");

            // 取公司信息
            // 按名称降序
            dsCompany = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Company", "id > 0 order by name desc", 1);
            if (dsCompany == null)
            { MessageBox.Show("数据库表Table_Company读取错误！"); return; }
            // 升序加入选项
            for (int i = 0; i < dsCompany.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dsCompany.Tables[0].Rows[i]["name"].ToString());
            }
            // 取投资项备用
            dsProject = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Project", "id > 0", 1);
            if (dsProject == null)
            { MessageBox.Show("数据库表Table_Project读取错误！"); return; }
            // 取投资关系备用
            dsInvest = Form_Main._Sql.GetDataSet(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "*", "Table_Invest", "id > 0", 1);
            if (dsInvest == null)
            { MessageBox.Show("数据库表Table_Invest读取错误！"); return; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 显示公司信息
            DataRow[] company = dsCompany.Tables[0].Select("name = '" + comboBox1.SelectedItem.ToString() + "'");
            textBox_company.Text = company[0]["name"].ToString();
            textBox_contact.Text = company[0]["contact"].ToString();
            textBox_telephone.Text = company[0]["telephone"].ToString();
            numericUpDown_total.Value = 0;
            textBox_comment.Text = company[0]["comment"].ToString();
            
            groupBox1.Text = "[" + company[0]["name"].ToString() + "] 公司信息";
            groupBox1.ForeColor = Color.FromName("InactiveCaption");

            // 根据公司id查找所经营的投资项目信息
            DataRow[] projects = dsProject.Tables[0].Select("company = " + company[0]["id"].ToString());
            if (projects == null)
            { MessageBox.Show("数据库表Table_Project查询错误！"); return; }
            dataGridView1.Rows.Clear();
            if (projects.Length == 0) return;

            dataGridView1.Rows.Add(projects.Length);
            // 显示每个项目信息
            for(int i = 0; i < projects.Length; i++)
            {
                DataRow row = projects[i];
                dataGridView1.Rows[i].Cells[0].Value = row["name"].ToString();
                // 根据项目id查找股东投资信息
                // 计算该项目资金量
                int money = int.Parse(dsInvest.Tables[0].Compute("Sum(partner_volume)", "project_id = " + row["id"].ToString()).ToString());
                dataGridView1.Rows[i].Cells[1].Value = money;
                numericUpDown_total.Value += money;
                // 回报率
                dataGridView1.Rows[i].Cells[2].Value = (float.Parse(row["yield"].ToString()) * 100).ToString() + "%";
                // 结息日
                dataGridView1.Rows[i].Cells[3].Value = DataType.Get_SettleType(int.Parse(row["settle_type"].ToString())) + ":第" + row["settle_date"].ToString() + "日";
                // 时间窗
                dataGridView1.Rows[i].Cells[4].Value = DateTime.Parse(row["start_date"].ToString()).ToShortDateString() + " - " + DateTime.Parse(row["end_date"].ToString()).ToShortDateString();
                // 备注
                dataGridView1.Rows[i].Cells[5].Value = row["comment"].ToString();
                dataGridView1.Rows[i].Cells[5].ToolTipText = row["comment"].ToString();
            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "请输入新公司信息";
            groupBox1.ForeColor = Color.Red;

            comboBox1.Items.Clear();
            textBox_company.Text = "";
            textBox_contact.Text = "";
            textBox_telephone.Text = "";
            numericUpDown_total.Value = 0;
            textBox_comment.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (groupBox1.ForeColor == Color.Red)
            {
                MessageBox.Show("无法删除未添加的公司！", "删除公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("请选择要删除的公司！", "删除公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("确认删除公司: " + textBox_company.Text + " ?", "删除公司", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        // 检查该公司是否有相关投资项目存在
                        // 若有 需先删除所包含的投资项目
                        // 再删除公司
                        if (dataGridView1.Rows.Count > 0)
                        {
                            MessageBox.Show("删除公司失败！\n\n请先删除 " + comboBox1.SelectedItem.ToString() + " 公司所含投资项目!", "删除公司失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Form_Main._Sql.DelRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Company",
                                                    "name='" + comboBox1.SelectedItem.ToString() + "'",
                                                    1))
                        {
                            MessageBox.Show("删除公司成功！", "删除公司成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Company_Load(this, null);
                        }
                        else
                        { MessageBox.Show("数据库写入异常！", "删除公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            // 新建公司
            if (groupBox1.ForeColor == Color.Red)               
            {
                if (textBox_company.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新公司名称！", "添加新公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_company.Select();
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("确认添加新公司: " + textBox_company.Text + " ?", "添加新公司", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        dsCompany.Tables[0].Select("name = " + textBox_company.Text);
                        MessageBox.Show("新公司名称已存在！", "添加新公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_company.Select();
                        return;
                    }
                    catch
                    { }
                    
                    if (Form_Main._Sql.AddRecord(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Company",
                                                "name,contact,telephone,invests,comment",
                                                "'" + textBox_company.Text + "','" + textBox_contact.Text + "','" + textBox_telephone.Text + "','','" + textBox_comment.Text + "'",
                                                1))
                    {
                        MessageBox.Show("新公司添加成功！", "添加新公司成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Company_Load(this, null);
                    }
                    else
                    { MessageBox.Show("数据库写入异常！", "添加新公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (comboBox1.SelectedItem != null) // 更新已有公司
            {
                if (DialogResult.Yes == MessageBox.Show("确认更新公司信息:  " + comboBox1.SelectedItem.ToString() + "  ?", "更新公司信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (Form_Main._Sql.UpdaterDB(Form_Main.DbHost, Form_Main.DbName, Form_Main.User, Form_Main.Password, "Table_Company",
                                                "name='" + textBox_company.Text + "',contact='" + textBox_contact.Text + "',telephone='" + textBox_telephone.Text + "',comment='" + textBox_comment.Text + "'",
                                                "name='" + comboBox1.SelectedItem.ToString() + "'",
                                                1))
                    {
                        MessageBox.Show("" + textBox_company.Text + " 公司信息更新添加成功！", "更新公司成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Company_Load(this, null);
                    }
                    else
                    { MessageBox.Show("数据库写入异常！", "更新公司错误", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("要添加新公司，请先点击\"新建公司\"", "保存错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("关闭对话框将丢失未保存的修改, 是否继续关闭？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;

            this.Close();
        }
    }
}
