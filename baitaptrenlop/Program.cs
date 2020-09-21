using System;

namespace baitaptrenlop
{
    class Program
    {
        private static object Chuvidientich;

        static void Main(string[] args)
        {
            int choice = 8;
            double cd;
            double cr;
            double a;
            double r;



            while (choice != 0)
            {
                Console.WriteLine("Menu12345");
                Console.WriteLine("1. Khởi tạo hình vuông ");
                Console.WriteLine("2. Khởi tạo hình chữ nhật ");
                Console.WriteLine("3. Khởi tạo hình tròn");
                Console.WriteLine("4. In ra diện tích và chu vi hình vuông");
                Console.WriteLine("5. In ra diện tích và chu vi hình chữ nhật");
                Console.WriteLine("6. In ra diện tích và chu vi hình tròn.");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
               


                Console.WriteLine();
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Nhập cạnh hình vuông : ");
                        a = double.Parse(Console.ReadLine());

                        break;
                    case 2:
                        Console.WriteLine("Nhập chiều dài : ");
                        cd = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng : ");
                        cr = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Nhập bán kính hình tròn : ");
                        r = double.Parse(Console.ReadLine());
                        break;
                    case 4:

                        Console.WriteLine("Dien tich hinh vuong la :" + chuvidientich.dtHV());
                        Console.WriteLine("Chu vi hinh vuong la :" + chuvidientich.cvHV());
                        break;
                    case 5:

                        Console.WriteLine("Dien tich hinh chu nhat la :" + chuvidientich.dtHCN());
                        Console.WriteLine("Chu vi hinh chu nhat la :" + chuvidientich.cvHCN());
                        break;
                    case 6:

                        Console.WriteLine("Dien tich hinh tron la :" + chuvidientich.dtHT());
                        Console.WriteLine("Chu vi hinh tron la :" + chuvidientich.cvHT());
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }

            }
        }
    }

    internal class chuvidientich
    {
        internal static string cvHCN()
        {
            throw new NotImplementedException();
        }

        internal static string cvHT()
        {
            throw new NotImplementedException();
        }

        internal static string cvHV()
        {
            throw new NotImplementedException();
        }

        internal static string dtHCN()
        {
            throw new NotImplementedException();
        }

        internal static string dtHT()
        {
            throw new NotImplementedException();
        }

        internal static string dtHV()
        {
            throw new NotImplementedException();
        }
    }
}