using System; // Sử dụng namespace System để truy cập các lớp cơ bản như Console

namespace PrimeNumberConsole1 // Tạo không gian tên cho dự án Console
{
    class Program // Định nghĩa class chính
    {
        static void Main(string[] args) // Phương thức chính của chương trình
        {
            // Yêu cầu người dùng nhập số bắt đầu
            Console.WriteLine("Nhap so bat dau: ");
            int start = int.Parse(Console.ReadLine()); // Đọc và chuyển đổi dữ liệu từ chuỗi sang số nguyên

            // Yêu cầu người dùng nhập số kết thúc
            Console.WriteLine("Nhap so ket thuc: ");
            int end = int.Parse(Console.ReadLine()); // Đọc và chuyển đổi dữ liệu từ chuỗi sang số nguyên

            // Hiển thị các số nguyên tố trong khoảng từ số bắt đầu đến số kết thúc
            Console.WriteLine("Cac so nguyen to trong khoang {0} den {1} la:", start, end);
            for (int i = start; i <= end; i++) // Vòng lặp qua từng số trong khoảng từ start đến end
            {
                if (IsPrime(i)) // Kiểm tra nếu số i là số nguyên tố
                {
                    Console.Write(i + " "); // In ra số nguyên tố
                }
            }
        }

        // Phương thức kiểm tra số nguyên tố
        static bool IsPrime(int number)
        {
            if (number < 2) return false; // Các số nhỏ hơn 2 không phải số nguyên tố
            for (int i = 2; i <= Math.Sqrt(number); i++) // Kiểm tra các ước từ 2 đến căn bậc hai của number
            {
                if (number % i == 0) // Nếu tìm thấy ước thì không phải số nguyên tố
                {
                    return false;
                }
            }
            return true; // Nếu không tìm thấy ước thì là số nguyên tố
        }
    }
}
