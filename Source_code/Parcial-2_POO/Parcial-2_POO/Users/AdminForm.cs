using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class AdminForm : Form
    {
        private UserControl current = null;
        public AdminForm()
        {
            InitializeComponent();
            current = welcome2;
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new PasswordChange();
            tableLayoutPanel3.Controls.Add(current);
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new Usuarios();
            tableLayoutPanel3.Controls.Add(current);
        }

        private void button_Orders_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current =new Ordenes();
            tableLayoutPanel3.Controls.Add(current);
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new Products();
            tableLayoutPanel3.Controls.Add(current);
        }

        private void button_Bussiness_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new Negocios();
            tableLayoutPanel3.Controls.Add(current);
        }
    }
}