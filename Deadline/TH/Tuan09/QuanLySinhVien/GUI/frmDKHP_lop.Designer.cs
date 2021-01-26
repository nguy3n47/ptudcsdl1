namespace GUI
{
    partial class frmDKHP_lop
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
            this.listLop = new System.Windows.Forms.ListView();
            this.listSV = new System.Windows.Forms.DataGridView();
            this.listDKHP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.capnhat = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // listLop
            // 
            this.listLop.HideSelection = false;
            this.listLop.Location = new System.Drawing.Point(12, 40);
            this.listLop.Name = "listLop";
            this.listLop.Size = new System.Drawing.Size(298, 151);
            this.listLop.TabIndex = 0;
            this.listLop.UseCompatibleStateImageBehavior = false;
            this.listLop.SelectedIndexChanged += new System.EventHandler(this.listLop_SelectedIndexChanged);
            // 
            // listSV
            // 
            this.listSV.AllowUserToAddRows = false;
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Location = new System.Drawing.Point(316, 40);
            this.listSV.Name = "listSV";
            this.listSV.Size = new System.Drawing.Size(641, 151);
            this.listSV.TabIndex = 1;
            this.listSV.SelectionChanged += new System.EventHandler(this.listSV_SelectionChanged);
            // 
            // listDKHP
            // 
            this.listDKHP.AllowUserToAddRows = false;
            this.listDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDKHP.Location = new System.Drawing.Point(12, 219);
            this.listDKHP.Name = "listDKHP";
            this.listDKHP.Size = new System.Drawing.Size(960, 179);
            this.listDKHP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin lớp (List View)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả DKHP";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(235, 416);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 3;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(333, 416);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(425, 416);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(75, 23);
            this.capnhat.TabIndex = 3;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(897, 416);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmDKHP_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDKHP);
            this.Controls.Add(this.listSV);
            this.Controls.Add(this.listLop);
            this.Name = "frmDKHP_lop";
            this.Text = "frmDKHP_lop";
            this.Load += new System.EventHandler(this.frmDKHP_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDKHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listLop;
        private System.Windows.Forms.DataGridView listSV;
        private System.Windows.Forms.DataGridView listDKHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button exit;
    }
}