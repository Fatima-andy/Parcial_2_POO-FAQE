using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class Usuarios
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
            this.tab_NuevoUsuario = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Contraseña = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TipodeUsuario = new System.Windows.Forms.ComboBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            this.tab_EliminarUsuario = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ContraseñaEliminar = new System.Windows.Forms.TextBox();
            this.textBox_UsuarioEliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_idUsuario = new System.Windows.Forms.TextBox();
            this.button_EliminarUsuario = new System.Windows.Forms.Button();
            this.tab_VerUsuarios = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_CargarUsuarios = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_NuevoUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_EliminarUsuario.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_VerUsuarios.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_NuevoUsuario);
            this.tabControl1.Controls.Add(this.tab_EliminarUsuario);
            this.tabControl1.Controls.Add(this.tab_VerUsuarios);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_NuevoUsuario
            // 
            this.tab_NuevoUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_NuevoUsuario.Controls.Add(this.tableLayoutPanel1);
            this.tab_NuevoUsuario.Location = new System.Drawing.Point(4, 26);
            this.tab_NuevoUsuario.Name = "tab_NuevoUsuario";
            this.tab_NuevoUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NuevoUsuario.Size = new System.Drawing.Size(546, 331);
            this.tab_NuevoUsuario.TabIndex = 0;
            this.tab_NuevoUsuario.Text = "Nuevo usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96296F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03704F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Contraseña, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Usuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_TipodeUsuario, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Nombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_CrearUsuario, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.15385F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.53846F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.69231F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.30769F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Contraseña
            // 
            this.textBox_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Contraseña.Location = new System.Drawing.Point(239, 141);
            this.textBox_Contraseña.Name = "textBox_Contraseña";
            this.textBox_Contraseña.Size = new System.Drawing.Size(212, 22);
            this.textBox_Contraseña.TabIndex = 7;
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Usuario.Location = new System.Drawing.Point(238, 83);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(213, 22);
            this.textBox_Usuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de usuario:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_TipodeUsuario
            // 
            this.comboBox_TipodeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TipodeUsuario.FormattingEnabled = true;
            this.comboBox_TipodeUsuario.Location = new System.Drawing.Point(238, 200);
            this.comboBox_TipodeUsuario.Name = "comboBox_TipodeUsuario";
            this.comboBox_TipodeUsuario.Size = new System.Drawing.Size(213, 25);
            this.comboBox_TipodeUsuario.TabIndex = 4;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Nombre.Location = new System.Drawing.Point(239, 21);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(212, 22);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CrearUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_CrearUsuario.BackColor = System.Drawing.Color.DimGray;
            this.button_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CrearUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_CrearUsuario.Location = new System.Drawing.Point(239, 260);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(212, 50);
            this.button_CrearUsuario.TabIndex = 8;
            this.button_CrearUsuario.Text = "Crear";
            this.button_CrearUsuario.UseVisualStyleBackColor = false;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // tab_EliminarUsuario
            // 
            this.tab_EliminarUsuario.Controls.Add(this.tableLayoutPanel2);
            this.tab_EliminarUsuario.Location = new System.Drawing.Point(4, 26);
            this.tab_EliminarUsuario.Name = "tab_EliminarUsuario";
            this.tab_EliminarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EliminarUsuario.Size = new System.Drawing.Size(546, 331);
            this.tab_EliminarUsuario.TabIndex = 1;
            this.tab_EliminarUsuario.Text = "Eliminar usuario";
            this.tab_EliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7037F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2963F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_ContraseñaEliminar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_UsuarioEliminar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_idUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_EliminarUsuario, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 320);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox_ContraseñaEliminar
            // 
            this.textBox_ContraseñaEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ContraseñaEliminar.Location = new System.Drawing.Point(249, 189);
            this.textBox_ContraseñaEliminar.Name = "textBox_ContraseñaEliminar";
            this.textBox_ContraseñaEliminar.Size = new System.Drawing.Size(194, 22);
            this.textBox_ContraseñaEliminar.TabIndex = 5;
            // 
            // textBox_UsuarioEliminar
            // 
            this.textBox_UsuarioEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UsuarioEliminar.Location = new System.Drawing.Point(249, 109);
            this.textBox_UsuarioEliminar.Name = "textBox_UsuarioEliminar";
            this.textBox_UsuarioEliminar.Size = new System.Drawing.Size(194, 22);
            this.textBox_UsuarioEliminar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 80);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID usuario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 80);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 80);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contraseña;";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_idUsuario
            // 
            this.textBox_idUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_idUsuario.Location = new System.Drawing.Point(249, 29);
            this.textBox_idUsuario.Name = "textBox_idUsuario";
            this.textBox_idUsuario.Size = new System.Drawing.Size(194, 22);
            this.textBox_idUsuario.TabIndex = 3;
            // 
            // button_EliminarUsuario
            // 
            this.button_EliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_EliminarUsuario.Location = new System.Drawing.Point(240, 255);
            this.button_EliminarUsuario.Name = "button_EliminarUsuario";
            this.button_EliminarUsuario.Size = new System.Drawing.Size(212, 50);
            this.button_EliminarUsuario.TabIndex = 9;
            this.button_EliminarUsuario.Text = "Eliminar";
            this.button_EliminarUsuario.UseVisualStyleBackColor = true;
            this.button_EliminarUsuario.Click += new System.EventHandler(this.button_EliminarUsuario_Click);
            // 
            // tab_VerUsuarios
            // 
            this.tab_VerUsuarios.Controls.Add(this.tableLayoutPanel3);
            this.tab_VerUsuarios.Location = new System.Drawing.Point(4, 26);
            this.tab_VerUsuarios.Name = "tab_VerUsuarios";
            this.tab_VerUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_VerUsuarios.Size = new System.Drawing.Size(546, 331);
            this.tab_VerUsuarios.TabIndex = 2;
            this.tab_VerUsuarios.Text = "Ver usuarios";
            this.tab_VerUsuarios.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92593F));
            this.tableLayoutPanel3.Controls.Add(this.button_CargarUsuarios, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23077F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.76923F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 325);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button_CargarUsuarios
            // 
            this.button_CargarUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CargarUsuarios.Location = new System.Drawing.Point(154, 4);
            this.button_CargarUsuarios.Name = "button_CargarUsuarios";
            this.button_CargarUsuarios.Size = new System.Drawing.Size(232, 35);
            this.button_CargarUsuarios.TabIndex = 0;
            this.button_CargarUsuarios.Text = "Cargar usuarios";
            this.button_CargarUsuarios.UseVisualStyleBackColor = true;
            this.button_CargarUsuarios.Click += new System.EventHandler(this.button_CargarUsuarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(554, 361);
            this.tabControl1.ResumeLayout(false);
            this.tab_NuevoUsuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_EliminarUsuario.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tab_VerUsuarios.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tab_NuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.TabPage tab_EliminarUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_EliminarUsuario;
        private System.Windows.Forms.TabPage tab_VerUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_CargarUsuarios;
        private System.Windows.Forms.TextBox textBox_Contraseña;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.ComboBox comboBox_TipodeUsuario;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_idUsuario;
        private System.Windows.Forms.TextBox textBox_ContraseñaEliminar;
        private System.Windows.Forms.TextBox textBox_UsuarioEliminar;
    }
}