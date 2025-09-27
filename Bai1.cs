//Viết chương trình nhập điểm số (0–10) của một sinh viên.
//Nếu điểm < 5 → in "Trượt".
//Nếu 5–6.9 → in "Trung bình".
//Nếu 7–8.4 → in "Khá".
//Nếu 8.5 trở lên → in "Giỏi".
//Hỏi người dùng có muốn nhập tiếp (Y/N). Nếu chọn Y → nhập tiếp, nếu N → thoát.


using System;   
class Program    
{
    static void Main(string[] args)
    {
        Bai1();   
    }

    static void Bai1()
    {
        while (true)   
        {
            Console.Write("Nhập điểm (0 - 10): ");  
            double diem;   
            double diem = double.Parse(Console.ReadLine());            
            if (!check || diem < 0 || diem > 10)   
            {
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại!"); 
                continue;  
            }
            if (diem < 5)                         
                Console.WriteLine("Trượt");       
            else if (diem < 7)                    
                Console.WriteLine("Trung bình");  
            else if (diem < 8.5)                  
                Console.WriteLine("Khá");         
            else                                  
                Console.WriteLine("Giỏi");        
            Console.Write("Bạn có muốn nhập tiếp? (Y/N): ");  
            string tieptuc = Console.ReadLine().Trim().ToUpper();              
            if (tieptuc == "N")   
                break;            
        }
    }
}
