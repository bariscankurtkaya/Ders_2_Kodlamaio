using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 1;
            switch (deger)
            {
                case 1:
                    Console.WriteLine("1 geldi");
                    break;
                case 2:
                    Console.WriteLine("2 geldi");
                    break;
                default:
                    Console.WriteLine("Hiçbir şey gelmedi");
                    break;
            }

            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    Console.Write("Bugün Pazartesi");
                    break;
                case 2:
                    Console.Write("Bugün Salı");
                    break;
                case 3:
                    Console.Write("Bugün Çarşamba");
                    break;
                case 4:
                    Console.Write("Bugün Perşembe");
                    break;
                case 5:
                    Console.Write("Bugün Cuma");
                    break;
                case 6:
                    Console.Write("Bugün Cumartesi");
                    break;
                case 7:
                    Console.Write("Bugün Pazar");
                    break;
            }
        }
    }
}
