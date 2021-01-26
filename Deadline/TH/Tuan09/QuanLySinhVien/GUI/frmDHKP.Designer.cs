namespace GUI
{
    partial class frmDHKP
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
            this.dssv = new System.Windows.Forms.ComboBox();
            this.dsdkhp = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.capnhat = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsdkhp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sinh viên";
            // 
            // dssv
            // 
            this.dssv.FormattingEnabled = true;
            this.dssv.Location = new System.Drawing.Point(69, 80);
            this.dssv.Name = "dssv";
            this.dssv.Size = new System.Drawing.Size(165, 21);
            this.dssv.TabIndex = 2;
            this.dssv.SelectedIndexChanged += new System.EventHandler(this.dssv_SelectedIndexChanged);
            // 
            // dsdkhp
            // 
            this.dsdkhp.AllowUserToAddRows = false;
            this.dsdkhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdkhp.Location = new System.Drawing.Point(12, 129);
            this.dsdkhp.Name = "dsdkhp";
            this.dsdkhp.Size = new System.Drawing.Size(764, 223);
            this.dsdkhp.TabIndex = 3;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(191, 387);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(82, 25);
            this.them.TabIndex = 4;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(313, 387);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(82, 25);
            this.xoa.TabIndex = 4;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(431, 387);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(82, 25);
            this.capnhat.TabIndex = 4;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(647, 387);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 25);
            this.exit.TabIndex = 4;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmDHKP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dsdkhp);
            this.Controls.Add(this.dssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDHKP";
            this.Text = "frmDHKP";
            this.Load += new System.EventHandler(this.frmDHKP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsdkhp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dssv;
        private System.Windows.Forms.DataGridView dsdkhp;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button exit;
    }
}