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
    public partial class Register_emp : Form
    {
        public Register_emp()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            DB dB = new DB();
            string sql = "SELECT DISTINCT branch_office.BRANCH_NAME FROM branch_office";
            dB.openConnection();
            MySqlCommand command = new MySqlCommand(sql, dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object name = reader.GetValue(0);
                    Workplace.Items.Add(name);
                }
            }
            reader.Close();
        }

        private void Reg_client_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string name = FIO_employee.Text;
            string birthdate = dateTimePicker1.Text;
            string gender = gender_employee.Text;
            string mp = Mob_phone_employee.Text;
            string position = Position_richtextbox.Text;
            string adress = Adress_employee.Text;
            string workplace = Workplace.SelectedItem.ToString();
            string wages = wages_employee.Text;

            dB.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT DISTINCT BRANCH_ID FROM branch_office WHERE `BRANCH_NAME` = '{workplace}'", dB.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object ID = reader.GetValue(0);
                    workplace = ID.ToString();
                }
            }
            reader.Close();
            command.CommandText = "INSERT INTO `employes` (`EMPLOYEE_ID`, `EMPLOYEE_NAME`, `BIRTHDATE`, `GENDER`, `MOBILE_PHONE`, `ADDRESS`, `POSITION`, `WAGES`, `WORKPLACE`) VALUES (NULL, @name, @bd, @gend, @mobphone, @adress, @pos, @wages, @workplace)";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@mobphone", MySqlDbType.VarChar).Value = mp;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = position;
            command.Parameters.Add("@wages", MySqlDbType.Int32).Value = wages;
            command.Parameters.Add("@workplace", MySqlDbType.Int32).Value = workplace;
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
