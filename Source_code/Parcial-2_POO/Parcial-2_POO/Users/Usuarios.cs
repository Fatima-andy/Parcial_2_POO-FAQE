using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            comboBox_TipodeUsuario.DataSource = new List<string>() {"Admin", "Normal"};

        }

        private void button_CrearUsuario_Click(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text.Equals("") ||
                textBox_Nombre.Text.Equals("") ||
                textBox_Contraseña.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    var select = comboBox_TipodeUsuario.SelectedItem.ToString();
                    ConectionBD.ExecuteNonQuiery($"INSERT INTO \"APPUSER\" (fullname,username,password,\"userType\")" +
                                                 $" VALUES ('{textBox_Nombre.Text}','{textBox_Usuario.Text}'," +
                                                 $"'{textBox_Contraseña.Text}','{select}')");
                    MessageBox.Show("Se creo el nuevo usuario"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }
            
        }

        private void button_EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (textBox_idUsuario.Text.Equals("") ||
                textBox_UsuarioEliminar.Text.Equals("") ||
                textBox_ContraseñaEliminar.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    ConectionBD.ExecuteNonQuiery($"DELETE FROM \"APPUSER\" WHERE \"idUser\" = {textBox_idUsuario.Text}");
                    MessageBox.Show("Se eliminio el usuario"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }
        }

        private void button_CargarUsuarios_Click(object sender, EventArgs e)
        {
            var dat = ConectionBD.ExexuteQuery("SELECT * FROM \"APPUSER\"");
            dataGridView1.DataSource = dat;
        }
    }
}