using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class Ordenes : UserControl
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dat = ConectionBD.ExexuteQuery("SELECT * FROM \"APPORDER\"");
            dataGridView1.DataSource = dat;
        }
    }
}