using System;
namespace uppgift3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange två tall");
            Console.WriteLine("första talet");
            float ett = int.Parse(Console.ReadLine());
            Console.WriteLine("andra talet");
            float två = int.Parse(Console.ReadLine());
            Console.WriteLine("Valej en av följande 1. Addiaton 2. Subtratikon 3. Multiplatikon 4. Divison. Ange tal för den svar snälla");
            int metod = int.Parse(Console.ReadLine());
            switch (metod)
            {
                case 1:
                    Console.WriteLine("Du valed Addiaton");
                    float et = ett + två;
                    Console.WriteLine("Den svar är " + et + " .");
                    break;
                case 2:
                    Console.WriteLine("Du valde subtratikon");
                    float tv = ett - två;
                    Console.WriteLine("Den svar är " + tv + " .");
                    break;
                case 3:
                    Console.WriteLine("Du valde divison");
                    float tr = ett * två;
                    Console.WriteLine("Den svar är " +tr+ " .");
                    break;
                case 4:
                    Console.WriteLine("Du valde divison");
                    float fe = ett / två;
                    Console.WriteLine("Den svar är " + fe + " .");
                    break;
            }

        }

    }
}