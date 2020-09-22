using System;

namespace nd
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            string output= "";

            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Blogai ivestas skaicius");
                return;
            }

            for(int i = x; i>0; i-=2)
            {

                for(int j = (x-i)/2;j>0;j--)
                {
                    output += " ";
                }
                for (int k = i; k > 0; k--)
                {
                    output += "x";
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}
