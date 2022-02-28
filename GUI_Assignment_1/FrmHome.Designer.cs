namespace GUI_Assignment_1
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.TblMainHome = new System.Windows.Forms.TableLayoutPanel();
            this.TbxNewPassword = new System.Windows.Forms.TextBox();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.Lblinfo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TbxNewUser = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TblMainHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblMainHome
            // 
            this.TblMainHome.BackColor = System.Drawing.Color.Transparent;
            this.TblMainHome.ColumnCount = 2;
            this.TblMainHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblMainHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblMainHome.Controls.Add(this.TbxNewPassword, 1, 3);
            this.TblMainHome.Controls.Add(this.LblWelcome, 0, 0);
            this.TblMainHome.Controls.Add(this.Lblinfo, 0, 1);
            this.TblMainHome.Controls.Add(this.lblUser, 0, 2);
            this.TblMainHome.Controls.Add(this.lblPassword, 0, 3);
            this.TblMainHome.Controls.Add(this.TbxNewUser, 1, 2);
            this.TblMainHome.Controls.Add(this.BtnGuardar, 0, 4);
            this.TblMainHome.Controls.Add(this.dataGridView1, 0, 5);
            this.TblMainHome.Controls.Add(this.label1, 0, 6);
            this.TblMainHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMainHome.Location = new System.Drawing.Point(0, 0);
            this.TblMainHome.Name = "TblMainHome";
            this.TblMainHome.RowCount = 7;
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61972F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.070423F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52113F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.23944F));
            this.TblMainHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.323944F));
            this.TblMainHome.Size = new System.Drawing.Size(515, 355);
            this.TblMainHome.TabIndex = 0;
            // 
            // TbxNewPassword
            // 
            this.TbxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbxNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxNewPassword.Location = new System.Drawing.Point(260, 137);
            this.TbxNewPassword.Name = "TbxNewPassword";
            this.TbxNewPassword.Size = new System.Drawing.Size(138, 20);
            this.TbxNewPassword.TabIndex = 5;
            // 
            // LblWelcome
            // 
            this.LblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWelcome.AutoSize = true;
            this.TblMainHome.SetColumnSpan(this.LblWelcome, 2);
            this.LblWelcome.Font = new System.Drawing.Font("Torque Sense", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblWelcome.Location = new System.Drawing.Point(3, 0);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(509, 59);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Bienvenido(a)";
            this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblinfo
            // 
            this.Lblinfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lblinfo.AutoSize = true;
            this.TblMainHome.SetColumnSpan(this.Lblinfo, 2);
            this.Lblinfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lblinfo.Location = new System.Drawing.Point(116, 64);
            this.Lblinfo.Name = "Lblinfo";
            this.Lblinfo.Size = new System.Drawing.Size(282, 13);
            this.Lblinfo.TabIndex = 1;
            this.Lblinfo.Text = "*Complete el formulario para poder registrarse en el sitema*";
            this.Lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Torque Sense", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblUser.Location = new System.Drawing.Point(137, 112);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(117, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Nombre de Usuario:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Torque Sense", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPassword.Location = new System.Drawing.Point(131, 147);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password de Cuenta:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbxNewUser
            // 
            this.TbxNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbxNewUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxNewUser.Location = new System.Drawing.Point(260, 102);
            this.TbxNewUser.Name = "TbxNewUser";
            this.TbxNewUser.Size = new System.Drawing.Size(138, 20);
            this.TbxNewUser.TabIndex = 4;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TblMainHome.SetColumnSpan(this.BtnGuardar, 2);
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Torque Sense", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnGuardar.Location = new System.Drawing.Point(208, 182);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(99, 25);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.TblMainHome.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(3, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "*↑↑ Usuarios Registrados Actualmente ↑↑*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblMainHome.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(40, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(435, 112);
            this.dataGridView1.TabIndex = 7;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(515, 355);
            this.Controls.Add(this.TblMainHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.TblMainHome.ResumeLayout(false);
            this.TblMainHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblMainHome;
        private System.Windows.Forms.TextBox TbxNewPassword;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label Lblinfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TbxNewUser;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}