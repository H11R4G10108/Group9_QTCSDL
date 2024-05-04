namespace Swing
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.anh_cao = new Guna.UI.WinForms.GunaPictureBox();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.pass = new Guna.UI.WinForms.GunaTextBox();
            this.Ma_label = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.nut_login = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.anh_cao)).BeginInit();
            this.SuspendLayout();
            // 
            // anh_cao
            // 
            this.anh_cao.BaseColor = System.Drawing.Color.White;
            this.anh_cao.Image = ((System.Drawing.Image)(resources.GetObject("anh_cao.Image")));
            this.anh_cao.Location = new System.Drawing.Point(221, 54);
            this.anh_cao.Name = "anh_cao";
            this.anh_cao.Size = new System.Drawing.Size(135, 138);
            this.anh_cao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.anh_cao.TabIndex = 0;
            this.anh_cao.TabStop = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.White;
            this.username.BorderColor = System.Drawing.Color.SlateBlue;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.username.Location = new System.Drawing.Point(113, 277);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 10;
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(374, 43);
            this.username.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.BaseColor = System.Drawing.Color.White;
            this.pass.BorderColor = System.Drawing.Color.SlateBlue;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.FocusedBaseColor = System.Drawing.Color.White;
            this.pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pass.Location = new System.Drawing.Point(113, 378);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Radius = 10;
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(374, 43);
            this.pass.TabIndex = 2;
            // 
            // Ma_label
            // 
            this.Ma_label.AutoSize = true;
            this.Ma_label.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ma_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.Ma_label.Location = new System.Drawing.Point(119, 244);
            this.Ma_label.Name = "Ma_label";
            this.Ma_label.Size = new System.Drawing.Size(150, 27);
            this.Ma_label.TabIndex = 7;
            this.Ma_label.Text = "Tên đăng nhập";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(119, 345);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(101, 27);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Mật khẩu";
            // 
            // nut_login
            // 
            this.nut_login.Animated = true;
            this.nut_login.AnimationHoverSpeed = 0.07F;
            this.nut_login.AnimationSpeed = 0.03F;
            this.nut_login.BackColor = System.Drawing.Color.Transparent;
            this.nut_login.BaseColor = System.Drawing.Color.SlateBlue;
            this.nut_login.BorderColor = System.Drawing.Color.Transparent;
            this.nut_login.CheckedBaseColor = System.Drawing.Color.Gray;
            this.nut_login.CheckedBorderColor = System.Drawing.Color.Black;
            this.nut_login.CheckedForeColor = System.Drawing.Color.Black;
            this.nut_login.CheckedImage = null;
            this.nut_login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.nut_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nut_login.FocusedColor = System.Drawing.Color.Empty;
            this.nut_login.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nut_login.ForeColor = System.Drawing.Color.White;
            this.nut_login.Image = null;
            this.nut_login.ImageSize = new System.Drawing.Size(20, 20);
            this.nut_login.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nut_login.Location = new System.Drawing.Point(113, 460);
            this.nut_login.Name = "nut_login";
            this.nut_login.OnHoverBaseColor = System.Drawing.Color.DarkSlateBlue;
            this.nut_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nut_login.OnHoverForeColor = System.Drawing.Color.White;
            this.nut_login.OnHoverImage = null;
            this.nut_login.OnHoverLineColor = System.Drawing.Color.BlueViolet;
            this.nut_login.OnPressedColor = System.Drawing.Color.Black;
            this.nut_login.Radius = 15;
            this.nut_login.Size = new System.Drawing.Size(374, 42);
            this.nut_login.TabIndex = 16;
            this.nut_login.Text = "Đăng nhập";
            this.nut_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nut_login.Click += new System.EventHandler(this.gunaAdvenceButton15_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 599);
            this.Controls.Add(this.nut_login);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Ma_label);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.anh_cao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh_cao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox anh_cao;
        private Guna.UI.WinForms.GunaTextBox username;
        private Guna.UI.WinForms.GunaTextBox pass;
        private Guna.UI.WinForms.GunaLabel Ma_label;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton nut_login;
    }
}