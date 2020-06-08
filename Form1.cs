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
            string sql = "SELECT client.CLIENT_NAME 'Имя', client.BIRTHDATE 'Дата рождения', client.GENDER 'Пол', " +
                "client.MOBILE_PHONE 'Моб.телефон', client.ADDRESS 'Адрес'," +
                "employes.EMPLOYEE_NAME 'Контрактер',type_loan.LOAN_NAME 'Вид займа',client.DATA_AGR 'Дата заключения договора',client.WAGES 'Зарплата'" +
                " FROM `client` INNER JOIN `employes`  ON client.CONTRACTER = employes.EMPLOYEE_ID INNER JOIN `type_loan` ON client.TYPE_LOAN = type_loan.LOAN_ID";

            Clients_base.AllowUserToAddRows = false;
            dB.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql,dB.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Clients_base.DataSource = ds.Tables[0];
            dB.closeConnection();
            Clients_base.Columns[1].Width = 250;
            Clients_base.Columns[3].Width = 50;
            Clients_base.Columns[4].Width = 150;
            Clients_base.Columns[5].Width = 250;
            Clients_base.Columns[6].Width = 200;
            Clients_base.Columns[7].Width = 200;
            Check.
         
        }
          

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            DB db = new DB();
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
