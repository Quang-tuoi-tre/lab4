
namespace lab4
{
    partial class quanlykhoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbtongso = new System.Windows.Forms.TextBox();
            this.tbtenkhoa = new System.Windows.Forms.TextBox();
            this.tbmakhoa = new System.Windows.Forms.TextBox();
            this.lbtenkhoa = new System.Windows.Forms.Label();
            this.lbtongso = new System.Windows.Forms.Label();
            this.lbmakhoa = new System.Windows.Forms.Label();
            this.dgvkhoa = new System.Windows.Forms.DataGridView();
            this.dgvmakhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtongsogs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbtongso);
            this.groupBox1.Controls.Add(this.tbtenkhoa);
            this.groupBox1.Controls.Add(this.tbmakhoa);
            this.groupBox1.Controls.Add(this.lbtenkhoa);
            this.groupBox1.Controls.Add(this.lbtongso);
            this.groupBox1.Controls.Add(this.lbmakhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // tbtongso
            // 
            this.tbtongso.Location = new System.Drawing.Point(168, 134);
            this.tbtongso.Name = "tbtongso";
            this.tbtongso.Size = new System.Drawing.Size(100, 20);
            this.tbtongso.TabIndex = 1;
            // 
            // tbtenkhoa
            // 
            this.tbtenkhoa.Location = new System.Drawing.Point(168, 84);
            this.tbtenkhoa.Name = "tbtenkhoa";
            this.tbtenkhoa.Size = new System.Drawing.Size(100, 20);
            this.tbtenkhoa.TabIndex = 1;
            // 
            // tbmakhoa
            // 
            this.tbmakhoa.Location = new System.Drawing.Point(168, 31);
            this.tbmakhoa.Name = "tbmakhoa";
            this.tbmakhoa.Size = new System.Drawing.Size(100, 20);
            this.tbmakhoa.TabIndex = 1;
            this.tbmakhoa.TextChanged += new System.EventHandler(this.tbmakhoa_TextChanged);
            // 
            // lbtenkhoa
            // 
            this.lbtenkhoa.AutoSize = true;
            this.lbtenkhoa.Location = new System.Drawing.Point(19, 87);
            this.lbtenkhoa.Name = "lbtenkhoa";
            this.lbtenkhoa.Size = new System.Drawing.Size(53, 13);
            this.lbtenkhoa.TabIndex = 0;
            this.lbtenkhoa.Text = "Tên khoa";
            // 
            // lbtongso
            // 
            this.lbtongso.AutoSize = true;
            this.lbtongso.Location = new System.Drawing.Point(19, 141);
            this.lbtongso.Name = "lbtongso";
            this.lbtongso.Size = new System.Drawing.Size(64, 13);
            this.lbtongso.TabIndex = 0;
            this.lbtongso.Text = "Tổng số GS";
            // 
            // lbmakhoa
            // 
            this.lbmakhoa.AutoSize = true;
            this.lbmakhoa.Location = new System.Drawing.Point(19, 34);
            this.lbmakhoa.Name = "lbmakhoa";
            this.lbmakhoa.Size = new System.Drawing.Size(49, 13);
            this.lbmakhoa.TabIndex = 0;
            this.lbmakhoa.Text = "Mã khoa";
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmakhoa,
            this.dgvtenkhoa,
            this.dgvtongsogs});
            this.dgvkhoa.Location = new System.Drawing.Point(421, 63);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.Size = new System.Drawing.Size(335, 191);
            this.dgvkhoa.TabIndex = 1;
            this.dgvkhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvmakhoa
            // 
            this.dgvmakhoa.HeaderText = "Mã khoa";
            this.dgvmakhoa.Name = "dgvmakhoa";
            // 
            // dgvtenkhoa
            // 
            this.dgvtenkhoa.HeaderText = "Tên khoa";
            this.dgvtenkhoa.Name = "dgvtenkhoa";
            // 
            // dgvtongsogs
            // 
            this.dgvtongsogs.HeaderText = "Tổng số GS";
            this.dgvtongsogs.Name = "dgvtongsogs";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(112, 273);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(294, 273);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(681, 285);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 2;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(205, 273);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // quanlykhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvkhoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "quanlykhoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.quanlykhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbtongso;
        private System.Windows.Forms.TextBox tbtenkhoa;
        private System.Windows.Forms.TextBox tbmakhoa;
        private System.Windows.Forms.Label lbtenkhoa;
        private System.Windows.Forms.Label lbtongso;
        private System.Windows.Forms.Label lbmakhoa;
        private System.Windows.Forms.DataGridView dgvkhoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmakhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtongsogs;
        private System.Windows.Forms.Button btnsua;
    }
}