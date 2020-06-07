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
            string sql = "SELECT * FROM `client`";


            dB.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql,dB.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[1];
            dB.closeConnection();
        }
          

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            DB db = new DB();
           
        }
    }
}
