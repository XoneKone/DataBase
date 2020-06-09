using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Change_client : Form
    {
        private List<string> str;

        public Change_client()
        {
            InitializeComponent();
        }

        public Change_client(List<string> str)
        {
            InitializeComponent();
            this.str = str;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            DB dB = new DB();
            string sql = "SELECT DISTINCT employes.EMPLOYEE_NAME FROM employes";
            dB.openConnection();
            MySqlCommand command = new MySqlCommand(sql, dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object name = reader.GetValue(0);
                    Contracter.Items.Add(name);
                }
            }
            reader.Close();
            command.CommandText = "SELECT DISTINCT type_loan.LOAN_NAME FROM type_loan";
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object name = reader.GetValue(0);
                    type_loan.Items.Add(name);
                }
            }
            reader.Close();
            dB.closeConnection();

            FIO_client.Text = str[1];
            dateTimePicker2.Text = str[2];
            gender_client.Text = str[3];
            Mob_phone_client.Text = str[4];
            Adress_client.Text = str[5];
            Contracter.Text = str[6];
            type_loan.Text = str[7];
            dateTimePicker1.Text = str[8];
            wages_clients.Text = str[9];
        }

        private void Change_client_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            int id = int.Parse(str[0]);
            string name = FIO_client.Text;
            string birthdate = dateTimePicker2.Text;
            string gender = gender_client.Text;
            string mp = Mob_phone_client.Text;
            string adress = Adress_client.Text;
            string contracter = Contracter.SelectedItem.ToString();
            string typeLoan = type_loan.SelectedItem.ToString();
            string data = dateTimePicker1.Text;
            string wages = wages_clients.Text;
            dB.openConnection();
            MySqlCommand command = new MySqlCommand($"SELECT DISTINCT EMPLOYEE_ID FROM employes WHERE `EMPLOYEE_NAME` = '{contracter}'", dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object ID = reader.GetValue(0);
                    contracter = ID.ToString();
                }
            }
            reader.Close();
            command.CommandText = $"SELECT DISTINCT LOAN_ID FROM type_loan WHERE `LOAN_NAME` = '{typeLoan}'";
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object ID = reader.GetValue(0);
                    typeLoan = ID.ToString();
                }
            }
            reader.Close();
            command.CommandText = "UPDATE `client` SET `CLIENT_NAME` = @name, `BIRTHDATE` = @bd, `GENDER` = @gend," +
                " `MOBILE_PHONE` = @mobphone, `ADDRESS` = @adress, `CONTRACTER` = @cont, `TYPE_LOAN` = @loan," +
                " `DATA_AGR` = @dagr, `WAGES` = @wages WHERE `client`.`CLIENT_ID` = @id ";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@mobphone", MySqlDbType.VarChar).Value = mp;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@cont", MySqlDbType.Int32).Value = contracter;
            command.Parameters.Add("@loan", MySqlDbType.Int32).Value = typeLoan;
            command.Parameters.Add("@dagr", MySqlDbType.Date).Value = data;
            command.Parameters.Add("@wages", MySqlDbType.Int32).Value = wages;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения внесенЫ в базу!");
                this.Close();
            }
            else MessageBox.Show("Произошла ошибка!");
            dB.closeConnection();
        }
    }
}
