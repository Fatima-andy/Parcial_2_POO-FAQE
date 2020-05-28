using System;
using System.Data;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class PasswordChange : UserControl
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void AcceptPasswordChange_button_Click(object sender, EventArgs e)
        {
            if (UserName_textBox.Text.Equals("") ||
                OldPassword_textbox.Text.Equals("") ||
                NewPassword_textbox.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    var txtUsuario = UserName_textBox.Text;
                    var txtContra = OldPassword_textbox.Text;
                    var txtNew = NewPassword_textbox.Text;
              
                    ConectionBD.ExecuteNonQuiery($"UPDATE \"APPUSER\" SET password='{txtNew}' " +
                                                 $"WHERE username='{txtUsuario}' ");
                    MessageBox.Show("Contraseña cambiada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error");
                }
            }
        
        }
    }
}