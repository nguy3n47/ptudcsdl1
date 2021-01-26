namespace GUI
{
    partial class frmSINHVIEN
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.phai = new System.Windows.Forms.ComboBox();
            this.lop = new System.Windows.Forms.ComboBox();
            this.diemtb = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.themsv = new System.Windows.Forms.Button();
            this.xoasv = new System.Windows.Forms.Button();
            this.suasv = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm TB";
            // 
            // masv
            // 
            this.masv.Location = new System.Drawing.Point(305, 52);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(100, 20);
            this.masv.TabIndex = 2;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(305, 94);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(100, 20);
            this.hoten.TabIndex = 2;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(305, 141);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.ngaysinh.TabIndex = 3;
            // 
            // phai
            // 
            this.phai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phai.FormattingEnabled = true;
            this.phai.Location = new System.Drawing.Point(305, 183);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(121, 21);
            this.phai.TabIndex = 4;
            // 
            // lop
            // 
            this.lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lop.FormattingEnabled = true;
            this.lop.Location = new System.Drawing.Point(305, 227);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(121, 21);
            this.lop.TabIndex = 4;
            // 
            // diemtb
            // 
            this.diemtb.Location = new System.Drawing.Point(305, 273);
            this.diemtb.Name = "diemtb";
            this.diemtb.Size = new System.Drawing.Size(100, 20);
            this.diemtb.TabIndex = 2;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(270, 311);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(51, 23);
            this.prev.TabIndex = 5;
            this.prev.Text = "<";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(356, 311);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(51, 23);
            this.next.TabIndex = 5;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // themsv
            // 
            this.themsv.Location = new System.Drawing.Point(228, 361);
            this.themsv.Name = "themsv";
            this.themsv.Size = new System.Drawing.Size(67, 23);
            this.themsv.TabIndex = 5;
            this.themsv.Text = "Thêm";
            this.themsv.UseVisualStyleBackColor = true;
            this.themsv.Click += new System.EventHandler(this.themsv_Click);
            // 
            // xoasv
            // 
            this.xoasv.Location = new System.Drawing.Point(318, 361);
            this.xoasv.Name = "xoasv";
            this.xoasv.Size = new System.Drawing.Size(67, 23);
            this.xoasv.TabIndex = 5;
            this.xoasv.Text = "Xóa";
            this.xoasv.UseVisualStyleBackColor = true;
            this.xoasv.Click += new System.EventHandler(this.xoasv_Click);
            // 
            // suasv
            // 
            this.suasv.Location = new System.Drawing.Point(403, 361);
            this.suasv.Name = "suasv";
            this.suasv.Size = new System.Drawing.Size(67, 23);
            this.suasv.TabIndex = 5;
            this.suasv.Text = "Sửa";
            this.suasv.UseVisualStyleBackColor = true;
            this.suasv.Click += new System.EventHandler(this.suasv_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(538, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmSINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.suasv);
            this.Controls.Add(this.xoasv);
            this.Controls.Add(this.themsv);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.phai);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.diemtb);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSINHVIEN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSINHVIEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.ComboBox phai;
        private System.Windows.Forms.ComboBox lop;
        private System.Windows.Forms.TextBox diemtb;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button xoasv;
        private System.Windows.Forms.Button suasv;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button themsv;
    }
}

