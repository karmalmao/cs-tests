using System;
using System.Collections.Generic;
using System.Text;

namespace aie_01_helloworld
{
    public class circlecalculator
    {
        double pi = 3.14159265359;
        float rad;
        bool able;





        public void circcalc()
        {            
            {
                Console.WriteLine("Radius? ");

                while (able)
                {
                    if (!float.TryParse(Console.ReadLine(), out rad))
                    {
                        Console.WriteLine("Not a valid float");
                        Console.WriteLine("Radius? ");
                    }
                    else
                    {
                        Console.WriteLine($" Circumference = {2 * pi * rad}");
                        Console.WriteLine($" Area = {pi * (rad * rad)}");

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        able = false;

                    }
                }
            }
        }
    }
}
