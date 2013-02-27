namespace MyFinance
{
    partial class Form_Invest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_undefined = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除本条信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.comboBox_cycle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_yield = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_volume = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_project = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.comboBox_company = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_project = new System.Windows.Forms.ComboBox();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_undefined);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox_day);
            this.groupBox1.Controls.Add(this.comboBox_cycle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker_end);
            this.groupBox1.Controls.Add(this.dateTimePicker_start);
            this.groupBox1.Controls.Add(this.numericUpDown_yield);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_volume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_telephone);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_comment);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_contact);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_project);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 431);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目信息";
            // 
            // checkBox_undefined
            // 
            this.checkBox_undefined.AutoSize = true;
            this.checkBox_undefined.Location = new System.Drawing.Point(425, 123);
            this.checkBox_undefined.Name = "checkBox_undefined";
            this.checkBox_undefined.Size = new System.Drawing.Size(84, 16);
            this.checkBox_undefined.TabIndex = 15;
            this.checkBox_undefined.Text = "不定期付息";
            this.checkBox_undefined.UseVisualStyleBackColor = true;
            this.checkBox_undefined.CheckedChanged += new System.EventHandler(this.checkBox_undefined_CheckedChanged);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(9, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(595, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "编 辑 股 东 投 资 关 系 ：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column5,
            this.Column7,
            this.Column4,
            this.Column3,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(595, 195);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Column2
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "本项目所投资金(万)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.NullValue = "2000-01-01";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "起始时间";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            dataGridViewCellStyle3.NullValue = "2100-12-31";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "终止时间";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "股东付息日";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "股东回报率";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除本条信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // 删除本条信息ToolStripMenuItem
            // 
            this.删除本条信息ToolStripMenuItem.Name = "删除本条信息ToolStripMenuItem";
            this.删除本条信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除本条信息ToolStripMenuItem.Text = "删除本条信息";
            this.删除本条信息ToolStripMenuItem.Click += new System.EventHandler(this.删除本条信息ToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(287, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "的第";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(385, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "日";
            // 
            // comboBox_day
            // 
            this.comboBox_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_day.Location = new System.Drawing.Point(321, 121);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(60, 20);
            this.comboBox_day.TabIndex = 9;
            // 
            // comboBox_cycle
            // 
            this.comboBox_cycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cycle.FormattingEnabled = true;
            this.comboBox_cycle.Items.AddRange(new object[] {
            "月",
            "季度",
            "半年",
            "年"});
            this.comboBox_cycle.Location = new System.Drawing.Point(221, 121);
            this.comboBox_cycle.Name = "comboBox_cycle";
            this.comboBox_cycle.Size = new System.Drawing.Size(60, 20);
            this.comboBox_cycle.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(42, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "付息日: 自使用周期开始起，每";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(422, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(205, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "万元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(212, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(30, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "资金周期:";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(249, 89);
            this.dateTimePicker_end.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_end.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker_end.TabIndex = 3;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(89, 89);
            this.dateTimePicker_start.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker_start.TabIndex = 3;
            // 
            // numericUpDown_yield
            // 
            this.numericUpDown_yield.Location = new System.Drawing.Point(321, 155);
            this.numericUpDown_yield.Name = "numericUpDown_yield";
            this.numericUpDown_yield.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_yield.TabIndex = 2;
            this.numericUpDown_yield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(246, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "协议回报率:";
            // 
            // numericUpDown_volume
            // 
            this.numericUpDown_volume.Enabled = false;
            this.numericUpDown_volume.Location = new System.Drawing.Point(89, 155);
            this.numericUpDown_volume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_volume.Name = "numericUpDown_volume";
            this.numericUpDown_volume.Size = new System.Drawing.Size(110, 21);
            this.numericUpDown_volume.TabIndex = 2;
            this.numericUpDown_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "总金额:";
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(249, 56);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(110, 21);
            this.textBox_telephone.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(212, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "电话:";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(89, 188);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(473, 21);
            this.textBox_comment.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(42, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "备注:";
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(89, 56);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(110, 21);
            this.textBox_contact.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(42, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "联系人:";
            // 
            // textBox_project
            // 
            this.textBox_project.Location = new System.Drawing.Point(89, 24);
            this.textBox_project.Name = "textBox_project";
            this.textBox_project.Size = new System.Drawing.Size(110, 21);
            this.textBox_project.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "项目名称:";
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(522, 474);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(100, 35);
            this.button_quit.TabIndex = 6;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // comboBox_company
            // 
            this.comboBox_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_company.FormattingEnabled = true;
            this.comboBox_company.Location = new System.Drawing.Point(76, 12);
            this.comboBox_company.Name = "comboBox_company";
            this.comboBox_company.Size = new System.Drawing.Size(124, 20);
            this.comboBox_company.TabIndex = 7;
            this.comboBox_company.SelectedIndexChanged += new System.EventHandler(this.comboBox_company_SelectedIndexChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(416, 474);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 35);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保 存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "选择公司";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "选择项目";
            // 
            // comboBox_project
            // 
            this.comboBox_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_project.FormattingEnabled = true;
            this.comboBox_project.Location = new System.Drawing.Point(275, 12);
            this.comboBox_project.Name = "comboBox_project";
            this.comboBox_project.Size = new System.Drawing.Size(124, 20);
            this.comboBox_project.TabIndex = 7;
            this.comboBox_project.SelectedIndexChanged += new System.EventHandler(this.comboBox_project_SelectedIndexChanged);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(11, 474);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(100, 35);
            this.button_New.TabIndex = 5;
            this.button_New.Text = "新建项目";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(122, 474);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(100, 35);
            this.button_Del.TabIndex = 5;
            this.button_Del.Text = "删除项目";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // Form_Invest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.comboBox_project);
            this.Controls.Add(this.comboBox_company);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Invest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑投资项目";
            this.Load += new System.EventHandler(this.Form_Invest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.ComboBox comboBox_cycle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_yield;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_project;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.ComboBox comboBox_company;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_volume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_project;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除本条信息ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox checkBox_undefined;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label13;

    }
}