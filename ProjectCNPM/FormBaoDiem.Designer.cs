
namespace ProjectCNPM
{
    partial class FormBaoDiem
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
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.colsbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldiemuutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsbd,
            this.colmon1,
            this.coldiem1,
            this.colmon2,
            this.coldiem2,
            this.Column1,
            this.coldiem3,
            this.coldiemuutien});
            this.dtgvDiem.Location = new System.Drawing.Point(12, 170);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.RowHeadersWidth = 51;
            this.dtgvDiem.RowTemplate.Height = 24;
            this.dtgvDiem.Size = new System.Drawing.Size(776, 230);
            this.dtgvDiem.TabIndex = 0;
            this.dtgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiem_CellClick);
            this.dtgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colsbd
            // 
            this.colsbd.DataPropertyName = "Sbd";
            this.colsbd.HeaderText = "Số báo danh";
            this.colsbd.MinimumWidth = 6;
            this.colsbd.Name = "colsbd";
            this.colsbd.Width = 125;
            // 
            // colmon1
            // 
            this.colmon1.DataPropertyName = "Mon1";
            this.colmon1.HeaderText = "Môn 1";
            this.colmon1.MinimumWidth = 6;
            this.colmon1.Name = "colmon1";
            this.colmon1.Width = 125;
            // 
            // coldiem1
            // 
            this.coldiem1.DataPropertyName = "Diem1";
            this.coldiem1.HeaderText = "Điểm 1";
            this.coldiem1.MinimumWidth = 6;
            this.coldiem1.Name = "coldiem1";
            this.coldiem1.Width = 125;
            // 
            // colmon2
            // 
            this.colmon2.DataPropertyName = "Mon2";
            this.colmon2.HeaderText = "Môn 2";
            this.colmon2.MinimumWidth = 6;
            this.colmon2.Name = "colmon2";
            this.colmon2.Width = 125;
            // 
            // coldiem2
            // 
            this.coldiem2.DataPropertyName = "Diem2";
            this.coldiem2.HeaderText = "Điểm 2";
            this.coldiem2.MinimumWidth = 6;
            this.coldiem2.Name = "coldiem2";
            this.coldiem2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mon3";
            this.Column1.HeaderText = "Môn 3";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // coldiem3
            // 
            this.coldiem3.DataPropertyName = "Diem3";
            this.coldiem3.HeaderText = "Điểm 3";
            this.coldiem3.MinimumWidth = 6;
            this.coldiem3.Name = "coldiem3";
            this.coldiem3.Width = 125;
            // 
            // coldiemuutien
            // 
            this.coldiemuutien.DataPropertyName = "Diemuutien";
            this.coldiemuutien.HeaderText = "Điểm ưu tiên";
            this.coldiemuutien.MinimumWidth = 6;
            this.coldiemuutien.Name = "coldiemuutien";
            this.coldiemuutien.Width = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "made by: nhom12";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbSBD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 89);
            this.groupBox1.TabIndex = 42;
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
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(609, 126);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(138, 38);
            this.btnView.TabIndex = 43;
            this.btnView.Text = "Xem chi tiết";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::ProjectCNPM.Properties.Resources.zyro_image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 38);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormBaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgvDiem);
            this.Name = "FormBaoDiem";
            this.Text = "Báo điểm";
            this.Load += new System.EventHandler(this.FormBaoDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbSBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldiemuutien;
        private System.Windows.Forms.Button btnThem;
    }
}