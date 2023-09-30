using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4;

namespace lab4
{
    public partial class quanlykhoa : Form
    {
         StuentContextDB db;
        public quanlykhoa()
        {
            InitializeComponent();
            db = new StuentContextDB();
        }

        private void tbmakhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void hienthiDS(List<Faculty> stuLst)
        {
            foreach (Faculty item in stuLst)
            {
                int index = dgvkhoa.Rows.Add();
                dgvkhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvkhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dgvkhoa.Rows[index].Cells[2].Value = item.TotalProfessor;

            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void quanlykhoa_Load(object sender, EventArgs e)
        {
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(fac);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Faculty fac = new Faculty();
            fac.FacultyID = Convert.ToInt32(tbmakhoa.Text);
            fac.FacultyName = tbtenkhoa.Text;

            fac.TotalProfessor = Convert.ToInt32(tbtongso.Text);

            db.Faculties.Add(fac);
            db.SaveChanges();

            MessageBox.Show("Thêm dữ liệu cho khoa thành công !");
            List<Faculty> facc = db.Faculties.ToList();
            dgvkhoa.Rows.Clear();
            dgvkhoa.Refresh();
            hienthiDS(facc);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var y = Convert.ToInt32(tbmakhoa.Text);
            var fc = db.Faculties.FirstOrDefault(x => x.FacultyID == y);

            if (fc == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần sửa!");
            }
            else
            {
                if (btnsua.Text == "Sửa")
                {
                    // tai thong tin len textbox
                    tbmakhoa.Text = fc.FacultyID.ToString();
                    tbtenkhoa.Text = fc.FacultyName.ToString();
                    tbtongso.Text = fc.TotalProfessor.ToString();

                    btnsua.Text = "Hoàn thành";
                }
                else
                {
                    var k = Convert.ToInt32(tbtongso.Text);
                    // luu vao db
                    fc.FacultyID = y;
                    fc.FacultyName = tbtenkhoa.Text;
                    fc.TotalProfessor = k;

                    db.SaveChanges();

                    btnsua.Text = "Sửa";
                    MessageBox.Show("Sửa thành công !");

                    List<Faculty> fcc = db.Faculties.ToList();
                    dgvkhoa.Rows.Clear();
                    dgvkhoa.Refresh();
                    hienthiDS(fcc);
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var u = Convert.ToInt32(tbmakhoa.Text);
            var fc = db.Faculties.FirstOrDefault(x => x.FacultyID == u);

            if (fc == null)
            {
                MessageBox.Show("Không tìm thấy mã khoa cần xóa!");
            }
            else
            {
                db.Faculties.Remove(fc);
                db.SaveChanges();
                MessageBox.Show("Đã xóa dữ liệu thành công !");
                List<Faculty> fcc = db.Faculties.ToList();
                dgvkhoa.Rows.Clear();
                dgvkhoa.Refresh();
                hienthiDS(fcc);

            }
        }

    }
}
