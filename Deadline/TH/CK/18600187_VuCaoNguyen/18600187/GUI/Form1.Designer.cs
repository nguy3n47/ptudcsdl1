
namespace GUI
{
    partial class frmLichThi
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
            this.cboxKhoa = new System.Windows.Forms.ComboBox();
            this.cboxHK = new System.Windows.Forms.ComboBox();
            this.cboxNH = new System.Windows.Forms.ComboBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxKhoa
            // 
            this.cboxKhoa.FormattingEnabled = true;
            this.cboxKhoa.Location = new System.Drawing.Point(137, 42);
            this.cboxKhoa.Name = "cboxKhoa";
            this.cboxKhoa.Size = new System.Drawing.Size(121, 24);
            this.cboxKhoa.TabIndex = 0;
            // 
            // cboxHK
            // 
            this.cboxHK.FormattingEnabled = true;
            this.cboxHK.Location = new System.Drawing.Point(597, 42);
            this.cboxHK.Name = "cboxHK";
            this.cboxHK.Size = new System.Drawing.Size(121, 24);
            this.cboxHK.TabIndex = 1;
            // 
            // cboxNH
            // 
            this.cboxNH.FormattingEnabled = true;
            this.cboxNH.Location = new System.Drawing.Point(369, 42);
            this.cboxNH.Name = "cboxNH";
            this.cboxNH.Size = new System.Drawing.Size(121, 24);
            this.cboxNH.TabIndex = 2;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(36, 96);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(740, 236);
            this.dgvSinhVien.TabIndex = 3;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(264, 358);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 44);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Đồng ý";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(423, 358);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 44);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.cboxNH);
            this.Controls.Add(this.cboxHK);
            this.Controls.Add(this.cboxKhoa);
            this.Name = "frmLichThi";
            this.Text = "QuanLyLichThi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxKhoa;
        private System.Windows.Forms.ComboBox cboxHK;
        private System.Windows.Forms.ComboBox cboxNH;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonExit;
    }
}

