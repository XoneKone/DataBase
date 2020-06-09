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
    public partial class Register_сlient : Form
    {
        public Register_сlient()
        {
            InitializeComponent();
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            DB dB = new DB();
            string sql = "SELECT DISTINCT employes.EMPLOYEE_NAME FROM employes";
            dB.openConnection();
            MySqlCommand command = new MySqlCommand(sql,dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
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
        }

        private void Reg_client_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
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
            command.CommandText = "INSERT INTO `client` (`CLIENT_ID`, `CLIENT_NAME`, `BIRTHDATE`, `GENDER`, `MOBILE_PHONE`, `ADDRESS`, `CONTRACTER`, `TYPE_LOAN`, `DATA_AGR`, `WAGES`) VALUES (NULL, @name, @bd, @gend, @mobphone, @adress, @cont, @loan, @dagr, @wages)";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@mobphone", MySqlDbType.VarChar).Value = mp;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@cont", MySqlDbType.Int32).Value = contracter;
            command.Parameters.Add("@loan", MySqlDbType.Int32).Value = typeLoan;
            command.Parameters.Add("@dagr", MySqlDbType.Date).Value = data;
            command.Parameters.Add("@wages", MySqlDbType.Int32).Value = wages;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Клиент добавлен в базу!");
                this.Close();

            }
            else MessageBox.Show("Произошла ошибка!");
            dB.closeConnection();
        }
    
    }
}
