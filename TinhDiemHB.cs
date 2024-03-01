using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TinhDiemHB : Form
    {
        public TinhDiemHB()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            // Khai báo biến
            string strHk1L10 = "", strHk2L10 = "", strHk1L11 = "", strHk2L11 = "", strHk1L12 = "", strHk2L12 = "", strPhepToan = "";

            float hk1l10 = 0, hk2l10 = 0, hk1l11 = 0, hk2l11 = 0, hk1l12 = 0, hk2l12 = 0, ketqua = 0;

            // Lấy thông tin từ trên giao diện người dùng nhập vào từ textBox

            strHk1L10 = txtHk1L10.Text;

            strHk2L10 = txtHk2L10.Text;

            strHk1L11 = txtHk1L11.Text;

            strHk2L11 = txtHk2L11.Text;

            strHk1L12 = txtHk1L12.Text;

            strHk2L12 = txtHk2L12.Text;

            strPhepToan = cboPhepToan.Text;

            if (strHk1L10.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk1L10 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK1L10
                txtHk1L10.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (strHk2L10.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk2L10 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK2L10
                txtHk2L10.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (strHk1L11.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk1L11 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK1L11
                txtHk1L11.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (strHk2L11.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk2L11 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK2L11
                txtHk2L11.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (strHk1L12.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk1L12 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK1L12
                txtHk1L12.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (strHk2L12.Length == 0)
            {
                MessageBox.Show("Bạn cần phải nhập Hk2L12 trước khi thực hiện");

                // Di chuyển con chuột đến txtHK2L12
                txtHk2L12.Focus();

                // Thoát ra và không thực hiện công việc tiếp theo nữa
                return;
            }

            if (string.IsNullOrEmpty(strPhepToan))
            {
                MessageBox.Show("Bạn cần phải chọn phép toán trước khi thực hiện!");

                cboPhepToan.Focus();

                return;
            }

            // Chuyển thông tin lấy được về dạng số và kiểm tra điểm nhập vào
            if (!float.TryParse(strHk1L10, out hk1l10) || hk1l10 < 0 || hk1l10 > 10)
            {
                MessageBox.Show("Điểm HK1 Lớp 10 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk1L10.Focus();
                return;
            }

            if (!float.TryParse(strHk2L10, out hk2l10) || hk2l10 < 0 || hk2l10 > 10)
            {
                MessageBox.Show("Điểm HK2 Lớp 10 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk2L10.Focus();
                return;
            }

            if (!float.TryParse(strHk1L11, out hk1l11) || hk1l11 < 0 || hk1l11 > 10)
            {
                MessageBox.Show("Điểm HK1 Lớp 11 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk1L11.Focus();
                return;
            }

            if (!float.TryParse(strHk2L11, out hk2l11) || hk2l11 < 0 || hk2l11 > 10)
            {
                MessageBox.Show("Điểm HK2 Lớp 11 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk2L11.Focus();
                return;
            }

            if (!float.TryParse(strHk1L12, out hk1l12) || hk1l12 < 0 || hk1l12 > 10)
            {
                MessageBox.Show("Điểm HK1 Lớp 12 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk1L12.Focus();
                return;
            }

            if (!float.TryParse(strHk2L12, out hk2l12) || hk2l12 < 0 || hk2l12 > 10)
            {
                MessageBox.Show("Điểm HK2 Lớp 12 không hợp lệ. Vui lòng nhập điểm trong khoảng từ 0 đến 10.");
                txtHk2L12.Focus();
                return;
            }


            // Chuyển thông tin lấy được về dạng số
            hk1l10 = float.Parse(strHk1L10);

            hk2l10 = float.Parse(strHk2L10);

            hk1l11 = float.Parse(strHk1L11);

            hk2l11 = float.Parse(strHk2L11);

            hk1l12 = float.Parse(strHk1L12);

            hk2l12 = float.Parse(strHk2L12);

            // Xử lý công việc bằng cấu trúc switch case
            switch (strPhepToan)
            {
                case "Tính điểm học bạ sớm (5 kỳ)":
                    ketqua = (hk1l10 + hk2l10 + hk1l11 + hk2l11 + hk1l12) / 5;
                    break;
                case "Tính điểm học bạ (6 kỳ)":
                    ketqua = (hk1l10 + hk2l10 + hk1l11 + hk2l11 + hk1l12 + hk2l12) / 6;
                    break;
            }
            // Hiển thị kết quả
            txtKetQua.Text = ketqua.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng chương trình
            Application.Exit();
        }
    }
}

