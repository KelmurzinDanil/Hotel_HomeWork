using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hotel
{
    public partial class MainForm : Form
    {
        public int IdGuest {  get; set; }
        public MainForm()
        {
            LogClass log = new LogClass();
            log.LogMethod();
            InitializeComponent();
            MaximizeBox = false;
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Ticker);
        }
        private void Ticker(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        public void OpenCard_Click(object sender, EventArgs e)
        {
            
            CardGuest cardGuest = new CardGuest(IdGuest);
            cardGuest.Show();
        }
        private void LoadData(int status)
        {
            TableGuest.Rows.Clear();
            DB dB = new DB();
            SqlCommand sqlCommand = new SqlCommand("SELECT Id, ФИО, ДатаРождения FROM [User] WHERE Статус = @s", dB.GetConnection());
            sqlCommand.Parameters.Add("@s", SqlDbType.Int).SqlValue = status;
            dB.OpenConnection();
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime dateBirth = (DateTime)reader["ДатаРождения"];
                    TableGuest.Rows.Add(reader["Id"], reader["ФИО"], dateBirth.ToShortDateString());
                }
            }
            dB.CloseConnection();
        }

        private void Free_MouseClick(object sender, MouseEventArgs e)
        {
            Reserved.Checked = false;
            Busy.Checked = false;
            WriteOut.Checked = false;
            LoadData(2);
        }

        private void Reserved_MouseClick(object sender, MouseEventArgs e)
        {
            Free.Checked = false;
            Busy.Checked = false;
            WriteOut.Checked = false;
            LoadData(1);
        }

        private void Busy_MouseClick(object sender, MouseEventArgs e)
        {
            Free.Checked = false;
            Reserved.Checked = false;
            WriteOut.Checked = false;
            LoadData(3);
        }

        private void WriteOut_MouseClick(object sender, MouseEventArgs e)
        {
            Free.Checked = false;
            Reserved.Checked = false;
            Busy.Checked = false;
            LoadData(4);
        }

        private void TableGuest_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            if(TableGuest.Rows[TableGuest.SelectedCells[0].RowIndex].Cells[0].Value != null) 
            {
                DB dB = new DB();
                SqlCommand sqlCommand = new SqlCommand("SELECT ФИО, Статус, ДатаЗаезда, ДатаВыезда  FROM [User] WHERE Id = @s", dB.GetConnection());
                sqlCommand.Parameters.Add("@s", SqlDbType.Int).SqlValue = TableGuest.Rows[TableGuest.SelectedCells[0].RowIndex].Cells[0].Value;
                IdGuest = (int)TableGuest.Rows[TableGuest.SelectedCells[0].RowIndex].Cells[0].Value;
                dB.OpenConnection();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatusBox.Text = GetStatus(int.Parse(reader["Статус"].ToString()));
                        NameBox.Text = reader["ФИО"].ToString();
                        DateTime dateZ = (DateTime)reader["ДатаЗаезда"];
                        DataCheckInBox.Text = dateZ.ToShortDateString();
                        DateTime dateV = (DateTime)reader["ДатаВыезда"];
                        DateExitBox.Text = dateV.ToShortDateString();
                    }
                }
                dB.CloseConnection();
            }
        }
        public string GetStatus(int statusNum)
        {
            switch(statusNum)
            {
                case 1:
                    return "Зарезервировано";
                case 2:
                    return "Свободные";
                case 3:
                    return "Заняты";
                case 4:
                    return "Выписываются ";
                default:
                    return "Неизвестный статус";
            }
        }

        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableGuest.Rows.Clear();
            DB dB = new DB();
            SqlCommand sqlCommand = new SqlCommand("SELECT Id, ФИО, ДатаРождения FROM [User] WHERE ФИО = @s", dB.GetConnection());
            if(SearchBox.Text != String.Empty)
            {
                sqlCommand.Parameters.Add("@s", SqlDbType.NChar).SqlValue = SearchBox.Text;
            }
            try
            {
                dB.OpenConnection();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            DateTime dateBirth = (DateTime)reader["ДатаРождения"];
                            TableGuest.Rows.Add(reader["Id"], reader["ФИО"], dateBirth.ToShortDateString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено");
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            dB.CloseConnection();
        }
    }
}
