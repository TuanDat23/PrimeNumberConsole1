using PrimeNumberLibrary; 
using System; 

namespace PrimeNumberConsole2 
{
    class Program 
    {
        static void Main(string[] args)
        {
            PrimeNumberChecker primeChecker = new PrimeNumberChecker(); // Tạo đối tượng từ thư viện kiểm tra số nguyên tố

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
                if (primeChecker.IsPrime(i)) // Kiểm tra nếu số i là số nguyên tố bằng phương thức trong DLL
                {
                    Console.Write(i + " "); // In ra số nguyên tố
                }
            }
        }
    }
}
