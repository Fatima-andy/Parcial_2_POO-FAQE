using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class Negocios : UserControl
    {
        public Negocios()
        {
            InitializeComponent();
        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            if (textBox_NombreEmpresa.Text.Equals("")||textBox_NombreEmpresa.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    ConectionBD.ExecuteNonQuiery($"INSERT INTO \"BUSSINESS\" (name,description)" +
                                                 $" VALUES ('{textBox_NombreEmpresa.Text}','{textBox_NombreEmpresa.Text}')");
                    MessageBox.Show("Se agrego nueva empresa"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_IDempresa.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    ConectionBD.ExecuteNonQuiery($"DELETE FROM \"BUSSINESS\" WHERE \"idBussiness\" = {textBox_IDempresa.Text}");
                    MessageBox.Show("Se eliminio el usuario"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dat = ConectionBD.ExexuteQuery("SELECT * FROM \"BUSSINESS\"");
            dataGridView1.DataSource = dat;
        }
    }
}