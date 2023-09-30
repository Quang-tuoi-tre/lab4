
namespace lab4
{
    partial class timkiem
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
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmasosv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.dgmassv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dghoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdiemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbkhoa);
            this.groupBox1.Controls.Add(this.tbhoten);
            this.groupBox1.Controls.Add(this.tbmasosv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(228, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "Ngôn ngữ Anh",
            "Quản trị kinh doanh"});
            this.cmbkhoa.Location = new System.Drawing.Point(176, 108);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbkhoa.TabIndex = 2;
            this.cmbkhoa.Text = "Công nghệ thông tin";
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(176, 75);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(100, 20);
            this.tbhoten.TabIndex = 1;
            // 
            // tbmasosv
            // 
            this.tbmasosv.Location = new System.Drawing.Point(176, 40);
            this.tbmasosv.Name = "tbmasosv";
            this.tbmasosv.Size = new System.Drawing.Size(100, 20);
            this.tbmasosv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số SV";
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgmassv,
            this.dghoten,
            this.dgtenkhoa,
            this.dgdiemtb});
            this.dgvtimkiem.Location = new System.Drawing.Point(83, 212);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.Size = new System.Drawing.Size(646, 214);
            this.dgvtimkiem.TabIndex = 1;
            // 
            // dgmassv
            // 
            this.dgmassv.HeaderText = "Mã Số SV";
            this.dgmassv.Name = "dgmassv";
            this.dgmassv.Width = 150;
            // 
            // dghoten
            // 
            this.dghoten.HeaderText = "Họ tên";
            this.dghoten.Name = "dghoten";
            this.dghoten.Width = 150;
            // 
            // dgtenkhoa
            // 
            this.dgtenkhoa.HeaderText = "Tên Khoa";
            this.dgtenkhoa.Name = "dgtenkhoa";
            this.dgtenkhoa.Width = 150;
            // 
            // dgdiemtb
            // 
            this.dgdiemtb.HeaderText = "Điểm TB";
            this.dgdiemtb.Name = "dgdiemtb";
            this.dgdiemtb.Width = 150;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(404, 174);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(485, 174);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(654, 174);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 2;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvtimkiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "timkiem";
            this.Text = "Tìm kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbmasosv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmassv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dghoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdiemtb;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntrove;
    }
}