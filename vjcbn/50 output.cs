using System;

namespace vjcbn
{
    class Program
    {
        static void Main(string[] args)
        {
            float numb;
            bool able = true;





            while (able == true)
            {
                Console.WriteLine("Enter a number.");
                if (!float.TryParse(Console.ReadLine(), out numb))
                {
                    Console.WriteLine("Not a valid number");


                }
                else
                {
                    if (numb > 50)
                    {
                        Console.WriteLine("Output is higher than 50.");
                    }
                    else
                    {

                        if (numb < 50)
                        {
                            Console.WriteLine("Output is lower than 50.");
                        }

                    }
                    able = false;
                }
            }
        }
    }
}
