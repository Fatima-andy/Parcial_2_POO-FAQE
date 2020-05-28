using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class Products
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
            this.tab_NuevoProducto = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_NewProduct = new System.Windows.Forms.Button();
            this.comboBox_EmNew = new System.Windows.Forms.ComboBox();
            this.textBox_NameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_EliminarProducto = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_IDproducto = new System.Windows.Forms.TextBox();
            this.comboBox_EmDelete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DeleteProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_ListaDeProductos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_EmList = new System.Windows.Forms.ComboBox();
            this.button_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_NuevoProducto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_EliminarProducto.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tab_ListaDeProductos.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tab_NuevoProducto);
            this.tabControl1.Controls.Add(this.tab_EliminarProducto);
            this.tabControl1.Controls.Add(this.tab_ListaDeProductos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_NuevoProducto
            // 
            this.tab_NuevoProducto.Controls.Add(this.tableLayoutPanel1);
            this.tab_NuevoProducto.Location = new System.Drawing.Point(4, 26);
            this.tab_NuevoProducto.Name = "tab_NuevoProducto";
            this.tab_NuevoProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NuevoProducto.Size = new System.Drawing.Size(645, 365);
            this.tab_NuevoProducto.TabIndex = 0;
            this.tab_NuevoProducto.Text = "Nuevo producto";
            this.tab_NuevoProducto.UseVisualStyleBackColor = true;
            this.tab_NuevoProducto.Click += new System.EventHandler(this.tab_NuevoProducto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15023F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84977F));
            this.tableLayoutPanel1.Controls.Add(this.button_NewProduct, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_EmNew, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_NameProduct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23256F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.04651F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.72093F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_NewProduct
            // 
            this.button_NewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_NewProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.button_NewProduct, 2);
            this.button_NewProduct.Location = new System.Drawing.Point(173, 279);
            this.button_NewProduct.Name = "button_NewProduct";
            this.button_NewProduct.Size = new System.Drawing.Size(292, 55);
            this.button_NewProduct.TabIndex = 0;
            this.button_NewProduct.Text = "Aceptar";
            this.button_NewProduct.UseVisualStyleBackColor = true;
            this.button_NewProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_EmNew
            // 
            this.comboBox_EmNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_EmNew.FormattingEnabled = true;
            this.comboBox_EmNew.Location = new System.Drawing.Point(322, 51);
            this.comboBox_EmNew.Name = "comboBox_EmNew";
            this.comboBox_EmNew.Size = new System.Drawing.Size(224, 25);
            this.comboBox_EmNew.TabIndex = 1;
            // 
            // textBox_NameProduct
            // 
            this.textBox_NameProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NameProduct.Location = new System.Drawing.Point(322, 175);
            this.textBox_NameProduct.Name = "textBox_NameProduct";
            this.textBox_NameProduct.Size = new System.Drawing.Size(224, 22);
            this.textBox_NameProduct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 128);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa del producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 117);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del producto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_EliminarProducto
            // 
            this.tab_EliminarProducto.Controls.Add(this.tableLayoutPanel4);
            this.tab_EliminarProducto.Location = new System.Drawing.Point(4, 26);
            this.tab_EliminarProducto.Name = "tab_EliminarProducto";
            this.tab_EliminarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EliminarProducto.Size = new System.Drawing.Size(645, 365);
            this.tab_EliminarProducto.TabIndex = 1;
            this.tab_EliminarProducto.Text = "Eliminar producto";
            this.tab_EliminarProducto.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.55086F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.44914F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_IDproducto, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_EmDelete, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_DeleteProduct, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.80695F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.10425F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.448276F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(639, 359);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox_IDproducto
            // 
            this.textBox_IDproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IDproducto.Location = new System.Drawing.Point(311, 179);
            this.textBox_IDproducto.Name = "textBox_IDproducto";
            this.textBox_IDproducto.Size = new System.Drawing.Size(224, 22);
            this.textBox_IDproducto.TabIndex = 7;
            // 
            // comboBox_EmDelete
            // 
            this.comboBox_EmDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_EmDelete.FormattingEnabled = true;
            this.comboBox_EmDelete.Location = new System.Drawing.Point(311, 52);
            this.comboBox_EmDelete.Name = "comboBox_EmDelete";
            this.comboBox_EmDelete.Size = new System.Drawing.Size(224, 25);
            this.comboBox_EmDelete.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 129);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa del producto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_DeleteProduct
            // 
            this.button_DeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.button_DeleteProduct, 2);
            this.button_DeleteProduct.Location = new System.Drawing.Point(176, 280);
            this.button_DeleteProduct.Name = "button_DeleteProduct";
            this.button_DeleteProduct.Size = new System.Drawing.Size(287, 57);
            this.button_DeleteProduct.TabIndex = 0;
            this.button_DeleteProduct.Text = "Eliminar producto";
            this.button_DeleteProduct.UseVisualStyleBackColor = true;
            this.button_DeleteProduct.Click += new System.EventHandler(this.button_DeleteProduct_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 122);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID del producto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_ListaDeProductos
            // 
            this.tab_ListaDeProductos.Controls.Add(this.tableLayoutPanel5);
            this.tab_ListaDeProductos.Location = new System.Drawing.Point(4, 26);
            this.tab_ListaDeProductos.Name = "tab_ListaDeProductos";
            this.tab_ListaDeProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ListaDeProductos.Size = new System.Drawing.Size(645, 365);
            this.tab_ListaDeProductos.TabIndex = 2;
            this.tab_ListaDeProductos.Text = "Lista de productos";
            this.tab_ListaDeProductos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.92801F));
            this.tableLayoutPanel5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.07199F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBox_EmList, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_List, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.20892F));
            this.tableLayoutPanel5.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(639, 359);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empresa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_EmList
            // 
            this.comboBox_EmList.FormattingEnabled = true;
            this.comboBox_EmList.Location = new System.Drawing.Point(91, 3);
            this.comboBox_EmList.Name = "comboBox_EmList";
            this.comboBox_EmList.Size = new System.Drawing.Size(268, 25);
            this.comboBox_EmList.TabIndex = 2;
            // 
            // button_List
            // 
            this.button_List.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_List.Location = new System.Drawing.Point(249, 49);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(229, 33);
            this.button_List.TabIndex = 4;
            this.button_List.Text = "Aceptar";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(91, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 265);
            this.dataGridView1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15023F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84977F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.button2, 2);
            this.button2.Location = new System.Drawing.Point(3, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(75, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15023F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84977F));
            this.tableLayoutPanel3.Controls.Add(this.button3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox3, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.button3, 2);
            this.button3.Location = new System.Drawing.Point(3, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(75, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(75, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(653, 395);
            this.Load += new System.EventHandler(this.Products_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_NuevoProducto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_EliminarProducto.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tab_ListaDeProductos.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tab_ListaDeProductos;
        private System.Windows.Forms.TabPage tab_EliminarProducto;
        private System.Windows.Forms.TabPage tab_NuevoProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.ComboBox comboBox_EmList;
        private System.Windows.Forms.TextBox textBox_IDproducto;
        private System.Windows.Forms.ComboBox comboBox_EmDelete;
        private System.Windows.Forms.Button button_DeleteProduct;
        private System.Windows.Forms.TextBox textBox_NameProduct;
        private System.Windows.Forms.ComboBox comboBox_EmNew;
        private System.Windows.Forms.Button button_NewProduct;
    }
}