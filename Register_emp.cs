﻿using System;
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
        }

        private void Reg_client_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string name;
            db.openConnection();
        }
    }
}
