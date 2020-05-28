using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class OrdenNormal : UserControl
    {
        public OrdenNormal()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button_CrearOrden_Click(object sender, EventArgs e)
        {
            if (textBox_NombreOrden.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    var direction = comboBox_Direccion.SelectedItem.ToString();
                    var business = comboBox_Empresa.SelectedItem.ToString();
                    var product = comboBox_Productos.SelectedItem.ToString();
                    
                    MessageBox.Show("Se creo el nuevo usuario"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                }
            }

        }
    }
}