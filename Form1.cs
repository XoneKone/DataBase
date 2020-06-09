using MySql.Data.MySqlClient;
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

namespace DataBase
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            DB dB = new DB();
            string sql = "SELECT client.CLIENT_ID,client.CLIENT_NAME 'Имя', DATE_FORMAT(client.BIRTHDATE,'%Y-%m-%d') as 'Дата рождения', client.GENDER 'Пол', " +
                "client.MOBILE_PHONE 'Моб.телефон', client.ADDRESS 'Адрес'," +
                "employes.EMPLOYEE_NAME 'Контрактер',type_loan.LOAN_NAME 'Вид займа',DATE_FORMAT(client.DATA_AGR,'%Y-%m-%d') as 'Дата заключения договора',client.WAGES 'Зарплата'" +
                " FROM `client` INNER JOIN `employes`  ON client.CONTRACTER = employes.EMPLOYEE_ID INNER JOIN `type_loan` ON client.TYPE_LOAN = type_loan.LOAN_ID";


            string sql1 = "SELECT employes.EMPLOYEE_ID,employes.EMPLOYEE_NAME 'Имя', DATE_FORMAT(employes.BIRTHDATE,'%Y-%m-%d') as 'Дата рождения', employes.GENDER 'Пол', " +
                "employes.MOBILE_PHONE 'Моб.телефон', employes.ADDRESS 'Адрес'," +
                "employes.POSITION 'Должность',employes.WAGES 'Зарплата', branch_office.BRANCH_NAME 'Место работы'" +
                " FROM `employes` INNER JOIN `branch_office`  ON employes.WORKPLACE = branch_office.BRANCH_ID";
            Employes_base.AllowUserToAddRows = false;
            Clients_base.AllowUserToAddRows = false;
            dB.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql,dB.getConnection());     
                DataSet ds = new DataSet();
                adapter.Fill(ds);               
                Clients_base.DataSource = ds.Tables[0];

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(sql1, dB.getConnection());
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);
                Employes_base.DataSource = ds1.Tables[0];
            dB.closeConnection();

            Clients_base.Columns[1].Visible = false;
            Clients_base.Columns[2].Width = 250;
            Clients_base.Columns[4].Width = 50;
            Clients_base.Columns[5].Width = 150;
            Clients_base.Columns[6].Width = 250;
            Clients_base.Columns[7].Width = 200;
            Clients_base.Columns[8].Width = 200;

            Employes_base.Columns[1].Visible = false;
            Employes_base.Columns[2].Width = 250;
            Employes_base.Columns[4].Width = 50;
            Employes_base.Columns[5].Width = 150;
            Employes_base.Columns[6].Width = 250;
            Employes_base.Columns[7].Width = 150;
            Employes_base.Columns[8].Width = 100;
            Employes_base.Columns[9].Width = 150;

            for (int i = 0; i < Employes_base.Rows.Count; i++)
            {
                Employes_base.Rows[i].Cells[0].Value=null;
            }
            for (int i = 0; i < Clients_base.Rows.Count; i++)
            {
                Clients_base.Rows[i].Cells[0].Value = null;
            }
        }
         

        private void button_register_Click(object sender, EventArgs e)
        {
            Register_сlient newForm = new Register_сlient();
            newForm.ShowDialog();
           
        }
       
        private void change_client_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Clients_base.Rows.Count; i++)
            {
               if(this.Clients_base.Rows[i].Cells[0].Value !=null)
                {
                    List<string> str = new List<string>();
                    for (int j = 1; j< Clients_base.Rows[i].Cells.Count;j++)
                    {
                        str.Add(Clients_base.Rows[i].Cells[j].Value.ToString());
                    }
                    Change_client changeForm = new Change_client(str);
                    changeForm.ShowDialog();
                }               
            }
            for (int i = 0; i < Clients_base.Rows.Count; i++)
            {
                Clients_base.Rows[i].Cells[0].Value = null;
            }
            if (!check)
                MessageBox.Show("Не выбраны записи!");
        }


        private void Update_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string sql = "SELECT client.CLIENT_ID,client.CLIENT_NAME 'Имя', DATE_FORMAT(client.BIRTHDATE,'%Y-%m-%d') as 'Дата рождения', client.GENDER 'Пол', " +
                "client.MOBILE_PHONE 'Моб.телефон', client.ADDRESS 'Адрес'," +
                "employes.EMPLOYEE_NAME 'Контрактер',type_loan.LOAN_NAME 'Вид займа',DATE_FORMAT(client.DATA_AGR,'%Y-%m-%d') as 'Дата заключения договора',client.WAGES 'Зарплата'" +
                " FROM `client` INNER JOIN `employes`  ON client.CONTRACTER = employes.EMPLOYEE_ID INNER JOIN `type_loan` ON client.TYPE_LOAN = type_loan.LOAN_ID";
            Clients_base.Columns[1].Visible = false;
            Clients_base.AllowUserToAddRows = false;
            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dB.getConnection());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Clients_base.DataSource = ds.Tables[0];
            dB.closeConnection();
            Clients_base.Columns[2].Width = 250;
            Clients_base.Columns[4].Width = 50;
            Clients_base.Columns[5].Width = 150;
            Clients_base.Columns[6].Width = 250;
            Clients_base.Columns[7].Width = 200;
            Clients_base.Columns[8].Width = 200;
        }

        private void delete_client_button_Click(object sender, EventArgs e)
        {
            List<string> ID = new List<string>();
            bool check = false;
            DB dB = new DB();
            for (int i = 0; i < Clients_base.Rows.Count; i++)
            {
                if (this.Clients_base.Rows[i].Cells[0].Value != null)
                {
                    check = true;
                    ID.Add(Clients_base.Rows[i].Cells[1].Value.ToString());
                }
            }
            for (int i = 0; i < Clients_base.Rows.Count; i++)
            {
                Clients_base.Rows[i].Cells[0].Value = null;
            }
            if (!check)
                MessageBox.Show("Не выбраны записи!");
            else
            {
                string sql = "DELETE FROM `client` WHERE ";
                foreach (var s in ID)
                {
                    sql += "CLIENT_ID = " + s + " OR ";
                }
                sql = sql.Substring(0, sql.Length - 4);
                dB.openConnection();

                MySqlCommand command = new MySqlCommand(sql, dB.getConnection());
                if (command.ExecuteNonQuery() != -1)
                {
                    MessageBox.Show("Записи удалены из базы!");
                }
                else MessageBox.Show("Произошла ошибка!");
                dB.closeConnection();
            }
        }

        private void register_emp_button_Click(object sender, EventArgs e)
        {
            Register_emp register_Emp = new Register_emp();
            register_Emp.ShowDialog();
        }

        private void update_emp_button_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            string sql = "SELECT employes.EMPLOYEE_ID,employes.EMPLOYEE_NAME 'Имя', DATE_FORMAT(employes.BIRTHDATE,'%Y-%m-%d') as 'Дата рождения', employes.GENDER 'Пол', " +
                "employes.MOBILE_PHONE 'Моб.телефон', employes.ADDRESS 'Адрес'," +
                "employes.POSITION 'Должность',employes.WAGES 'Зарплата', branch_office.BRANCH_NAME 'Место работы'" +
                " FROM `employes` INNER JOIN `branch_office`  ON employes.WORKPLACE = branch_office.BRANCH_ID";
            Employes_base.AllowUserToAddRows = false;

            dB.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dB.getConnection());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Employes_base.DataSource = ds.Tables[0];
            dB.closeConnection();

            Employes_base.Columns[1].Visible = false;
            Employes_base.Columns[2].Width = 250;
            Employes_base.Columns[4].Width = 50;
            Employes_base.Columns[5].Width = 150;
            Employes_base.Columns[6].Width = 250;
            Employes_base.Columns[7].Width = 150;
            Employes_base.Columns[8].Width = 100;
            Employes_base.Columns[9].Width = 150;
        }

        private void change_emp_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Employes_base.Rows.Count; i++)
            {
                if (this.Employes_base.Rows[i].Cells[0].Value != null)
                {
                    check = true;
                    List<string> str = new List<string>();
                    for (int j = 1; j < Employes_base.Rows[i].Cells.Count; j++)
                    {
                        str.Add(Employes_base.Rows[i].Cells[j].Value.ToString());
                    }
                    Change_employee changeForm = new Change_employee(str);
                    changeForm.ShowDialog();
                }
            }
            for (int i = 0; i < Employes_base.Rows.Count; i++)
            {
                Employes_base.Rows[i].Cells[0].Value = null;
            }
            if (!check)  
                MessageBox.Show("Не выбраны записи!") ;
        }

        private void delete_emp_button_Click(object sender, EventArgs e)
        {
            
            List<string> ID = new List<string>();
            bool check = false;
            DB dB = new DB();
            for (int i = 0; i < Employes_base.Rows.Count; i++)
            {
                if (this.Employes_base.Rows[i].Cells[0].Value != null)
                {
                    check = true;
                    ID.Add(Employes_base.Rows[i].Cells[1].Value.ToString());
                }
            }
            for (int i = 0; i < Employes_base.Rows.Count; i++)
            {   
                    Employes_base.Rows[i].Cells[0].Value = null;    
            }
            if (!check)
                MessageBox.Show("Не выбраны записи!");
            else
            {
                string sql_check = "SELECT * FROM `client` WHERE CONTRACTER = ";
                string sql = "DELETE FROM `employes` WHERE ";
                bool allow = true;
                foreach (var s in ID)
                {
                    sql += "EMPLOYEE_ID = " + s + " OR ";
                   
                }
                sql = sql.Substring(0, sql.Length - 4);
                dB.openConnection();
                foreach (var s in ID) 
                {
                    
                    MySqlCommand command1 = new MySqlCommand(sql_check+s, dB.getConnection());
                    MySqlDataReader reader = command1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        allow = false;
                    }
                    
                    reader.Close();
                }
                
                if (allow)
                {
                    MySqlCommand command = new MySqlCommand(sql, dB.getConnection());
                    if (command.ExecuteNonQuery() != -1)
                    {
                        MessageBox.Show("Записи удалены из базы!");
                    }
                    else MessageBox.Show("Произошла ошибка!");
                }else
                {
                    MessageBox.Show("Нельзя удалить запись, т.к. с ним связан клиент!");
                }
                dB.closeConnection();
            }
        }

        private void Exit_buton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы уверены, что хотите закрыть программу?",
               "Сообщение",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Cancel)
            {
                this.Activate();
            }
            if (result == DialogResult.OK) 
            {
                this.Close();
            }

                 
        }

        
    }
}
