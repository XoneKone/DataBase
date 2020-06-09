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
    public partial class Change_employee : Form
    {
        private List<string> str;

        public Change_employee()
        {
            InitializeComponent();
        }

        public Change_employee(List<string> str)
        {
            InitializeComponent();

            this.str = str;
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

            FIO_employee.Text = str[1];
            dateTimePicker1.Text = str[2];
            gender_employee.Text = str[3];
            Mob_phone_employee.Text = str[4];
            Adress_employee.Text = str[5];
            Position_richtextbox.Text = str[6];
            wages_employee.Text = str[7];
            Workplace.Text = str[8];
        }

        private void Change_employee_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            int id = int.Parse(str[0]);
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
            command.CommandText = "UPDATE `employes` SET `EMPLOYEE_NAME` = @name, `BIRTHDATE` = @bd, `GENDER` = @gend," +
                " `MOBILE_PHONE` = @mobphone, `ADDRESS` = @adress, `POSITION` = @pos, `WAGES` = @wages," +
                " `WORKPLACE` = @workplace WHERE `employes`.`EMPLOYEE_ID` = @id ";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@mobphone", MySqlDbType.VarChar).Value = mp;
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = position;
            command.Parameters.Add("@wages", MySqlDbType.Int32).Value = wages;
            command.Parameters.Add("@workplace", MySqlDbType.Int32).Value = workplace;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения внесены в базу!");
                this.Close();

            }
            else MessageBox.Show("Произошла ошибка!");
            dB.closeConnection();
        }
    }
}
