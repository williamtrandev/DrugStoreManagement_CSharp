namespace DrugStore
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pb_background_form = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_minus = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.pb_phone = new System.Windows.Forms.PictureBox();
            this.pb_pass = new System.Windows.Forms.PictureBox();
            this.lb_msg = new System.Windows.Forms.Label();
            this.lb_validate_phone = new System.Windows.Forms.Label();
            this.lb_validate_pass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background_form
            // 
            this.pb_background_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_background_form.Image = ((System.Drawing.Image)(resources.GetObject("pb_background_form.Image")));
            this.pb_background_form.Location = new System.Drawing.Point(0, 0);
            this.pb_background_form.Name = "pb_background_form";
            this.pb_background_form.Size = new System.Drawing.Size(1049, 553);
            this.pb_background_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background_form.TabIndex = 0;
            this.pb_background_form.TabStop = false;
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.Transparent;
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(997, 12);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(40, 40);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 1;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click_1);
            // 
            // pb_minus
            // 
            this.pb_minus.BackColor = System.Drawing.Color.Transparent;
            this.pb_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minus.Image = ((System.Drawing.Image)(resources.GetObject("pb_minus.Image")));
            this.pb_minus.Location = new System.Drawing.Point(949, 6);
            this.pb_minus.Name = "pb_minus";
            this.pb_minus.Size = new System.Drawing.Size(30, 50);
            this.pb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minus.TabIndex = 2;
            this.pb_minus.TabStop = false;
            this.pb_minus.Click += new System.EventHandler(this.pb_minus_Click_1);
            // 
            // pb_login
            // 
            this.pb_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_login.Image = ((System.Drawing.Image)(resources.GetObject("pb_login.Image")));
            this.pb_login.Location = new System.Drawing.Point(712, 422);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(180, 60);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 3;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pb_login_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone.Location = new System.Drawing.Point(710, 186);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PlaceholderText = "Số điện thoại";
            this.tb_phone.Size = new System.Drawing.Size(240, 34);
            this.tb_phone.TabIndex = 4;
            this.tb_phone.Click += new System.EventHandler(this.tb_phone_Click);
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_pass.Location = new System.Drawing.Point(710, 301);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PlaceholderText = "Mật khẩu";
            this.tb_pass.Size = new System.Drawing.Size(240, 34);
            this.tb_pass.TabIndex = 5;
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.Click += new System.EventHandler(this.tb_pass_Click);
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // pb_phone
            // 
            this.pb_phone.Image = ((System.Drawing.Image)(resources.GetObject("pb_phone.Image")));
            this.pb_phone.Location = new System.Drawing.Point(648, 184);
            this.pb_phone.Name = "pb_phone";
            this.pb_phone.Size = new System.Drawing.Size(40, 40);
            this.pb_phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_phone.TabIndex = 6;
            this.pb_phone.TabStop = false;
            // 
            // pb_pass
            // 
            this.pb_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_pass.Image = ((System.Drawing.Image)(resources.GetObject("pb_pass.Image")));
            this.pb_pass.Location = new System.Drawing.Point(648, 299);
            this.pb_pass.Name = "pb_pass";
            this.pb_pass.Size = new System.Drawing.Size(40, 40);
            this.pb_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pass.TabIndex = 7;
            this.pb_pass.TabStop = false;
            this.pb_pass.Click += new System.EventHandler(this.pb_pass_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_msg.ForeColor = System.Drawing.Color.Red;
            this.lb_msg.Location = new System.Drawing.Point(619, 372);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(0, 35);
            this.lb_msg.TabIndex = 8;
            // 
            // lb_validate_phone
            // 
            this.lb_validate_phone.AutoSize = true;
            this.lb_validate_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_phone.ForeColor = System.Drawing.Color.Red;
            this.lb_validate_phone.Location = new System.Drawing.Point(693, 232);
            this.lb_validate_phone.Name = "lb_validate_phone";
            this.lb_validate_phone.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_phone.TabIndex = 9;
            // 
            // lb_validate_pass
            // 
            this.lb_validate_pass.AutoSize = true;
            this.lb_validate_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate_pass.ForeColor = System.Drawing.Color.Red;
            this.lb_validate_pass.Location = new System.Drawing.Point(707, 349);
            this.lb_validate_pass.Name = "lb_validate_pass";
            this.lb_validate_pass.Size = new System.Drawing.Size(0, 28);
            this.lb_validate_pass.TabIndex = 10;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 553);
            this.Controls.Add(this.lb_validate_pass);
            this.Controls.Add(this.lb_validate_phone);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.pb_pass);
            this.Controls.Add(this.pb_phone);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.pb_minus);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.pb_background_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_background_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_background_form;
        private PictureBox pb_close;
        private PictureBox pb_minus;
        private PictureBox pb_login;
        private TextBox tb_phone;
        private TextBox tb_pass;
        private PictureBox pb_phone;
        private PictureBox pb_pass;
        private Label lb_msg;
        private Label lb_validate_phone;
        private Label lb_validate_pass;
    }
}