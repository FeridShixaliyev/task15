using System;
using System.Collections.Generic;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
           
            bool check = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1. Tələbə əlavə et");
                Console.WriteLine("2. Tələbəyə imtahan əlavə et");
                Console.WriteLine("3. Tələbənin bir imtahan balına bax");
                Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
                Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
                Console.WriteLine("6. Tələbədən imtahan sil");
                Console.WriteLine("0. Proqramı bitir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Telebenin adini daxil edin :");
                        string name = Console.ReadLine();
                        students.Name = name;
                        students.Add(name);
                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine("Telebenin adini daxil edin");
                        string stuname = Console.ReadLine();
                        Console.WriteLine("Telebenin no-sunu daxil edin");
                        string no = Console.ReadLine();
                        Convert.ToInt32(no);
                        break;
                    case "4":

                        break;
                    case "5":
                        int v = Student.GetExamAvg();
                        break;
                    case "6":

                        break;
                    case "0":
                        check = false;
                        break; 
                    default:
                        Console.WriteLine("Duzgun secim edin !!");
                        break;
                }

            } while (check);
            
        }
    }
    
}
