using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Assignment_1
{
    public partial class FrmHome : Form
    {
         SqlConnection connection = new SqlConnection("server = LAPTOP-H3RK1BM6\\SQLEXPRESS ; database = Persons ; INTEGRATED SECURITY = true");

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM person", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TbxNewUser.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos para poder registrarse\nAsegúrese de introducir el Nombre de Usuario correctamente");
            }
            else if (TbxNewPassword.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos para poder registrarse\nAsegúrese de introducir la Contraseña correctamente");
            }
            else
            {
                string data = "INSERT INTO person (Users,Password) VALUES (@user,@password)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(data, connection);
                cmd.Parameters.AddWithValue("@user", TbxNewUser.Text);
                cmd.Parameters.AddWithValue("@password", TbxNewPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente \nPresione el botón de -Actualizar- para visualizarlo");
            };

            
        }
    }
}
