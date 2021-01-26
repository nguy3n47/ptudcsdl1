namespace GUI
{
    partial class frmBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblxuatxu = new System.Windows.Forms.ComboBox();
            this.lblmahoadon = new System.Windows.Forms.ComboBox();
            this.gridhoadon = new System.Windows.Forms.DataGridView();
            this.gridcthoadon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tinhtien = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcthoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các hóa đơn mua tất cả sản phẩm từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa đơn có số hóa đơn";
            // 
            // lblxuatxu
            // 
            this.lblxuatxu.FormattingEnabled = true;
            this.lblxuatxu.Location = new System.Drawing.Point(208, 27);
            this.lblxuatxu.Name = "lblxuatxu";
            this.lblxuatxu.Size = new System.Drawing.Size(121, 21);
            this.lblxuatxu.TabIndex = 1;
            this.lblxuatxu.SelectedIndexChanged += new System.EventHandler(this.lblxuatxu_SelectedIndexChanged);
            // 
            // lblmahoadon
            // 
            this.lblmahoadon.FormattingEnabled = true;
            this.lblmahoadon.Items.AddRange(new object[] {
            "Tất cả",
            "Nhiều nhất",
            "Ít nhất"});
            this.lblmahoadon.Location = new System.Drawing.Point(655, 30);
            this.lblmahoadon.Name = "lblmahoadon";
            this.lblmahoadon.Size = new System.Drawing.Size(121, 21);
            this.lblmahoadon.TabIndex = 1;
            this.lblmahoadon.SelectedIndexChanged += new System.EventHandler(this.lblmahoadon_SelectedIndexChanged);
            // 
            // gridhoadon
            // 
            this.gridhoadon.AllowUserToAddRows = false;
            this.gridhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridhoadon.Location = new System.Drawing.Point(15, 57);
            this.gridhoadon.Name = "gridhoadon";
            this.gridhoadon.Size = new System.Drawing.Size(764, 150);
            this.gridhoadon.TabIndex = 2;
            this.gridhoadon.SelectionChanged += new System.EventHandler(this.gridhoadon_SelectionChanged);
            // 
            // gridcthoadon
            // 
            this.gridcthoadon.AllowUserToAddRows = false;
            this.gridcthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcthoadon.Location = new System.Drawing.Point(12, 255);
            this.gridcthoadon.Name = "gridcthoadon";
            this.gridcthoadon.Size = new System.Drawing.Size(764, 200);
            this.gridcthoadon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chi tiết hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền: ";
            // 
            // tinhtien
            // 
            this.tinhtien.Location = new System.Drawing.Point(440, 216);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(109, 23);
            this.tinhtien.TabIndex = 3;
            this.tinhtien.Text = "Tính tiền hóa đơn";
            this.tinhtien.UseVisualStyleBackColor = true;
            this.tinhtien.Click += new System.EventHandler(this.tinhtien_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(667, 489);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(109, 23);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "Đóng";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Location = new System.Drawing.Point(610, 221);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(13, 13);
            this.tongtien.TabIndex = 0;
            this.tongtien.Text = "0";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 535);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.gridcthoadon);
            this.Controls.Add(this.gridhoadon);
            this.Controls.Add(this.lblmahoadon);
            this.Controls.Add(this.lblxuatxu);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBanHang";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcthoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lblxuatxu;
        private System.Windows.Forms.ComboBox lblmahoadon;
        private System.Windows.Forms.DataGridView gridhoadon;
        private System.Windows.Forms.DataGridView gridcthoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tinhtien;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label tongtien;
    }
}

