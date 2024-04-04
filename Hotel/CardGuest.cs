using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class CardGuest : Form
    {
        public CardGuest()
        {
            MaximizeBox = false;
            InitializeComponent();
        }
        public CardGuest(int idU)
        {
            MaximizeBox = false;
            InitializeComponent();
            FillCard(idU);
        }
        private void FillCard(int idU)
        {
            DB dB = new DB();
            SqlCommand sqlCommand = new SqlCommand("SELECT ФИО, ДатаРождения, Животные, ДатаЗаезда, ДатаВыезда  FROM [User] WHERE Id = @s", dB.GetConnection());
            sqlCommand.Parameters.Add("@s", SqlDbType.Int).SqlValue = idU;
            dB.OpenConnection();
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    NameGuest.Text = reader["ФИО"].ToString();
                    DateTime dateBirthGuest = (DateTime)reader["ДатаРождения"];
                    DateOfBirthGuest.Text = dateBirthGuest.ToShortDateString();
                    TimeSpan NumberOfDays = (DateTime)reader["ДатаВыезда"] - (DateTime)reader["ДатаЗаезда"];
                    DateBox.Text = NumberOfDays.TotalDays.ToString();
                    PayBox.Text = PayBoxCalcAndWrite(NumberOfDays).ToString() + "$";
                    if (Animal(reader["Животные"].ToString()))
                    {
                        AnimalGuest.Checked = true;
                    }
                    else
                    {
                        AnimalGuest.Checked = false;
                    }
                } 
            }
            dB.CloseConnection();
        }
        public int PayBoxCalcAndWrite(TimeSpan NumberOfDays)
        {
            return ((int)NumberOfDays.TotalDays * 4);
        }
        public bool Animal(string r)
        {
            return r == "1";
        }
    }
}
