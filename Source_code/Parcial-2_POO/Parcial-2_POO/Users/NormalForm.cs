using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class NormalForm : Form
    {
        private UserControl current = null;
        public NormalForm()
        {
            InitializeComponent();
            current = welcome1;
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new PasswordChange();
            tableLayoutPanel2.Controls.Add(current);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new OrdenNormal();
            tableLayoutPanel2.Controls.Add(current);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Remove(current);
            current = new Direccion();
            tableLayoutPanel2.Controls.Add(current);
        }
    }
}