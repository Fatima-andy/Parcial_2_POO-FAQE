using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class PasswordChange
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewPassword_textbox = new System.Windows.Forms.TextBox();
            this.OldPassword_textbox = new System.Windows.Forms.TextBox();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.AcceptPasswordChange_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.15823F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.84177F));
            this.tableLayoutPanel1.Controls.Add(this.NewPassword_textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OldPassword_textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserName_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AcceptPasswordChange_button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NewPassword_textbox
            // 
            this.NewPassword_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPassword_textbox.BackColor = System.Drawing.Color.Black;
            this.NewPassword_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPassword_textbox.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.NewPassword_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.NewPassword_textbox.Location = new System.Drawing.Point(246, 221);
            this.NewPassword_textbox.Name = "NewPassword_textbox";
            this.NewPassword_textbox.Size = new System.Drawing.Size(299, 22);
            this.NewPassword_textbox.TabIndex = 7;
            // 
            // OldPassword_textbox
            // 
            this.OldPassword_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OldPassword_textbox.BackColor = System.Drawing.Color.Black;
            this.OldPassword_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldPassword_textbox.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.OldPassword_textbox.ForeColor = System.Drawing.Color.DimGray;
            this.OldPassword_textbox.Location = new System.Drawing.Point(246, 128);
            this.OldPassword_textbox.Name = "OldPassword_textbox";
            this.OldPassword_textbox.Size = new System.Drawing.Size(299, 22);
            this.OldPassword_textbox.TabIndex = 6;
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName_textBox.BackColor = System.Drawing.Color.Black;
            this.UserName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_textBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.UserName_textBox.ForeColor = System.Drawing.Color.DimGray;
            this.UserName_textBox.Location = new System.Drawing.Point(246, 35);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(299, 22);
            this.UserName_textBox.TabIndex = 5;
            // 
            // AcceptPasswordChange_button
            // 
            this.AcceptPasswordChange_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptPasswordChange_button.BackColor = System.Drawing.Color.DimGray;
            this.AcceptPasswordChange_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptPasswordChange_button.Font = new System.Drawing.Font("Century Gothic", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AcceptPasswordChange_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AcceptPasswordChange_button.Location = new System.Drawing.Point(258, 306);
            this.AcceptPasswordChange_button.Name = "AcceptPasswordChange_button";
            this.AcceptPasswordChange_button.Size = new System.Drawing.Size(275, 42);
            this.AcceptPasswordChange_button.TabIndex = 0;
            this.AcceptPasswordChange_button.Text = "CAMBIARCONTRASEÑA";
            this.AcceptPasswordChange_button.UseVisualStyleBackColor = false;
            this.AcceptPasswordChange_button.Click += new System.EventHandler(this.AcceptPasswordChange_button_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA ACTUAL:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 93);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUEVA CONTRASEÑA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PasswordChange";
            this.Size = new System.Drawing.Size(632, 375);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.TextBox OldPassword_textbox;
        private System.Windows.Forms.TextBox NewPassword_textbox;
        private System.Windows.Forms.Button AcceptPasswordChange_button;
    }
}