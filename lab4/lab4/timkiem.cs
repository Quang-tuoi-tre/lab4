using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class timkiem : Form
    {
        StuentContextDB db;
        public timkiem()
        {
            InitializeComponent();
            db = new StuentContextDB();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void hienthiDS(List<Student> stuLst)
        {
            dgvtimkiem.Rows.Clear();
          
            foreach (Student item in stuLst)
            {
                int index = dgvtimkiem.Rows.Add();
                dgvtimkiem.Rows[index].Cells[0].Value = item.StudentID;
                dgvtimkiem.Rows[index].Cells[1].Value = item.FullName;
                dgvtimkiem.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvtimkiem.Rows[index].Cells[3].Value = item.AverageScore;
                
            }
        }

        

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            var st = db.Students.Where(x => x.StudentID.Contains(tbmasosv.Text)).ToList();

            if (st.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mã số sinh viên!");
            }
            else
            {
                
                hienthiDS(st);
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sensder, EventArgs e)
        {
            dgvtimkiem.Rows.Clear();

        }
    }
}
