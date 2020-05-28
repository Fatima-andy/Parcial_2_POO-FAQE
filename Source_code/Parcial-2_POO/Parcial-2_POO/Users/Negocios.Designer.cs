using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class Negocios
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
            this.tab_NuevaEmpresa = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_NombreEmpresa = new System.Windows.Forms.TextBox();
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            this.tab_EliminarEmpresa = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IDempresa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tab_ListaEmpresas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DescripcionEmpresa = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_NuevaEmpresa.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_EliminarEmpresa.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tab_ListaEmpresas.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_NuevaEmpresa);
            this.tabControl1.Controls.Add(this.tab_EliminarEmpresa);
            this.tabControl1.Controls.Add(this.tab_ListaEmpresas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_NuevaEmpresa
            // 
            this.tab_NuevaEmpresa.Controls.Add(this.tableLayoutPanel2);
            this.tab_NuevaEmpresa.Location = new System.Drawing.Point(4, 26);
            this.tab_NuevaEmpresa.Name = "tab_NuevaEmpresa";
            this.tab_NuevaEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NuevaEmpresa.Size = new System.Drawing.Size(524, 358);
            this.tab_NuevaEmpresa.TabIndex = 0;
            this.tab_NuevaEmpresa.Text = "Nuevo empresa";
            this.tab_NuevaEmpresa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_NombreEmpresa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_CrearUsuario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_DescripcionEmpresa, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 225);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 73);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre de empresa:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_NombreEmpresa
            // 
            this.textBox_NombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NombreEmpresa.Location = new System.Drawing.Point(219, 25);
            this.textBox_NombreEmpresa.Name = "textBox_NombreEmpresa";
            this.textBox_NombreEmpresa.Size = new System.Drawing.Size(209, 22);
            this.textBox_NombreEmpresa.TabIndex = 4;
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CrearUsuario.Location = new System.Drawing.Point(218, 168);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(210, 35);
            this.button_CrearUsuario.TabIndex = 9;
            this.button_CrearUsuario.Text = "Crear";
            this.button_CrearUsuario.UseVisualStyleBackColor = true;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // tab_EliminarEmpresa
            // 
            this.tab_EliminarEmpresa.Controls.Add(this.tableLayoutPanel3);
            this.tab_EliminarEmpresa.Location = new System.Drawing.Point(4, 26);
            this.tab_EliminarEmpresa.Name = "tab_EliminarEmpresa";
            this.tab_EliminarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EliminarEmpresa.Size = new System.Drawing.Size(524, 358);
            this.tab_EliminarEmpresa.TabIndex = 1;
            this.tab_EliminarEmpresa.Text = "Eliminar empresa";
            this.tab_EliminarEmpresa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_IDempresa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(518, 177);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID empresa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_IDempresa
            // 
            this.textBox_IDempresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IDempresa.Location = new System.Drawing.Point(219, 33);
            this.textBox_IDempresa.Name = "textBox_IDempresa";
            this.textBox_IDempresa.Size = new System.Drawing.Size(209, 22);
            this.textBox_IDempresa.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(217, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tab_ListaEmpresas
            // 
            this.tab_ListaEmpresas.Controls.Add(this.tableLayoutPanel1);
            this.tab_ListaEmpresas.Location = new System.Drawing.Point(4, 26);
            this.tab_ListaEmpresas.Name = "tab_ListaEmpresas";
            this.tab_ListaEmpresas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ListaEmpresas.Size = new System.Drawing.Size(524, 358);
            this.tab_ListaEmpresas.TabIndex = 2;
            this.tab_ListaEmpresas.Text = "Lista de negocios";
            this.tab_ListaEmpresas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.756098F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.2439F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.63415F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.36585F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(156, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar Empresas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(53, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.46718F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 73);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion de la empresa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_DescripcionEmpresa
            // 
            this.textBox_DescripcionEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DescripcionEmpresa.Location = new System.Drawing.Point(219, 98);
            this.textBox_DescripcionEmpresa.Name = "textBox_DescripcionEmpresa";
            this.textBox_DescripcionEmpresa.Size = new System.Drawing.Size(209, 22);
            this.textBox_DescripcionEmpresa.TabIndex = 11;
            // 
            // Negocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "Negocios";
            this.Size = new System.Drawing.Size(532, 388);
            this.tabControl1.ResumeLayout(false);
            this.tab_NuevaEmpresa.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tab_EliminarEmpresa.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tab_ListaEmpresas.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tab_ListaEmpresas;
        private System.Windows.Forms.TabPage tab_EliminarEmpresa;
        private System.Windows.Forms.TabPage tab_NuevaEmpresa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DescripcionEmpresa;
        private System.Windows.Forms.TextBox textBox_NombreEmpresa;
        private System.Windows.Forms.TextBox textBox_IDempresa;
    }
}