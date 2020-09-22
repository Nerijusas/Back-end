using System;

namespace Paskaita3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] skaiciai = new int[] { 9,8,7,6,5,4};

            int[] sorted = sorter(skaiciai);

            for (int i = 0; i<sorted.Length;i++)
            {
                Console.Write(sorted[i]+" ");
            }

        }

        public static int[] sorter(int[] arr)
        {

            int[] sorted = arr;

            for (int i = 0; i< arr.Length-1;i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (sorted[j] > sorted[j+1])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[j+1];
                        sorted[j+1] = temp;
                    }
                }
            }

            return sorted;
        }
    }
}
