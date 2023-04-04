namespace DrugStore
{
    partial class FAddKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddKhachHang));
            this.pb_add_kh = new System.Windows.Forms.PictureBox();
            this.tb_phone_add = new System.Windows.Forms.TextBox();
            this.tb_name_add = new System.Windows.Forms.TextBox();
            this.pb_btn_add = new System.Windows.Forms.PictureBox();
            this.pb_btn_edit = new System.Windows.Forms.PictureBox();
            this.lb_msg_phone = new System.Windows.Forms.Label();
            this.lb_msg_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_add_kh
            // 
            this.pb_add_kh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_add_kh.Image = ((System.Drawing.Image)(resources.GetObject("pb_add_kh.Image")));
            this.pb_add_kh.Location = new System.Drawing.Point(0, 0);
            this.pb_add_kh.Name = "pb_add_kh";
            this.pb_add_kh.Size = new System.Drawing.Size(982, 653);
            this.pb_add_kh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add_kh.TabIndex = 0;
            this.pb_add_kh.TabStop = false;
            // 
            // tb_phone_add
            // 
            this.tb_phone_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tb_phone_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone_add.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_phone_add.Location = new System.Drawing.Point(365, 284);
            this.tb_phone_add.Name = "tb_phone_add";
            this.tb_phone_add.Size = new System.Drawing.Size(264, 34);
            this.tb_phone_add.TabIndex = 1;
            // 
            // tb_name_add
            // 
            this.tb_name_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tb_name_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name_add.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name_add.Location = new System.Drawing.Point(365, 481);
            this.tb_name_add.Name = "tb_name_add";
            this.tb_name_add.Size = new System.Drawing.Size(264, 34);
            this.tb_name_add.TabIndex = 2;
            // 
            // pb_btn_add
            // 
            this.pb_btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_btn_add.Image = ((System.Drawing.Image)(resources.GetObject("pb_btn_add.Image")));
            this.pb_btn_add.Location = new System.Drawing.Point(391, 581);
            this.pb_btn_add.Name = "pb_btn_add";
            this.pb_btn_add.Size = new System.Drawing.Size(180, 60);
            this.pb_btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_btn_add.TabIndex = 3;
            this.pb_btn_add.TabStop = false;
            this.pb_btn_add.Click += new System.EventHandler(this.pb_btn_add_Click);
            // 
            // pb_btn_edit
            // 
            this.pb_btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("pb_btn_edit.Image")));
            this.pb_btn_edit.Location = new System.Drawing.Point(391, 581);
            this.pb_btn_edit.Name = "pb_btn_edit";
            this.pb_btn_edit.Size = new System.Drawing.Size(180, 60);
            this.pb_btn_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_btn_edit.TabIndex = 4;
            this.pb_btn_edit.TabStop = false;
            this.pb_btn_edit.Click += new System.EventHandler(this.pb_btn_edit_Click);
            // 
            // lb_msg_phone
            // 
            this.lb_msg_phone.AutoSize = true;
            this.lb_msg_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_msg_phone.ForeColor = System.Drawing.Color.Red;
            this.lb_msg_phone.Location = new System.Drawing.Point(365, 338);
            this.lb_msg_phone.Name = "lb_msg_phone";
            this.lb_msg_phone.Size = new System.Drawing.Size(224, 28);
            this.lb_msg_phone.TabIndex = 5;
            this.lb_msg_phone.Text = "Số điện thoại chưa nhập";
            // 
            // lb_msg_name
            // 
            this.lb_msg_name.AutoSize = true;
            this.lb_msg_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_msg_name.ForeColor = System.Drawing.Color.Red;
            this.lb_msg_name.Location = new System.Drawing.Point(358, 536);
            this.lb_msg_name.Name = "lb_msg_name";
            this.lb_msg_name.Size = new System.Drawing.Size(242, 28);
            this.lb_msg_name.TabIndex = 6;
            this.lb_msg_name.Text = "Tên khách hàng chưa nhập";
            // 
            // FAddKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lb_msg_name);
            this.Controls.Add(this.lb_msg_phone);
            this.Controls.Add(this.pb_btn_edit);
            this.Controls.Add(this.pb_btn_add);
            this.Controls.Add(this.tb_name_add);
            this.Controls.Add(this.tb_phone_add);
            this.Controls.Add(this.pb_add_kh);
            this.Name = "FAddKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddKhachHang";
            this.Load += new System.EventHandler(this.FAddKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_add_kh;
        private TextBox tb_phone_add;
        private TextBox tb_name_add;
        private PictureBox pb_btn_add;
        private PictureBox pb_btn_edit;
        private Label lb_msg_phone;
        private Label lb_msg_name;
    }
}