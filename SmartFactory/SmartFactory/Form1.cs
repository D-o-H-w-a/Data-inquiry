using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartFactory
{
    public partial class Form1 : Form

    {
        private string connectionString = "Server=localhost;Database=ski_db;Uid=root;Pwd=sawol8344@@;";

        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            Resize += new EventHandler(Form1_Resize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView의 열의 자동 크기 조절 설정
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // DataGridView의 행의 자동 크기 조절 설정
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(15,0,0,0);

            // 부모 컨트롤로서 폼에 추가
            this.Controls.Add(groupBox1);

            // 그룹박스의 Controls 속성을 사용하여 그룹박스 안에 버튼 추가
            groupBox1.Controls.Add(reference_Button);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(exit_Button);

            this.Controls.Add(groupBox2);

            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(datePickerStart);
        }

        private void reference_Button_Click(object sender, EventArgs e)
        {

            DateTime startDate = datePickerStart.Value.Date; // 시작 날짜
            TimeSpan startTime = timePickerStart.Value.TimeOfDay; // 시작 시간
            DateTime endDate = datePickerEnd.Value.Date; // 끝 날짜
            TimeSpan endTime = timePickerEnd.Value.TimeOfDay; // 끝 시간

            string startDateString = startDate.ToString("yyyy-MM-dd");
            string endDateString = endDate.ToString("yyyy-MM-dd");

            string startTimeString = startTime.ToString("hh\\:mm\\:ss"); // 시간 형식에 맞게 문자열로 변환
            string endTimeString = endTime.ToString("hh\\:mm\\:ss"); // 시간 형식에 맞게 문자열로 변환

            string query = $"SELECT * FROM t_error WHERE (Udate > '{startDateString}' OR (Udate = '{startDateString}' AND Utime >= '{startTimeString}')) AND (Udate < '{endDateString}' OR (Udate = '{endDateString}' AND Utime <= '{endTimeString}'))";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView.Rows.Clear();

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataGridView.Rows.Add(i+1, dataTable.Rows[i]["Err_code"],
                            dataTable.Rows[i]["Err_desc"], dataTable.Rows[i]["Udate"], dataTable.Rows[i]["Utime"]);
                    }

                    textBox1.Text = ("조회된 항목: " + dataTable.Rows.Count);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL 데이터베이스 연결 실패: " + ex.Message);
                }
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // 그룹박스 중앙에 배치
            textBox1.Location = new Point((groupBox1.Width - textBox1.Width) / 2, (groupBox1.Height - textBox1.Height) / 2);
            reference_Button.Location = new Point((groupBox1.Width - reference_Button.Width) / 2, (groupBox1.Height - reference_Button.Height) / 2);
            exit_Button.Location = new Point((groupBox1.Width - exit_Button.Width) / 2, (groupBox1.Height - exit_Button.Height) / 2);
        }
        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
