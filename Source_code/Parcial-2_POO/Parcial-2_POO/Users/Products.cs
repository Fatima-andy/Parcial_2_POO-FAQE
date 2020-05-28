using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            var buiss = ConectionBD.ExexuteQuery("SELECT name FROM \"BUSSINESS\"");
            var buisCombo = new List<string>();

            foreach (DataRow dr in buiss.Rows)
            {
                buisCombo.Add(dr[0].ToString());
            }

            comboBox_EmNew.DataSource = buisCombo;
            comboBox_EmDelete.DataSource = buisCombo;
            comboBox_EmList.DataSource = buisCombo;
        }
        
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_NameProduct.Text.Equals(""))
            {
                MessageBox.Show("No dejar campos vacios");
            }
            else
            {
                try
                {
                    var select = comboBox_EmNew.SelectedItem.ToString();
                    var buiss = ConectionBD.ExexuteQuery($"SELECT \"idBussiness\" FROM \"BUSSINESS\" " +
                                                         $"WHERE \"name\" = '{select}'");
                    var buisID =buiss.Rows[0][0].ToString();
                    ConectionBD.ExecuteNonQuiery($"INSERT INTO \"PRODUCT\" (name,\"idBussiness\")" +
                                                             $" VALUES ('{textBox_NameProduct.Text}',{buisID})");
                    MessageBox.Show("Se creo el nuevo producto"); 
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Ocurrio un error"); 
                } 
            }
        }
        
        private void button_DeleteProduct_Click(object sender, EventArgs e)
        {
           if (textBox_IDproducto.Text.Equals("")) 
           {
               MessageBox.Show("No dejar campos vacios");
           }
           else
           {
               try
               {
                   var select = comboBox_EmDelete.SelectedItem.ToString();
                   ConectionBD.ExecuteNonQuiery($"DELETE FROM \"PRODUCT\" WHERE \"idBussiness\" " +
                                                $"= {textBox_IDproducto.Text}");
                   MessageBox.Show("Se eliminio el producto");  
               }
               catch(Exception ex)
               { 
                   MessageBox.Show("Ocurrio un error"); 
               } 
           } 
        }
        
        
        private void tab_NuevoProducto_Click(object sender, EventArgs e)
        {
        }


        private void button_List_Click(object sender, EventArgs e)
        {
            var nameEm = comboBox_EmList.SelectedItem.ToString();
            
            var buiss = ConectionBD.ExexuteQuery($"SELECT \"idBussiness\" FROM \"BUSSINESS\"" +
                                                 $" WHERE \"name\" = '{nameEm}'");
            var buisID =buiss.Rows[0][0].ToString();

            var productoDT = ConectionBD.ExexuteQuery($"SELECT \"idProduct\",\"name\" FROM \"PRODUCT\"" +
                                                      $" WHERE \"idBussiness\" = {buisID};");
            dataGridView1.DataSource = productoDT;


        }
    }
}