//Bài 2 
//Viết chương trình nhập n điểm số của sinh viên (n do người dùng nhập).
//Lưu vào mảng int[].
//Tính và in:
//Điểm trung bình.
//Điểm cao nhất.
//Điểm thấp nhất.

using System;  
class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());   
        int[] diem = new int[n];  
        for (int i = 0; i < n; i++)  
        {
            diem[i] = int.Parse(Console.ReadLine());  
        }
        int tong = 0;        
        int max = diem[0];   
        int min = diem[0];   
        for (int i = 0; i < n; i++)
        {
            tong += diem[i];          
            if (diem[i] > max)        
                max = diem[i];       
            if (diem[i] < min)        
                min = diem[i];        
        }     
        double trungBinh = (double)tong / n;
        Console.WriteLine("\n--- Kết quả ---");
        Console.WriteLine("Điểm trung bình: " + trungBinh);
        Console.WriteLine("Điểm cao nhất: " + max);
        Console.WriteLine("Điểm thấp nhất: " + min);
    }
}
