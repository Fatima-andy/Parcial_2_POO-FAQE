using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class AdminForm
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
                new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.button_Users = new System.Windows.Forms.Button();
            this.button_Orders = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Bussiness = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.welcome1 = new Parcial_2_POO.Welcome();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.welcome2 = new Parcial_2_POO.Welcome();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_ChangePassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Users, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Orders, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Products, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_Bussiness, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ChangePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ChangePassword.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_ChangePassword.Location = new System.Drawing.Point(3, 21);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(181, 59);
            this.button_ChangePassword.TabIndex = 0;
            this.button_ChangePassword.Text = "CAMBIAR\r\nCONTRASEÑA";
            this.button_ChangePassword.UseVisualStyleBackColor = false;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // button_Users
            // 
            this.button_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Users.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Users.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Users.Location = new System.Drawing.Point(3, 87);
            this.button_Users.Name = "button_Users";
            this.button_Users.Size = new System.Drawing.Size(181, 59);
            this.button_Users.TabIndex = 1;
            this.button_Users.Text = "USUARIOS";
            this.button_Users.UseVisualStyleBackColor = false;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // button_Orders
            // 
            this.button_Orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Orders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Orders.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Orders.Location = new System.Drawing.Point(3, 153);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Size = new System.Drawing.Size(181, 59);
            this.button_Orders.TabIndex = 2;
            this.button_Orders.Text = "VER ORDENES";
            this.button_Orders.UseVisualStyleBackColor = false;
            this.button_Orders.Click += new System.EventHandler(this.button_Orders_Click);
            // 
            // button_Products
            // 
            this.button_Products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Products.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Products.Location = new System.Drawing.Point(3, 219);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(181, 59);
            this.button_Products.TabIndex = 3;
            this.button_Products.Text = "PRODUCTOS";
            this.button_Products.UseVisualStyleBackColor = false;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Bussiness
            // 
            this.button_Bussiness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Bussiness.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Bussiness.Font = new System.Drawing.Font("Century Gothic", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_Bussiness.Location = new System.Drawing.Point(3, 285);
            this.button_Bussiness.Name = "button_Bussiness";
            this.button_Bussiness.Size = new System.Drawing.Size(181, 59);
            this.button_Bussiness.TabIndex = 4;
            this.button_Bussiness.Text = "NEGOCIOS";
            this.button_Bussiness.UseVisualStyleBackColor = false;
            this.button_Bussiness.Click += new System.EventHandler(this.button_Bussiness_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.welcome1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(188, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 370);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // welcome1
            // 
            this.welcome1.Location = new System.Drawing.Point(3, 3);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(258, 147);
            this.welcome1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.welcome2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(188, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(451, 370);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // welcome2
            // 
            this.welcome2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.welcome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome2.Location = new System.Drawing.Point(3, 3);
            this.welcome2.Name = "welcome2";
            this.welcome2.Size = new System.Drawing.Size(445, 364);
            this.welcome2.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(639, 370);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Admin.Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Parcial_2_POO.Welcome welcome1;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Bussiness;
        private System.Windows.Forms.Button button_Users;
        private System.Windows.Forms.Button button_Orders;
        private System.Windows.Forms.Button button_ChangePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Parcial_2_POO.Welcome welcome2;
    }
}