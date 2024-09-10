using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumberLibrary 
{
    public class PrimeNumberChecker 
    {
        // Phương thức kiểm tra số nguyên tố
        public bool IsPrime(int number)
        {
            if (number < 2) return false; // Các số nhỏ hơn 2 không phải số nguyên tố
            for (int i = 2; i <= System.Math.Sqrt(number); i++) // Kiểm tra các ước từ 2 đến căn bậc hai của số
            {
                if (number % i == 0) // Nếu có ước thì không phải số nguyên tố
                {
                    return false;
                }
            }
            return true; // Nếu không tìm thấy ước thì là số nguyên tố
        }
    }
}
