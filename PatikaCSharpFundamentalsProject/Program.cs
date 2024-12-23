using System;

namespace PatikaCSharpFundamentalsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays program options on console screen
            while (true)
            {
                Console.Write("Hangi programı calistirmak istersiniz?\n1 - Rastgele Sayi Bulma Oyunu\n2 - Hesap Makinesi\n3 - Ortalama Hesaplama\nseceneklerinden birini seciniz: ");
                string option = Console.ReadLine();
                if (option == "1"|| option == "2" || option == "3")
                {
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Rastgele Sayi Bulma Oyunu");
                            break;
                        case "2":
                            Console.WriteLine("Hesap Makinesi");
                            break;
                        case "3":
                            Console.WriteLine("Ortalama Hesaplama");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Gecersiz bir secenek sectiniz. Lutfen gecerli bir secenek seciniz!");
                    Thread.Sleep(1300);
                    Console.Clear();
                }

            }
        }
    }
}


