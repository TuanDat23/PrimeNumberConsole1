using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrimeNumberWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindPrimes_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô nhập
            int start = int.Parse(txtStart.Text);
            int end = int.Parse(txtEnd.Text);

            PrimeNumberChecker primeChecker = new PrimeNumberChecker(); // Tạo đối tượng từ DLL
            string result = "Prime numbers: "; // Khởi tạo chuỗi kết quả

            // Vòng lặp kiểm tra các số trong khoảng
            for (int i = start; i <= end; i++)
            {
                if (primeChecker.IsPrime(i)) // Kiểm tra số nguyên tố
                {
                    result += i + " "; // Thêm số nguyên tố vào kết quả
                }
            }

            lblResult.Text = result; // Hiển thị kết quả lên label
        }
    }
}
