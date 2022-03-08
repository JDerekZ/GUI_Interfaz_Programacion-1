namespace GUI_Assignment_1
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbxUser = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnLogin, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TbxUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbxPassword, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.64077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.72251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.LblLogin, 2);
            this.LblLogin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLogin.Location = new System.Drawing.Point(3, 15);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(318, 24);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "INICIAR SESIÓN";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUser
            // 
            this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Torque Sense", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUser.Location = new System.Drawing.Point(99, 63);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(60, 15);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuario:";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Torque Sense", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPassword.Location = new System.Drawing.Point(87, 102);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(72, 15);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password:";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnLogin, 2);
            this.BtnLogin.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(25, 150);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(274, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbxUser
            // 
            this.TbxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxUser.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUser.Location = new System.Drawing.Point(165, 53);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(109, 22);
            this.TbxUser.TabIndex = 4;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(165, 92);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.PasswordChar = '*';
            this.TbxPassword.Size = new System.Drawing.Size(109, 22);
            this.TbxPassword.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 197);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbxUser;
        private System.Windows.Forms.TextBox TbxPassword;
    }
}

