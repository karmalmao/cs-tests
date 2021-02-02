using System;

namespace ashkaashh
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;
            bool able = true;

            while (able == true)
            {
                Console.WriteLine("Enter your first number.");

                GetInput(out num1);
                GetInput(out num2);
                if (!GetInput(out num3))
                {
                    Console.WriteLine("Not a valid input.");
                }


                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
        }

        public static bool GetInput(out float result)
        {
            return float.TryParse(Console.ReadLine(), out result);
        }
    }
}
