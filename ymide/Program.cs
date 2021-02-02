using System;

namespace ymide
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            bool able = true;
            bool mm = false;
            while (able)
            {
                Console.WriteLine("Enter Number");
                if (!float.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Input.");
                }
                else 
                    {
                        if (num % 4 > 0)
                        {
                            Console.WriteLine("Your number is not divisible by 4");
                        mm = true;
                        }
                        else
                        {
                            Console.WriteLine("Your number is divisible by 4");
                        mm = true;
                        }
                        if (num % 6 > 0)
                        {
                        Console.WriteLine("Your number is not divisible by 6");
                        mm = true;
                        }
                        else
                        {
                        Console.WriteLine("Your number is divisible by 6");
                        mm = true;
                        }
                } 
            }
        }
    }
}

