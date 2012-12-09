namespace MyFinance
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_invest = new System.Windows.Forms.Button();
            this.button_partner = new System.Windows.Forms.Button();
            this.button_adjust = new System.Windows.Forms.Button();
            this.tabPage_day = new System.Windows.Forms.TabPage();
            this.dateTimePicker_month = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_day = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_nextmonth = new System.Windows.Forms.Button();
            this.button_lastmonth = new System.Windows.Forms.Button();
            this.tabPage_year = new System.Windows.Forms.TabPage();
            this.dataGridView_year = new System.Windows.Forms.DataGridView();
            this.Column44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_month = new System.Windows.Forms.TabPage();
            this.dateTimePicker_year = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_month = new System.Windows.Forms.DataGridView();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_nextyear = new System.Windows.Forms.Button();
            this.button_lastyear = new System.Windows.Forms.Button();
            this.tabControl_view = new System.Windows.Forms.TabControl();
            this.tabPage_day.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_day)).BeginInit();
            this.tabPage_year.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_year)).BeginInit();
            this.tabPage_month.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).BeginInit();
            this.tabControl_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_invest
            // 
            this.button_invest.Location = new System.Drawing.Point(216, 627);
            this.button_invest.Name = "button_invest";
            this.button_invest.Size = new System.Drawing.Size(100, 30);
            this.button_invest.TabIndex = 6;
            this.button_invest.Text = "编辑投资";
            this.button_invest.UseVisualStyleBackColor = true;
            this.button_invest.Click += new System.EventHandler(this.button_invest_Click);
            // 
            // button_partner
            // 
            this.button_partner.Location = new System.Drawing.Point(110, 627);
            this.button_partner.Name = "button_partner";
            this.button_partner.Size = new System.Drawing.Size(100, 30);
            this.button_partner.TabIndex = 5;
            this.button_partner.Text = "编辑股东";
            this.button_partner.UseVisualStyleBackColor = true;
            this.button_partner.Click += new System.EventHandler(this.button_partner_Click);
            // 
            // button_adjust
            // 
            this.button_adjust.Location = new System.Drawing.Point(4, 627);
            this.button_adjust.Name = "button_adjust";
            this.button_adjust.Size = new System.Drawing.Size(100, 30);
            this.button_adjust.TabIndex = 4;
            this.button_adjust.Text = "调整资金";
            this.button_adjust.UseVisualStyleBackColor = true;
            this.button_adjust.Click += new System.EventHandler(this.button_adjust_Click);
            // 
            // tabPage_day
            // 
            this.tabPage_day.Controls.Add(this.dateTimePicker_month);
            this.tabPage_day.Controls.Add(this.dataGridView_day);
            this.tabPage_day.Controls.Add(this.button_nextmonth);
            this.tabPage_day.Controls.Add(this.button_lastmonth);
            this.tabPage_day.Location = new System.Drawing.Point(4, 25);
            this.tabPage_day.Name = "tabPage_day";
            this.tabPage_day.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_day.Size = new System.Drawing.Size(1096, 592);
            this.tabPage_day.TabIndex = 3;
            this.tabPage_day.Text = "日视图";
            this.tabPage_day.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_month
            // 
            this.dateTimePicker_month.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_month.CustomFormat = "yyyy年MM月";
            this.dateTimePicker_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_month.Location = new System.Drawing.Point(498, 8);
            this.dateTimePicker_month.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_month.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_month.Name = "dateTimePicker_month";
            this.dateTimePicker_month.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_month.TabIndex = 5;
            // 
            // dataGridView_day
            // 
            this.dataGridView_day.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_day.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31});
            this.dataGridView_day.Location = new System.Drawing.Point(6, 33);
            this.dataGridView_day.Name = "dataGridView_day";
            this.dataGridView_day.RowTemplate.Height = 23;
            this.dataGridView_day.Size = new System.Drawing.Size(1082, 553);
            this.dataGridView_day.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1日";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2日";
            this.Column2.Name = "Column2";
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3日";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4日";
            this.Column4.Name = "Column4";
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5日";
            this.Column5.Name = "Column5";
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6日";
            this.Column6.Name = "Column6";
            this.Column6.Width = 30;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7日";
            this.Column7.Name = "Column7";
            this.Column7.Width = 30;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8日";
            this.Column8.Name = "Column8";
            this.Column8.Width = 30;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9日";
            this.Column9.Name = "Column9";
            this.Column9.Width = 30;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10日";
            this.Column10.Name = "Column10";
            this.Column10.Width = 35;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "11日";
            this.Column11.Name = "Column11";
            this.Column11.Width = 35;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "12日";
            this.Column12.Name = "Column12";
            this.Column12.Width = 35;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "13日";
            this.Column13.Name = "Column13";
            this.Column13.Width = 35;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "14日";
            this.Column14.Name = "Column14";
            this.Column14.Width = 35;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "15日";
            this.Column15.Name = "Column15";
            this.Column15.Width = 35;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "16日";
            this.Column16.Name = "Column16";
            this.Column16.Width = 35;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "17日";
            this.Column17.Name = "Column17";
            this.Column17.Width = 35;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "18日";
            this.Column18.Name = "Column18";
            this.Column18.Width = 35;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "19日";
            this.Column19.Name = "Column19";
            this.Column19.Width = 35;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20日";
            this.Column20.Name = "Column20";
            this.Column20.Width = 35;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "21日";
            this.Column21.Name = "Column21";
            this.Column21.Width = 35;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "22日";
            this.Column22.Name = "Column22";
            this.Column22.Width = 35;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "23日";
            this.Column23.Name = "Column23";
            this.Column23.Width = 35;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "24日";
            this.Column24.Name = "Column24";
            this.Column24.Width = 35;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "25日";
            this.Column25.Name = "Column25";
            this.Column25.Width = 35;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "26日";
            this.Column26.Name = "Column26";
            this.Column26.Width = 35;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "27日";
            this.Column27.Name = "Column27";
            this.Column27.Width = 35;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "28日";
            this.Column28.Name = "Column28";
            this.Column28.Width = 35;
            // 
            // Column29
            // 
            this.Column29.HeaderText = "29日";
            this.Column29.Name = "Column29";
            this.Column29.Width = 35;
            // 
            // Column30
            // 
            this.Column30.HeaderText = "30日";
            this.Column30.Name = "Column30";
            this.Column30.Width = 35;
            // 
            // Column31
            // 
            this.Column31.HeaderText = "31日";
            this.Column31.Name = "Column31";
            this.Column31.Width = 35;
            // 
            // button_nextmonth
            // 
            this.button_nextmonth.Location = new System.Drawing.Point(988, 6);
            this.button_nextmonth.Name = "button_nextmonth";
            this.button_nextmonth.Size = new System.Drawing.Size(100, 23);
            this.button_nextmonth.TabIndex = 1;
            this.button_nextmonth.Text = "下一月 >>";
            this.button_nextmonth.UseVisualStyleBackColor = true;
            // 
            // button_lastmonth
            // 
            this.button_lastmonth.Location = new System.Drawing.Point(4, 6);
            this.button_lastmonth.Name = "button_lastmonth";
            this.button_lastmonth.Size = new System.Drawing.Size(100, 23);
            this.button_lastmonth.TabIndex = 1;
            this.button_lastmonth.Text = "<< 上一月";
            this.button_lastmonth.UseVisualStyleBackColor = true;
            // 
            // tabPage_year
            // 
            this.tabPage_year.Controls.Add(this.dataGridView_year);
            this.tabPage_year.Location = new System.Drawing.Point(4, 25);
            this.tabPage_year.Name = "tabPage_year";
            this.tabPage_year.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_year.Size = new System.Drawing.Size(1096, 592);
            this.tabPage_year.TabIndex = 1;
            this.tabPage_year.Text = "年视图";
            this.tabPage_year.UseVisualStyleBackColor = true;
            // 
            // dataGridView_year
            // 
            this.dataGridView_year.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_year.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column44});
            this.dataGridView_year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_year.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_year.Name = "dataGridView_year";
            this.dataGridView_year.RowTemplate.Height = 23;
            this.dataGridView_year.Size = new System.Drawing.Size(1090, 586);
            this.dataGridView_year.TabIndex = 0;
            // 
            // Column44
            // 
            this.Column44.HeaderText = "2012年";
            this.Column44.Name = "Column44";
            // 
            // tabPage_month
            // 
            this.tabPage_month.Controls.Add(this.dateTimePicker_year);
            this.tabPage_month.Controls.Add(this.dataGridView_month);
            this.tabPage_month.Controls.Add(this.button_nextyear);
            this.tabPage_month.Controls.Add(this.button_lastyear);
            this.tabPage_month.Location = new System.Drawing.Point(4, 25);
            this.tabPage_month.Name = "tabPage_month";
            this.tabPage_month.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_month.Size = new System.Drawing.Size(1096, 592);
            this.tabPage_month.TabIndex = 0;
            this.tabPage_month.Text = "月视图";
            this.tabPage_month.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_year
            // 
            this.dateTimePicker_year.CustomFormat = "yyyy年";
            this.dateTimePicker_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_year.Location = new System.Drawing.Point(511, 8);
            this.dateTimePicker_year.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_year.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_year.Name = "dateTimePicker_year";
            this.dateTimePicker_year.Size = new System.Drawing.Size(75, 21);
            this.dateTimePicker_year.TabIndex = 5;
            // 
            // dataGridView_month
            // 
            this.dataGridView_month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_month.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36,
            this.Column37,
            this.Column38,
            this.Column39,
            this.Column40,
            this.Column41,
            this.Column42,
            this.Column43});
            this.dataGridView_month.Location = new System.Drawing.Point(6, 33);
            this.dataGridView_month.Name = "dataGridView_month";
            this.dataGridView_month.RowTemplate.Height = 23;
            this.dataGridView_month.Size = new System.Drawing.Size(1082, 553);
            this.dataGridView_month.TabIndex = 4;
            // 
            // Column32
            // 
            this.Column32.HeaderText = "1月";
            this.Column32.Name = "Column32";
            this.Column32.Width = 85;
            // 
            // Column33
            // 
            this.Column33.HeaderText = "2月";
            this.Column33.Name = "Column33";
            this.Column33.Width = 85;
            // 
            // Column34
            // 
            this.Column34.HeaderText = "3月";
            this.Column34.Name = "Column34";
            this.Column34.Width = 85;
            // 
            // Column35
            // 
            this.Column35.HeaderText = "4月";
            this.Column35.Name = "Column35";
            this.Column35.Width = 85;
            // 
            // Column36
            // 
            this.Column36.HeaderText = "5月";
            this.Column36.Name = "Column36";
            this.Column36.Width = 85;
            // 
            // Column37
            // 
            this.Column37.HeaderText = "6月";
            this.Column37.Name = "Column37";
            this.Column37.Width = 85;
            // 
            // Column38
            // 
            this.Column38.HeaderText = "7月";
            this.Column38.Name = "Column38";
            this.Column38.Width = 85;
            // 
            // Column39
            // 
            this.Column39.HeaderText = "8月";
            this.Column39.Name = "Column39";
            this.Column39.Width = 85;
            // 
            // Column40
            // 
            this.Column40.HeaderText = "9月";
            this.Column40.Name = "Column40";
            this.Column40.Width = 85;
            // 
            // Column41
            // 
            this.Column41.HeaderText = "10月";
            this.Column41.Name = "Column41";
            this.Column41.Width = 85;
            // 
            // Column42
            // 
            this.Column42.HeaderText = "11月";
            this.Column42.Name = "Column42";
            this.Column42.Width = 85;
            // 
            // Column43
            // 
            this.Column43.HeaderText = "12月";
            this.Column43.Name = "Column43";
            this.Column43.Width = 85;
            // 
            // button_nextyear
            // 
            this.button_nextyear.Location = new System.Drawing.Point(988, 6);
            this.button_nextyear.Name = "button_nextyear";
            this.button_nextyear.Size = new System.Drawing.Size(100, 23);
            this.button_nextyear.TabIndex = 1;
            this.button_nextyear.Text = "下一年 >>";
            this.button_nextyear.UseVisualStyleBackColor = true;
            // 
            // button_lastyear
            // 
            this.button_lastyear.Location = new System.Drawing.Point(4, 6);
            this.button_lastyear.Name = "button_lastyear";
            this.button_lastyear.Size = new System.Drawing.Size(100, 23);
            this.button_lastyear.TabIndex = 1;
            this.button_lastyear.Text = "<< 上一年";
            this.button_lastyear.UseVisualStyleBackColor = true;
            // 
            // tabControl_view
            // 
            this.tabControl_view.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_view.Controls.Add(this.tabPage_day);
            this.tabControl_view.Controls.Add(this.tabPage_month);
            this.tabControl_view.Controls.Add(this.tabPage_year);
            this.tabControl_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_view.Location = new System.Drawing.Point(0, 0);
            this.tabControl_view.Name = "tabControl_view";
            this.tabControl_view.SelectedIndex = 0;
            this.tabControl_view.Size = new System.Drawing.Size(1104, 621);
            this.tabControl_view.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_view.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 672);
            this.Controls.Add(this.button_invest);
            this.Controls.Add(this.button_partner);
            this.Controls.Add(this.button_adjust);
            this.Controls.Add(this.tabControl_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFinance";
            this.tabPage_day.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_day)).EndInit();
            this.tabPage_year.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_year)).EndInit();
            this.tabPage_month.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).EndInit();
            this.tabControl_view.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_invest;
        private System.Windows.Forms.Button button_partner;
        private System.Windows.Forms.Button button_adjust;
        private System.Windows.Forms.TabPage tabPage_day;
        private System.Windows.Forms.DateTimePicker dateTimePicker_month;
        private System.Windows.Forms.DataGridView dataGridView_day;
        private System.Windows.Forms.Button button_nextmonth;
        private System.Windows.Forms.Button button_lastmonth;
        private System.Windows.Forms.TabPage tabPage_year;
        private System.Windows.Forms.TabPage tabPage_month;
        private System.Windows.Forms.DataGridView dataGridView_month;
        private System.Windows.Forms.Button button_nextyear;
        private System.Windows.Forms.Button button_lastyear;
        private System.Windows.Forms.TabControl tabControl_view;
        private System.Windows.Forms.DateTimePicker dateTimePicker_year;
        private System.Windows.Forms.DataGridView dataGridView_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column44;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column39;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column40;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column42;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column43;




    }
}

