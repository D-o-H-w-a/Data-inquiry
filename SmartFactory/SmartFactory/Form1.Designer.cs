using System.Windows.Forms;

namespace SmartFactory
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reference_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Err_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Err_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reference_Button
            // 
            this.reference_Button.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reference_Button.Location = new System.Drawing.Point(6, 14);
            this.reference_Button.Name = "reference_Button";
            this.reference_Button.Size = new System.Drawing.Size(108, 40);
            this.reference_Button.TabIndex = 0;
            this.reference_Button.Text = "조 회";
            this.reference_Button.UseVisualStyleBackColor = true;
            this.reference_Button.Click += new System.EventHandler(this.reference_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.exit_Button);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.reference_Button);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(800, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // exit_Button
            // 
            this.exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exit_Button.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_Button.Location = new System.Drawing.Point(689, 14);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(108, 40);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "닫 기";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox1.Location = new System.Drawing.Point(301, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "조회된 항목 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.timePickerStart);
            this.groupBox2.Controls.Add(this.datePickerStart);
            this.groupBox2.Controls.Add(this.timePickerEnd);
            this.groupBox2.Controls.Add(this.datePickerEnd);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox3.Location = new System.Drawing.Point(345, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 15);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "~";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox2.Location = new System.Drawing.Point(6, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "조회일시 :";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timePickerStart
            // 
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStart.Location = new System.Drawing.Point(224, 13);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.ShowUpDown = true;
            this.timePickerStart.Size = new System.Drawing.Size(115, 21);
            this.timePickerStart.TabIndex = 0;
            this.timePickerStart.Value = new System.DateTime(2023, 11, 23, 17, 52, 0, 0);
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(94, 13);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(115, 21);
            this.datePickerStart.TabIndex = 0;
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEnd.Location = new System.Drawing.Point(517, 13);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.ShowUpDown = true;
            this.timePickerEnd.Size = new System.Drawing.Size(115, 21);
            this.timePickerEnd.TabIndex = 0;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerEnd.Location = new System.Drawing.Point(384, 13);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(115, 21);
            this.datePickerEnd.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Err_code,
            this.Err_desc,
            this.Udate,
            this.Utime});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 125);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(800, 528);
            this.dataGridView.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle17;
            this.ID.Frozen = true;
            this.ID.HeaderText = "번호";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Err_code
            // 
            this.Err_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Err_code.Frozen = true;
            this.Err_code.HeaderText = "에러 코드";
            this.Err_code.Name = "Err_code";
            this.Err_code.ReadOnly = true;
            this.Err_code.Width = 112;
            // 
            // Err_desc
            // 
            this.Err_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Err_desc.Frozen = true;
            this.Err_desc.HeaderText = "에러 내역";
            this.Err_desc.Name = "Err_desc";
            this.Err_desc.ReadOnly = true;
            this.Err_desc.Width = 390;
            // 
            // Udate
            // 
            this.Udate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Udate.Frozen = true;
            this.Udate.HeaderText = "발생일자";
            this.Udate.Name = "Udate";
            this.Udate.ReadOnly = true;
            this.Udate.Width = 112;
            // 
            // Utime
            // 
            this.Utime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Utime.Frozen = true;
            this.Utime.HeaderText = "발생시간";
            this.Utime.Name = "Utime";
            this.Utime.ReadOnly = true;
            this.Utime.Width = 112;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Button exit_Button;
        private DateTimePicker datePickerStart;
        private DateTimePicker datePickerEnd;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker timePickerStart;
        private DateTimePicker timePickerEnd;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Err_code;
        private DataGridViewTextBoxColumn Err_desc;
        private DataGridViewTextBoxColumn Udate;
        private DataGridViewTextBoxColumn Utime;
        private TextBox textBox1;
        private Button reference_Button;
    }
}

