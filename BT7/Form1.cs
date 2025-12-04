using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_khoa.SelectedIndex = 0;
        }

        private int GetSelectedRow(string studentId)
        {
            for (int i = 0; i < dgv_students.Rows.Count; i++)
            {
                var val = dgv_students.Rows[i].Cells[0].Value;
                if (val != null && val.ToString() == studentId)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgv_students.Rows[selectedRow].Cells[0].Value = txt_ma.Text;
            dgv_students.Rows[selectedRow].Cells[1].Value = txt_hoten.Text;
            dgv_students.Rows[selectedRow].Cells[2].Value = rb_nu.Checked ? "Nữ" : "Nam";
            dgv_students.Rows[selectedRow].Cells[3].Value =
            float.Parse(txt_diem.Text).ToString();
            dgv_students.Rows[selectedRow].Cells[4].Value = cmb_khoa.Text;
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ma.Text == "" || txt_hoten.Text == "" || txt_diem.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên.");
                }
                int selectedRow = GetSelectedRow(txt_ma.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgv_students.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateStudentCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_De_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem người dùng có chọn dòng nào không
                // Nếu số dòng được chọn bằng 0 thì báo lỗi
                if (dgv_students.SelectedRows.Count == 0)
                {
                    throw new Exception("Vui lòng chọn dòng cần xóa trên danh sách!");
                }

                // 2. Lấy vị trí (Index) của dòng đang chọn đầu tiên
                int selectedIndex = dgv_students.SelectedRows[0].Index;

                // Lấy đối tượng dòng để xử lý
                DataGridViewRow row = dgv_students.Rows[selectedIndex];

                // [Phòng ngừa] Nếu người dùng click vào dòng trống cuối cùng (dòng new row)
                if (row.IsNewRow)
                {
                    MessageBox.Show("Dòng này không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Lấy thông tin Mã SV (cột 0) và Tên (cột 1) để hiện thông báo xác nhận cho rõ ràng
                string maSV = row.Cells[0].Value.ToString();
                string tenSV = row.Cells[1].Value.ToString();

                // 4. Hiện hộp thoại hỏi
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên: {tenSV} (Mã: {maSV}) không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // 5. Thực hiện xóa dòng tại vị trí đã lấy
                    dgv_students.Rows.RemoveAt(selectedIndex);

                    // 6. Cập nhật lại Textbox đếm số lượng Nam/Nữ (Hàm đã viết ở bài trước)
                    UpdateStudentCounts();

                    // 7. Xóa trắng các ô nhập liệu (để tránh nhầm lẫn)
                    txt_ma.Text = "";
                    txt_hoten.Text = "";
                    txt_diem.Text = "";
                    cmb_khoa.SelectedIndex = 0;

                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateStudentCounts()
        {
            int namCount = 0;
            int nuCount = 0;

            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dgv_students.Rows)
            {
                // Kiểm tra dòng không rỗng và không phải là dòng mới chưa commit
                if (row.Cells[0].Value != null)
                {
                    // Dựa vào code của bạn, Giới tính nằm ở Cell[2]
                    string gioiTinh = row.Cells[2].Value.ToString();

                    if (gioiTinh == "Nam")
                    {
                        namCount++;
                    }
                    else if (gioiTinh == "Nữ")
                    {
                        nuCount++;
                    }
                }
            }

            // Gán kết quả vào TextBox
            txt_numNam.Text = namCount.ToString();

            // Nếu bạn có TextBox hiển thị số Nữ thì gán luôn (ví dụ: txt_numNu)
            txt_numNu.Text = nuCount.ToString(); 
        }
        private void txt_numNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào dòng hợp lệ
            if (e.RowIndex >= 0 && e.RowIndex < dgv_students.Rows.Count - 1) // Trừ 1 nếu dòng cuối là dòng trống (allowUserToAddRows)
            {
                DataGridViewRow row = dgv_students.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_ma.Text = row.Cells[0].Value.ToString();
                    txt_hoten.Text = row.Cells[1].Value.ToString();

                    string gioitinh = row.Cells[2].Value.ToString();
                    if (gioitinh == "Nữ") rb_nu.Checked = true;
                    else rb_nam.Checked = true; // Giả sử bạn có rb_nam

                    txt_diem.Text = row.Cells[3].Value.ToString();
                    cmb_khoa.Text = row.Cells[4].Value.ToString();
                }
            }
        }
    }
}
