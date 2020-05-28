using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class OrdenNormal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pedir_orden = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_NombreOrden = new System.Windows.Forms.TextBox();
            this.comboBox_Productos = new System.Windows.Forms.ComboBox();
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_CrearOrden = new System.Windows.Forms.Button();
            this.comboBox_Direccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IDordenEliminar = new System.Windows.Forms.TextBox();
            this.button_EliminarOrden = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_CheckOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Pedir_orden.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pedir_orden);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // Pedir_orden
            // 
            this.Pedir_orden.Controls.Add(this.tableLayoutPanel1);
            this.Pedir_orden.Location = new System.Drawing.Point(4, 26);
            this.Pedir_orden.Name = "Pedir_orden";
            this.Pedir_orden.Padding = new System.Windows.Forms.Padding(3);
            this.Pedir_orden.Size = new System.Drawing.Size(539, 278);
            this.Pedir_orden.TabIndex = 0;
            this.Pedir_orden.Text = "Pedir orden";
            this.Pedir_orden.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_NombreOrden, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Productos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Empresa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_CrearOrden, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Direccion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_NombreOrden
            // 
            this.textBox_NombreOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NombreOrden.Location = new System.Drawing.Point(227, 124);
            this.textBox_NombreOrden.Name = "textBox_NombreOrden";
            this.textBox_NombreOrden.Size = new System.Drawing.Size(212, 22);
            this.textBox_NombreOrden.TabIndex = 10;
            // 
            // comboBox_Productos
            // 
            this.comboBox_Productos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Productos.FormattingEnabled = true;
            this.comboBox_Productos.Location = new System.Drawing.Point(226, 68);
            this.comboBox_Productos.Name = "comboBox_Productos";
            this.comboBox_Productos.Size = new System.Drawing.Size(213, 25);
            this.comboBox_Productos.TabIndex = 11;
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(226, 14);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(213, 25);
            this.comboBox_Empresa.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Empresa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 53);
            this.label2.TabIndex = 14;
            this.label2.Text = "Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 53);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre de la orden";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CrearOrden
            // 
            this.button_CrearOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CrearOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_CrearOrden.BackColor = System.Drawing.Color.DimGray;
            this.button_CrearOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CrearOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_CrearOrden.Location = new System.Drawing.Point(227, 220);
            this.button_CrearOrden.Name = "button_CrearOrden";
            this.button_CrearOrden.Size = new System.Drawing.Size(212, 47);
            this.button_CrearOrden.TabIndex = 9;
            this.button_CrearOrden.Text = "Pedir";
            this.button_CrearOrden.UseVisualStyleBackColor = false;
            this.button_CrearOrden.Click += new System.EventHandler(this.button_CrearOrden_Click);
            // 
            // comboBox_Direccion
            // 
            this.comboBox_Direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Direccion.FormattingEnabled = true;
            this.comboBox_Direccion.Location = new System.Drawing.Point(226, 176);
            this.comboBox_Direccion.Name = "comboBox_Direccion";
            this.comboBox_Direccion.Size = new System.Drawing.Size(213, 25);
            this.comboBox_Direccion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 53);
            this.label4.TabIndex = 17;
            this.label4.Text = "Direccion a enviar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar orden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32833F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.67167F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_IDordenEliminar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_EliminarOrden, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 272);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 90);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID de la orden a elimianr";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_IDordenEliminar
            // 
            this.textBox_IDordenEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IDordenEliminar.Location = new System.Drawing.Point(209, 34);
            this.textBox_IDordenEliminar.Name = "textBox_IDordenEliminar";
            this.textBox_IDordenEliminar.Size = new System.Drawing.Size(248, 22);
            this.textBox_IDordenEliminar.TabIndex = 1;
            // 
            // button_EliminarOrden
            // 
            this.button_EliminarOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_EliminarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_EliminarOrden.BackColor = System.Drawing.Color.DimGray;
            this.button_EliminarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EliminarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_EliminarOrden.Location = new System.Drawing.Point(227, 111);
            this.button_EliminarOrden.Name = "button_EliminarOrden";
            this.button_EliminarOrden.Size = new System.Drawing.Size(212, 47);
            this.button_EliminarOrden.TabIndex = 10;
            this.button_EliminarOrden.Text = "Eliminar";
            this.button_EliminarOrden.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 278);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ver ordenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.4409F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.5591F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.button_CheckOrder, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.91176F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.08823F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(533, 272);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // button_CheckOrder
            // 
            this.button_CheckOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CheckOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_CheckOrder.BackColor = System.Drawing.Color.DimGray;
            this.button_CheckOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CheckOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_CheckOrder.Location = new System.Drawing.Point(174, 3);
            this.button_CheckOrder.Name = "button_CheckOrder";
            this.button_CheckOrder.Size = new System.Drawing.Size(212, 38);
            this.button_CheckOrder.TabIndex = 11;
            this.button_CheckOrder.Text = "Ver ordenes";
            this.button_CheckOrder.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(31, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 221);
            this.dataGridView1.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.32833F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.67167F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID de la orden a elimianr";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(53, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 1;
            // 
            // OrdenNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "OrdenNormal";
            this.Size = new System.Drawing.Size(547, 308);
            this.tabControl1.ResumeLayout(false);
            this.Pedir_orden.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pedir_orden;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_CrearOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_EliminarOrden;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_CheckOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Productos;
        private System.Windows.Forms.ComboBox comboBox_Empresa;
        private System.Windows.Forms.TextBox textBox_IDordenEliminar;
        private System.Windows.Forms.ComboBox comboBox_Direccion;
        private System.Windows.Forms.TextBox textBox_NombreOrden;
    }
}