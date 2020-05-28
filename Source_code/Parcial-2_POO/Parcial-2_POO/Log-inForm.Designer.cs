using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class Log_inForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Log_inForm));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.IniciarSesion_button = new System.Windows.Forms.Button();
            this.Contraseña_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IniciarSesion_button, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG-IN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // IniciarSesion_button
            // 
            this.IniciarSesion_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IniciarSesion_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IniciarSesion_button.BackColor = System.Drawing.Color.DimGray;
            this.IniciarSesion_button.FlatAppearance.BorderSize = 0;
            this.IniciarSesion_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.IniciarSesion_button.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                    ((int) (((byte) (64)))));
            this.IniciarSesion_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion_button.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.IniciarSesion_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IniciarSesion_button.Location = new System.Drawing.Point(3, 62);
            this.IniciarSesion_button.Name = "IniciarSesion_button";
            this.IniciarSesion_button.Size = new System.Drawing.Size(194, 47);
            this.IniciarSesion_button.TabIndex = 2;
            this.IniciarSesion_button.Text = "INICIAR SESION";
            this.IniciarSesion_button.UseVisualStyleBackColor = false;
            // 
            // Contraseña_textBox
            // 
            this.Contraseña_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contraseña_textBox.BackColor = System.Drawing.Color.Black;
            this.Contraseña_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contraseña_textBox.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Contraseña_textBox.ForeColor = System.Drawing.Color.DimGray;
            this.Contraseña_textBox.Location = new System.Drawing.Point(3, 62);
            this.Contraseña_textBox.Name = "Contraseña_textBox";
            this.Contraseña_textBox.Size = new System.Drawing.Size(194, 22);
            this.Contraseña_textBox.TabIndex = 0;
            this.Contraseña_textBox.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Log_inForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 379);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Log_inForm";
            this.Text = "Log_inForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox Contraseña_textBox;
        private System.Windows.Forms.Button IniciarSesion_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}