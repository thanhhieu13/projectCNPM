
namespace ProjectCNPM
{
    partial class FormBaoThidtgv
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvBaoThi = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnoisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbaotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaythi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 125);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 38);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(609, 125);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(138, 38);
            this.btnView.TabIndex = 46;
            this.btnView.Text = "Xem chi tiết";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbSBD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 89);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Image = global::ProjectCNPM.Properties.Resources.loupe;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(528, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbSBD
            // 
            this.txbSBD.Location = new System.Drawing.Point(270, 32);
            this.txbSBD.Name = "txbSBD";
            this.txbSBD.Size = new System.Drawing.Size(283, 30);
            this.txbSBD.TabIndex = 7;
            this.txbSBD.TextChanged += new System.EventHandler(this.txbSBD_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Báo Danh";
            // 
            // dtgvBaoThi
            // 
            this.dtgvBaoThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBaoThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colname,
            this.colnoisinh,
            this.colsbd,
            this.colNgaySinh,
            this.colbaotin,
            this.colthi,
            this.colphong,
            this.colngaythi,
            this.coltien});
            this.dtgvBaoThi.Location = new System.Drawing.Point(12, 169);
            this.dtgvBaoThi.Name = "dtgvBaoThi";
            this.dtgvBaoThi.RowHeadersWidth = 51;
            this.dtgvBaoThi.RowTemplate.Height = 24;
            this.dtgvBaoThi.Size = new System.Drawing.Size(776, 229);
            this.dtgvBaoThi.TabIndex = 48;
            this.dtgvBaoThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBaoDiem_CellClick);
            this.dtgvBaoThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBaoDiem_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "made by: nhom12";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::ProjectCNPM.Properties.Resources.zyro_image;
            this.pictureBox1.Location = new System.Drawing.Point(14, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // colname
            // 
            this.colname.DataPropertyName = "Name";
            this.colname.HeaderText = "Họ và tên";
            this.colname.MinimumWidth = 6;
            this.colname.Name = "colname";
            this.colname.Width = 125;
            // 
            // colnoisinh
            // 
            this.colnoisinh.DataPropertyName = "NoiSinh";
            this.colnoisinh.HeaderText = "Nơi sinh";
            this.colnoisinh.MinimumWidth = 6;
            this.colnoisinh.Name = "colnoisinh";
            this.colnoisinh.Width = 125;
            // 
            // colsbd
            // 
            this.colsbd.DataPropertyName = "Sbd";
            this.colsbd.HeaderText = "Số báo danh";
            this.colsbd.MinimumWidth = 6;
            this.colsbd.Name = "colsbd";
            this.colsbd.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "Birth";
            this.colNgaySinh.HeaderText = "BirthDay";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 125;
            // 
            // colbaotin
            // 
            this.colbaotin.DataPropertyName = "Diachibaotin";
            this.colbaotin.HeaderText = "Địa chỉ báo tin";
            this.colbaotin.MinimumWidth = 6;
            this.colbaotin.Name = "colbaotin";
            this.colbaotin.Width = 125;
            // 
            // colthi
            // 
            this.colthi.DataPropertyName = "Diachithi";
            this.colthi.HeaderText = "Địa chỉ thi";
            this.colthi.MinimumWidth = 6;
            this.colthi.Name = "colthi";
            this.colthi.Width = 125;
            // 
            // colphong
            // 
            this.colphong.DataPropertyName = "Phongthi";
            this.colphong.HeaderText = "Phòng Thi";
            this.colphong.MinimumWidth = 6;
            this.colphong.Name = "colphong";
            this.colphong.Width = 125;
            // 
            // colngaythi
            // 
            this.colngaythi.DataPropertyName = "Ngaythi";
            this.colngaythi.HeaderText = "Ngày thi";
            this.colngaythi.MinimumWidth = 6;
            this.colngaythi.Name = "colngaythi";
            this.colngaythi.Width = 125;
            // 
            // coltien
            // 
            this.coltien.DataPropertyName = "Tien";
            this.coltien.HeaderText = "Lệ phí thi";
            this.coltien.MinimumWidth = 6;
            this.coltien.Name = "coltien";
            this.coltien.Width = 125;
            // 
            // FormBaoThidtgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgvBaoThi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBaoThidtgv";
            this.Text = "Danh sách báo thi ";
            this.Load += new System.EventHandler(this.FormBaoThidtgv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBaoThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbSBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvBaoThi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnoisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbaotin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaythi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltien;
    }
}