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
    public partial class Quanlysinhvien : Form
    {
         StuentContextDB db;

        public string ID { get; private set; }



        public Quanlysinhvien()
        {
            InitializeComponent();
            db = new StuentContextDB();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbkhoa_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if(dgvsv.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    dgvsv.CurrentRow.Selected = true;
                    tbmssv.Text = dgvsv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    tbhoten.Text = dgvsv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cmbkhoa.SelectedItem = dgvsv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    tbavscore.Text = dgvsv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> stu = db.Students.ToList();
            List<Faculty> fac = db.Faculties.ToList();
            hienthiDS(stu);
            hienthiCombobox(fac);
        }
    
        private void hienthiDS(List<Student> stuList)
        {
            foreach (Student item in stuList)
            {
                int index = dgvsv.Rows.Add();
                dgvsv.Rows[index].Cells[0].Value = item.StudentID;
                dgvsv.Rows[index].Cells[1].Value = item.FullName;
                dgvsv.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvsv.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }
        private void hienthiCombobox(List<Faculty> facLst)
        {
            cmbkhoa.DataSource = facLst;
            cmbkhoa.DisplayMember = "FacultyName";
            cmbkhoa.ValueMember = "FacultyID";
        }

        private bool CheckData()
        {
            if (string.IsNullOrEmpty(tbmssv.Text) || string.IsNullOrEmpty(tbhoten.Text) || string.IsNullOrEmpty(tbavscore.Text))
            {
                MessageBox.Show("Vui lòng nhapp day du thông tin!", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            else if (tbmssv.TextLength !=10)
            {
                MessageBox.Show("Mã so sinh viên phai có 10 kí tu!", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
     

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                return;
            }

            Student student = new Student();
            student.StudentID = tbmssv.Text;
            student.FullName = tbhoten.Text;
            student.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue);
            student.AverageScore = Convert.ToDouble(tbavscore.Text);

            db.Students.Add(student);
            db.SaveChanges();

            MessageBox.Show("Thêm dữ liệu thành công !");
            List<Student> stu = db.Students.ToList();
            dgvsv.Rows.Clear();
            dgvsv.Refresh();
            hienthiDS(stu);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var st = db.Students.FirstOrDefault(x => x.StudentID == tbmssv.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần sửa!");
            }
            else
            {
                if (btnsua.Text == "Sửa")
                {
                    // tai thong tin len textbox
                    tbmssv.Text = st.StudentID.ToString();
                    tbhoten.Text = st.FullName.ToString();
                    cmbkhoa.SelectedValue = st.FacultyID;
                    tbavscore.Text = st.AverageScore.ToString();

                    btnsua.Text = "Hoàn thành";
                }
                else
                {
                    // luu vao db
                    st.StudentID = tbmssv.Text;
                    st.FullName = tbhoten.Text;
                    st.FacultyID = Convert.ToInt32(cmbkhoa.SelectedValue);
                    st.AverageScore = Convert.ToDouble(tbavscore.Text);
                    db.SaveChanges();

                    btnsua.Text = "Sửa";
                    MessageBox.Show("Sửa thành công !");

                    List<Student> stu = db.Students.ToList();
                    dgvsv.Rows.Clear();
                    dgvsv.Refresh();
                    hienthiDS(stu);
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var st = db.Students.FirstOrDefault(x => x.StudentID == tbmssv.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên cần xóa!");
            }
            else 
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa ? ", " Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {  // Kiểm tra kết quả người dùng
                    db.Students.Remove(st);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa dữ liệu thành công !");
                    List<Student> stu = db.Students.ToList();
                    dgvsv.Rows.Clear();
                    dgvsv.Refresh();
                    hienthiDS(stu);
                }
                else
                {
                    return;
                }
              

            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnquanlykhoa_Click(object sender, EventArgs e)
        {
            quanlykhoa f2 = new quanlykhoa();
            f2.ShowDialog();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlykhoa f2 = new quanlykhoa();
            f2.ShowDialog();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            timkiem f3 = new timkiem();
            f3.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiem f3 = new timkiem();
            f3.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
    }

