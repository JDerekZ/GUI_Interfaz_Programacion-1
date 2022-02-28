﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_Assignment_1
{
    public partial class FrmLogin : Form
    {

        private FrmHome homeScreen;
        
        public FrmLogin()
        {
            InitializeComponent();
            homeScreen = new FrmHome();
        }

        private SqlConnection connection = new SqlConnection("server = LAPTOP-H3RK1BM6\\SQLEXPRESS ; database = Persons ; INTEGRATED SECURITY = true");


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comand = new SqlCommand("SELECT Users, Password FROM person WHERE Users = @user AND Password = @password", connection);
            comand.Parameters.AddWithValue("@user",TbxUser.Text);
            comand.Parameters.AddWithValue("@password", TbxPassword.Text);

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.Read())
            {
                homeScreen.Show();
                connection.Close();
                
            }

        }
    }
}
