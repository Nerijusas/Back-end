using System;

namespace Paskaita1
{
    class Program
    {
        static void Main()
        {
            int num1;
            int num2;
            float ans = 0;
            string sign;

            Console.WriteLine("Irasykite pirma skaicu: ");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Blogai ivestas skaicius");
                return;
            }

            Console.WriteLine("Irasykite antra skaicu: ");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Blogai ivestas skaicius");
                return;
            }

            Console.WriteLine("Irasykite zenkla (+,-,*,/): ");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    ans = num1 + num2;
                    break;

                case "-":
                    ans = num1 - num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Dalyba is 0 negalima!");
                        return;
                    }
                    ans = num1 / (float)num2;
                    break;

                case "*":
                    ans = num1 * num2;
                    break;

                default:
                    Console.WriteLine("Blogai ivestas zenklas");
                    return;
            }
            if (num2 > 0)
                Console.WriteLine(string.Format("{0}{1}{2}={3}", num1, sign, num2, ans));
            else
                Console.WriteLine(string.Format("{0}{1}({2})={3}", num1, sign, num2, ans));

        }
    }
}
