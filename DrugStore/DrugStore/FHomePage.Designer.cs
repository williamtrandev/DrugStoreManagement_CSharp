namespace DrugStore
{
    public partial class FHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_pharmacy = new System.Windows.Forms.Label();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.pnl_leftsidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_designer = new System.Windows.Forms.Label();
            this.lbl_drugstore = new System.Windows.Forms.Label();
            this.pnl_onqlnv = new System.Windows.Forms.Panel();
            this.btn_qlnv = new System.Windows.Forms.Button();
            this.pnl_onqlnh = new System.Windows.Forms.Panel();
            this.btn_qlnh = new System.Windows.Forms.Button();
            this.pnl_onqlbh = new System.Windows.Forms.Panel();
            this.btn_qlbh = new System.Windows.Forms.Button();
            this.pnl_onbcthuoc = new System.Windows.Forms.Panel();
            this.btn_bcthuoc = new System.Windows.Forms.Button();
            this.pnl_onbcdoanhthu = new System.Windows.Forms.Panel();
            this.btn_bcdoanhthu = new System.Windows.Forms.Button();
            this.pnl_topdock = new System.Windows.Forms.Panel();
            this.pnl_qlnv = new System.Windows.Forms.Panel();
            this.lbl_dsnv = new System.Windows.Forms.Label();
            this.pnl_dsnv = new System.Windows.Forms.Panel();
            this.tab_nv = new System.Windows.Forms.DataGridView();
            this.btn_xoanv = new System.Windows.Forms.Button();
            this.btn_suanv = new System.Windows.Forms.Button();
            this.btn_themnv = new System.Windows.Forms.Button();
            this.pnl_noidung = new System.Windows.Forms.Panel();
            this.pl_bcthuoc = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.lb_dsthuoc = new System.Windows.Forms.Label();
            this.pl_dsthuoc = new System.Windows.Forms.Panel();
            this.tab_dsthuoc = new System.Windows.Forms.DataGridView();
            this.btn_xoathuoc = new System.Windows.Forms.Button();
            this.btn_suathuoc = new System.Windows.Forms.Button();
            this.btn_themthuoc = new System.Windows.Forms.Button();
            this.btn_bcthuochh = new System.Windows.Forms.Button();
            this.btn_bcthuocsaphet = new System.Windows.Forms.Button();
            this.pnl_leftsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_topdock.SuspendLayout();
            this.pnl_qlnv.SuspendLayout();
            this.pnl_dsnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_nv)).BeginInit();
            this.pnl_noidung.SuspendLayout();
            this.pl_bcthuoc.SuspendLayout();
            this.pl_dsthuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_dsthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pharmacy
            // 
            this.lbl_pharmacy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pharmacy.AutoSize = true;
            this.lbl_pharmacy.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_pharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pharmacy.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_pharmacy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_pharmacy.Location = new System.Drawing.Point(23, 34);
            this.lbl_pharmacy.Name = "lbl_pharmacy";
            this.lbl_pharmacy.Size = new System.Drawing.Size(194, 36);
            this.lbl_pharmacy.TabIndex = 4;
            this.lbl_pharmacy.Text = "PHARMACY";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dangxuat.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_dangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangxuat.Image")));
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(972, 0);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(172, 62);
            this.btn_dangxuat.TabIndex = 2;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // pnl_leftsidebar
            // 
            this.pnl_leftsidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_leftsidebar.Controls.Add(this.label1);
            this.pnl_leftsidebar.Controls.Add(this.pictureBox1);
            this.pnl_leftsidebar.Controls.Add(this.lb_designer);
            this.pnl_leftsidebar.Controls.Add(this.lbl_pharmacy);
            this.pnl_leftsidebar.Controls.Add(this.lbl_drugstore);
            this.pnl_leftsidebar.Controls.Add(this.pnl_onqlnv);
            this.pnl_leftsidebar.Controls.Add(this.btn_qlnv);
            this.pnl_leftsidebar.Controls.Add(this.pnl_onqlnh);
            this.pnl_leftsidebar.Controls.Add(this.btn_qlnh);
            this.pnl_leftsidebar.Controls.Add(this.pnl_onqlbh);
            this.pnl_leftsidebar.Controls.Add(this.btn_qlbh);
            this.pnl_leftsidebar.Controls.Add(this.pnl_onbcthuoc);
            this.pnl_leftsidebar.Controls.Add(this.btn_bcthuoc);
            this.pnl_leftsidebar.Controls.Add(this.pnl_onbcdoanhthu);
            this.pnl_leftsidebar.Controls.Add(this.btn_bcdoanhthu);
            this.pnl_leftsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_leftsidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_leftsidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_leftsidebar.Name = "pnl_leftsidebar";
            this.pnl_leftsidebar.Size = new System.Drawing.Size(315, 955);
            this.pnl_leftsidebar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(86, 880);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "LTTN Team";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 839);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lb_designer
            // 
            this.lb_designer.AutoSize = true;
            this.lb_designer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_designer.ForeColor = System.Drawing.Color.Lime;
            this.lb_designer.Location = new System.Drawing.Point(4, 884);
            this.lb_designer.Name = "lb_designer";
            this.lb_designer.Size = new System.Drawing.Size(90, 23);
            this.lb_designer.TabIndex = 10;
            this.lb_designer.Text = "Design by ";
            // 
            // lbl_drugstore
            // 
            this.lbl_drugstore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_drugstore.AutoSize = true;
            this.lbl_drugstore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_drugstore.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_drugstore.Location = new System.Drawing.Point(111, 79);
            this.lbl_drugstore.Name = "lbl_drugstore";
            this.lbl_drugstore.Size = new System.Drawing.Size(106, 25);
            this.lbl_drugstore.TabIndex = 5;
            this.lbl_drugstore.Text = "Drug Store";
            // 
            // pnl_onqlnv
            // 
            this.pnl_onqlnv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_onqlnv.Location = new System.Drawing.Point(0, 135);
            this.pnl_onqlnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_onqlnv.Name = "pnl_onqlnv";
            this.pnl_onqlnv.Size = new System.Drawing.Size(15, 64);
            this.pnl_onqlnv.TabIndex = 6;
            // 
            // btn_qlnv
            // 
            this.btn_qlnv.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_qlnv.FlatAppearance.BorderSize = 0;
            this.btn_qlnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_qlnv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlnv.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlnv.Image")));
            this.btn_qlnv.Location = new System.Drawing.Point(0, 135);
            this.btn_qlnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_qlnv.Name = "btn_qlnv";
            this.btn_qlnv.Size = new System.Drawing.Size(315, 64);
            this.btn_qlnv.TabIndex = 0;
            this.btn_qlnv.Text = "Quản lý nhân viên";
            this.btn_qlnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qlnv.UseVisualStyleBackColor = false;
            this.btn_qlnv.Click += new System.EventHandler(this.btn_qlnv_Click);
            // 
            // pnl_onqlnh
            // 
            this.pnl_onqlnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_onqlnh.Location = new System.Drawing.Point(0, 219);
            this.pnl_onqlnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_onqlnh.Name = "pnl_onqlnh";
            this.pnl_onqlnh.Size = new System.Drawing.Size(15, 64);
            this.pnl_onqlnh.TabIndex = 7;
            // 
            // btn_qlnh
            // 
            this.btn_qlnh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_qlnh.FlatAppearance.BorderSize = 0;
            this.btn_qlnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_qlnh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlnh.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlnh.Image")));
            this.btn_qlnh.Location = new System.Drawing.Point(0, 219);
            this.btn_qlnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_qlnh.Name = "btn_qlnh";
            this.btn_qlnh.Size = new System.Drawing.Size(315, 64);
            this.btn_qlnh.TabIndex = 1;
            this.btn_qlnh.Text = "Quản lý nhập hàng";
            this.btn_qlnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qlnh.UseVisualStyleBackColor = false;
            this.btn_qlnh.Click += new System.EventHandler(this.btn_qlnh_Click);
            // 
            // pnl_onqlbh
            // 
            this.pnl_onqlbh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_onqlbh.Location = new System.Drawing.Point(0, 302);
            this.pnl_onqlbh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_onqlbh.Name = "pnl_onqlbh";
            this.pnl_onqlbh.Size = new System.Drawing.Size(15, 64);
            this.pnl_onqlbh.TabIndex = 7;
            // 
            // btn_qlbh
            // 
            this.btn_qlbh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_qlbh.FlatAppearance.BorderSize = 0;
            this.btn_qlbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_qlbh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlbh.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlbh.Image")));
            this.btn_qlbh.Location = new System.Drawing.Point(0, 302);
            this.btn_qlbh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_qlbh.Name = "btn_qlbh";
            this.btn_qlbh.Size = new System.Drawing.Size(315, 64);
            this.btn_qlbh.TabIndex = 2;
            this.btn_qlbh.Text = "Quản lý bán hàng";
            this.btn_qlbh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qlbh.UseVisualStyleBackColor = false;
            this.btn_qlbh.Click += new System.EventHandler(this.btn_qlbh_Click);
            // 
            // pnl_onbcthuoc
            // 
            this.pnl_onbcthuoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_onbcthuoc.Location = new System.Drawing.Point(0, 386);
            this.pnl_onbcthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_onbcthuoc.Name = "pnl_onbcthuoc";
            this.pnl_onbcthuoc.Size = new System.Drawing.Size(15, 64);
            this.pnl_onbcthuoc.TabIndex = 7;
            // 
            // btn_bcthuoc
            // 
            this.btn_bcthuoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_bcthuoc.FlatAppearance.BorderSize = 0;
            this.btn_bcthuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bcthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bcthuoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bcthuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_bcthuoc.Image")));
            this.btn_bcthuoc.Location = new System.Drawing.Point(0, 386);
            this.btn_bcthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bcthuoc.Name = "btn_bcthuoc";
            this.btn_bcthuoc.Size = new System.Drawing.Size(315, 64);
            this.btn_bcthuoc.TabIndex = 3;
            this.btn_bcthuoc.Text = "Báo cáo thuốc";
            this.btn_bcthuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bcthuoc.UseVisualStyleBackColor = false;
            this.btn_bcthuoc.Click += new System.EventHandler(this.btn_bcthuoc_Click);
            // 
            // pnl_onbcdoanhthu
            // 
            this.pnl_onbcdoanhthu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_onbcdoanhthu.Location = new System.Drawing.Point(0, 471);
            this.pnl_onbcdoanhthu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_onbcdoanhthu.Name = "pnl_onbcdoanhthu";
            this.pnl_onbcdoanhthu.Size = new System.Drawing.Size(15, 64);
            this.pnl_onbcdoanhthu.TabIndex = 9;
            // 
            // btn_bcdoanhthu
            // 
            this.btn_bcdoanhthu.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_bcdoanhthu.FlatAppearance.BorderSize = 0;
            this.btn_bcdoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bcdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bcdoanhthu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bcdoanhthu.Image = ((System.Drawing.Image)(resources.GetObject("btn_bcdoanhthu.Image")));
            this.btn_bcdoanhthu.Location = new System.Drawing.Point(0, 471);
            this.btn_bcdoanhthu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bcdoanhthu.Name = "btn_bcdoanhthu";
            this.btn_bcdoanhthu.Size = new System.Drawing.Size(315, 64);
            this.btn_bcdoanhthu.TabIndex = 8;
            this.btn_bcdoanhthu.Text = "Báo cáo doanh thu";
            this.btn_bcdoanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bcdoanhthu.UseVisualStyleBackColor = false;
            this.btn_bcdoanhthu.Click += new System.EventHandler(this.btn_bcdoanhthu_Click);
            // 
            // pnl_topdock
            // 
            this.pnl_topdock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_topdock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_topdock.Controls.Add(this.btn_dangxuat);
            this.pnl_topdock.Location = new System.Drawing.Point(315, 0);
            this.pnl_topdock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_topdock.Name = "pnl_topdock";
            this.pnl_topdock.Size = new System.Drawing.Size(1147, 62);
            this.pnl_topdock.TabIndex = 5;
            // 
            // pnl_qlnv
            // 
            this.pnl_qlnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_qlnv.Controls.Add(this.lbl_dsnv);
            this.pnl_qlnv.Controls.Add(this.pnl_dsnv);
            this.pnl_qlnv.Controls.Add(this.btn_xoanv);
            this.pnl_qlnv.Controls.Add(this.btn_suanv);
            this.pnl_qlnv.Controls.Add(this.btn_themnv);
            this.pnl_qlnv.Location = new System.Drawing.Point(0, 61);
            this.pnl_qlnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_qlnv.Name = "pnl_qlnv";
            this.pnl_qlnv.Size = new System.Drawing.Size(1147, 894);
            this.pnl_qlnv.TabIndex = 6;
            this.pnl_qlnv.Visible = false;
            // 
            // lbl_dsnv
            // 
            this.lbl_dsnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_dsnv.AutoSize = true;
            this.lbl_dsnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dsnv.Location = new System.Drawing.Point(443, 10);
            this.lbl_dsnv.Name = "lbl_dsnv";
            this.lbl_dsnv.Size = new System.Drawing.Size(252, 29);
            this.lbl_dsnv.TabIndex = 2;
            this.lbl_dsnv.Text = "Danh sách nhân viên";
            this.lbl_dsnv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_dsnv
            // 
            this.pnl_dsnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_dsnv.Controls.Add(this.tab_nv);
            this.pnl_dsnv.Enabled = false;
            this.pnl_dsnv.Location = new System.Drawing.Point(0, 41);
            this.pnl_dsnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_dsnv.Name = "pnl_dsnv";
            this.pnl_dsnv.Size = new System.Drawing.Size(1144, 764);
            this.pnl_dsnv.TabIndex = 1;
            // 
            // tab_nv
            // 
            this.tab_nv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tab_nv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tab_nv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_nv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tab_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_nv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_nv.Location = new System.Drawing.Point(0, 0);
            this.tab_nv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_nv.Name = "tab_nv";
            this.tab_nv.RowHeadersWidth = 51;
            this.tab_nv.RowTemplate.Height = 24;
            this.tab_nv.Size = new System.Drawing.Size(1144, 764);
            this.tab_nv.TabIndex = 1;
            // 
            // btn_xoanv
            // 
            this.btn_xoanv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoanv.FlatAppearance.BorderSize = 0;
            this.btn_xoanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoanv.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoanv.Image")));
            this.btn_xoanv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoanv.Location = new System.Drawing.Point(1025, 813);
            this.btn_xoanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoanv.Name = "btn_xoanv";
            this.btn_xoanv.Size = new System.Drawing.Size(110, 62);
            this.btn_xoanv.TabIndex = 4;
            this.btn_xoanv.Text = "Xóa";
            this.btn_xoanv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoanv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoanv.UseVisualStyleBackColor = true;
            // 
            // btn_suanv
            // 
            this.btn_suanv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_suanv.FlatAppearance.BorderSize = 0;
            this.btn_suanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_suanv.Image = ((System.Drawing.Image)(resources.GetObject("btn_suanv.Image")));
            this.btn_suanv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suanv.Location = new System.Drawing.Point(880, 812);
            this.btn_suanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_suanv.Name = "btn_suanv";
            this.btn_suanv.Size = new System.Drawing.Size(118, 62);
            this.btn_suanv.TabIndex = 5;
            this.btn_suanv.Text = "Sửa";
            this.btn_suanv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suanv.UseVisualStyleBackColor = true;
            // 
            // btn_themnv
            // 
            this.btn_themnv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themnv.FlatAppearance.BorderSize = 0;
            this.btn_themnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_themnv.Image = ((System.Drawing.Image)(resources.GetObject("btn_themnv.Image")));
            this.btn_themnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themnv.Location = new System.Drawing.Point(725, 813);
            this.btn_themnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_themnv.Name = "btn_themnv";
            this.btn_themnv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_themnv.Size = new System.Drawing.Size(128, 62);
            this.btn_themnv.TabIndex = 3;
            this.btn_themnv.Text = "Thêm";
            this.btn_themnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themnv.UseVisualStyleBackColor = true;
            this.btn_themnv.Click += new System.EventHandler(this.btn_themnv_Click);
            // 
            // pnl_noidung
            // 
            this.pnl_noidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_noidung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_noidung.BackgroundImage")));
            this.pnl_noidung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_noidung.Controls.Add(this.pl_bcthuoc);
            this.pnl_noidung.Controls.Add(this.pnl_qlnv);
            this.pnl_noidung.Location = new System.Drawing.Point(315, 0);
            this.pnl_noidung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_noidung.Name = "pnl_noidung";
            this.pnl_noidung.Size = new System.Drawing.Size(1147, 955);
            this.pnl_noidung.TabIndex = 6;
            // 
            // pl_bcthuoc
            // 
            this.pl_bcthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_bcthuoc.Controls.Add(this.btn_reload);
            this.pl_bcthuoc.Controls.Add(this.btn_timkiem);
            this.pl_bcthuoc.Controls.Add(this.tb_timkiem);
            this.pl_bcthuoc.Controls.Add(this.lb_timkiem);
            this.pl_bcthuoc.Controls.Add(this.lb_dsthuoc);
            this.pl_bcthuoc.Controls.Add(this.pl_dsthuoc);
            this.pl_bcthuoc.Controls.Add(this.btn_xoathuoc);
            this.pl_bcthuoc.Controls.Add(this.btn_suathuoc);
            this.pl_bcthuoc.Controls.Add(this.btn_themthuoc);
            this.pl_bcthuoc.Controls.Add(this.btn_bcthuochh);
            this.pl_bcthuoc.Controls.Add(this.btn_bcthuocsaphet);
            this.pl_bcthuoc.Location = new System.Drawing.Point(0, 61);
            this.pl_bcthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl_bcthuoc.Name = "pl_bcthuoc";
            this.pl_bcthuoc.Size = new System.Drawing.Size(1147, 894);
            this.pl_bcthuoc.TabIndex = 7;
            this.pl_bcthuoc.Visible = false;
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.Location = new System.Drawing.Point(455, 53);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(45, 43);
            this.btn_reload.TabIndex = 10;
            this.btn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(393, 53);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(43, 43);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_timkiem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_timkiem.Location = new System.Drawing.Point(148, 57);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.PlaceholderText = "Nhập tên thuốc";
            this.tb_timkiem.Size = new System.Drawing.Size(211, 34);
            this.tb_timkiem.TabIndex = 8;
            this.tb_timkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_timkiem.Location = new System.Drawing.Point(51, 60);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(91, 28);
            this.lb_timkiem.TabIndex = 2;
            this.lb_timkiem.Text = "Tìm kiếm";
            // 
            // lb_dsthuoc
            // 
            this.lb_dsthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_dsthuoc.AutoSize = true;
            this.lb_dsthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_dsthuoc.Location = new System.Drawing.Point(443, 5);
            this.lb_dsthuoc.Name = "lb_dsthuoc";
            this.lb_dsthuoc.Size = new System.Drawing.Size(204, 29);
            this.lb_dsthuoc.TabIndex = 2;
            this.lb_dsthuoc.Text = "Danh sách thuốc";
            this.lb_dsthuoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pl_dsthuoc
            // 
            this.pl_dsthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_dsthuoc.Controls.Add(this.tab_dsthuoc);
            this.pl_dsthuoc.Enabled = false;
            this.pl_dsthuoc.Location = new System.Drawing.Point(0, 113);
            this.pl_dsthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pl_dsthuoc.Name = "pl_dsthuoc";
            this.pl_dsthuoc.Size = new System.Drawing.Size(1144, 668);
            this.pl_dsthuoc.TabIndex = 1;
            // 
            // tab_dsthuoc
            // 
            this.tab_dsthuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tab_dsthuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tab_dsthuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_dsthuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tab_dsthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_dsthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_dsthuoc.Location = new System.Drawing.Point(0, 0);
            this.tab_dsthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_dsthuoc.Name = "tab_dsthuoc";
            this.tab_dsthuoc.RowHeadersWidth = 51;
            this.tab_dsthuoc.RowTemplate.Height = 24;
            this.tab_dsthuoc.Size = new System.Drawing.Size(1144, 668);
            this.tab_dsthuoc.TabIndex = 1;
            // 
            // btn_xoathuoc
            // 
            this.btn_xoathuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoathuoc.FlatAppearance.BorderSize = 0;
            this.btn_xoathuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoathuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoathuoc.Image")));
            this.btn_xoathuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoathuoc.Location = new System.Drawing.Point(1025, 804);
            this.btn_xoathuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoathuoc.Name = "btn_xoathuoc";
            this.btn_xoathuoc.Size = new System.Drawing.Size(110, 62);
            this.btn_xoathuoc.TabIndex = 4;
            this.btn_xoathuoc.Text = "Xóa";
            this.btn_xoathuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoathuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoathuoc.UseVisualStyleBackColor = true;
            // 
            // btn_suathuoc
            // 
            this.btn_suathuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_suathuoc.FlatAppearance.BorderSize = 0;
            this.btn_suathuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_suathuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_suathuoc.Image")));
            this.btn_suathuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathuoc.Location = new System.Drawing.Point(880, 804);
            this.btn_suathuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_suathuoc.Name = "btn_suathuoc";
            this.btn_suathuoc.Size = new System.Drawing.Size(118, 62);
            this.btn_suathuoc.TabIndex = 5;
            this.btn_suathuoc.Text = "Sửa";
            this.btn_suathuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suathuoc.UseVisualStyleBackColor = true;
            // 
            // btn_themthuoc
            // 
            this.btn_themthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_themthuoc.FlatAppearance.BorderSize = 0;
            this.btn_themthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_themthuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_themthuoc.Image")));
            this.btn_themthuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themthuoc.Location = new System.Drawing.Point(725, 804);
            this.btn_themthuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_themthuoc.Name = "btn_themthuoc";
            this.btn_themthuoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_themthuoc.Size = new System.Drawing.Size(128, 62);
            this.btn_themthuoc.TabIndex = 3;
            this.btn_themthuoc.Text = "Thêm";
            this.btn_themthuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themthuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themthuoc.UseVisualStyleBackColor = true;
            this.btn_themthuoc.Click += new System.EventHandler(this.btn_themthuoc_Click);
            // 
            // btn_bcthuochh
            // 
            this.btn_bcthuochh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bcthuochh.FlatAppearance.BorderSize = 0;
            this.btn_bcthuochh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bcthuochh.Image = ((System.Drawing.Image)(resources.GetObject("btn_bcthuochh.Image")));
            this.btn_bcthuochh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bcthuochh.Location = new System.Drawing.Point(567, 804);
            this.btn_bcthuochh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bcthuochh.Name = "btn_bcthuochh";
            this.btn_bcthuochh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_bcthuochh.Size = new System.Drawing.Size(128, 77);
            this.btn_bcthuochh.TabIndex = 6;
            this.btn_bcthuochh.Text = "Thuốc hết hạn";
            this.btn_bcthuochh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bcthuochh.UseVisualStyleBackColor = true;
            // 
            // btn_bcthuocsaphet
            // 
            this.btn_bcthuocsaphet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bcthuocsaphet.FlatAppearance.BorderSize = 0;
            this.btn_bcthuocsaphet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_bcthuocsaphet.Image = ((System.Drawing.Image)(resources.GetObject("btn_bcthuocsaphet.Image")));
            this.btn_bcthuocsaphet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bcthuocsaphet.Location = new System.Drawing.Point(415, 804);
            this.btn_bcthuocsaphet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_bcthuocsaphet.Name = "btn_bcthuocsaphet";
            this.btn_bcthuocsaphet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_bcthuocsaphet.Size = new System.Drawing.Size(128, 77);
            this.btn_bcthuocsaphet.TabIndex = 7;
            this.btn_bcthuocsaphet.Text = "Thuốc sắp hết";
            this.btn_bcthuocsaphet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bcthuocsaphet.UseVisualStyleBackColor = true;
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1462, 955);
            this.Controls.Add(this.pnl_topdock);
            this.Controls.Add(this.pnl_noidung);
            this.Controls.Add(this.pnl_leftsidebar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng";
            this.Load += new System.EventHandler(this.FHomePage_Load);
            this.pnl_leftsidebar.ResumeLayout(false);
            this.pnl_leftsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_topdock.ResumeLayout(false);
            this.pnl_qlnv.ResumeLayout(false);
            this.pnl_qlnv.PerformLayout();
            this.pnl_dsnv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_nv)).EndInit();
            this.pnl_noidung.ResumeLayout(false);
            this.pl_bcthuoc.ResumeLayout(false);
            this.pl_bcthuoc.PerformLayout();
            this.pl_dsthuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_dsthuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_leftsidebar;
        private System.Windows.Forms.Button btn_bcthuoc;
        private System.Windows.Forms.Button btn_qlbh;
        private System.Windows.Forms.Button btn_qlnh;
        private System.Windows.Forms.Button btn_qlnv;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label lbl_pharmacy;
        private System.Windows.Forms.Panel pnl_topdock;
        private System.Windows.Forms.Panel pnl_onqlnv;
        private System.Windows.Forms.Panel pnl_onbcthuoc;
        private System.Windows.Forms.Panel pnl_onqlbh;
        private System.Windows.Forms.Panel pnl_onqlnh;
        private System.Windows.Forms.Label lbl_drugstore;
        private System.Windows.Forms.Panel pnl_onbcdoanhthu;
        private System.Windows.Forms.Button btn_bcdoanhthu;
        private System.Windows.Forms.Panel pnl_qlnv;
        private System.Windows.Forms.Label lbl_dsnv;
        private System.Windows.Forms.DataGridView tab_nv;
        private System.Windows.Forms.Button btn_suanv;
        private System.Windows.Forms.Button btn_xoanv;
        private System.Windows.Forms.Button btn_themnv;
        private System.Windows.Forms.Panel pnl_dsnv;
        private System.Windows.Forms.Panel pnl_noidung;
        private Label lb_dsthuoc;
        private Panel pl_bcthuoc;
        private Panel pl_dsthuoc;
        private DataGridView tab_dsthuoc;
        private Button btn_xoathuoc;
        private Button btn_suathuoc;
        private Button btn_themthuoc;
        private Button btn_bcthuochh;
        private Button btn_bcthuocsaphet;
        private Button btn_timkiem;
        private TextBox tb_timkiem;
        private Label lb_timkiem;
        private Button btn_reload;
        private Label label1;
        private Label lb_designer;
        private PictureBox pictureBox1;
    }
}

