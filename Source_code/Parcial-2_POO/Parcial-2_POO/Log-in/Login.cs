using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class Login : UserControl
    {
        private UserControl current;
        public Login()
        {
            InitializeComponent();
        }
        
        private void IniciarSesion_button_Click(object sender, EventArgs e)
        {
            if (Usuario_textBox.Text.Equals("") ||
                Contraseña_textBox.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar datos vacios");
            }
            else
            {
                try
                {
                    var txtUsuario = Usuario_textBox.Text;
                    var txtContra = Contraseña_textBox.Text;

                    var Select = ConectionBD.ExexuteQuery($"SELECT username, password, \"userType\" FROM" +
                                                          $" \"APPUSER\" WHERE username = '{txtUsuario}' " +
                                                          $"AND password = '{txtContra}'");
                    foreach (DataRow dr in Select.Rows)
                    {
                        if (dr[2].ToString().Equals("Admin"))
                        {
                            AdminForm AF = new AdminForm();
                            AF.Show();
                        }
                        else if (dr[2].ToString().Equals("Normal"))
                        {
                            NormalForm NF = new NormalForm();
                            NF.Show();
                        }
                    }

                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }
            
        }

    }
}