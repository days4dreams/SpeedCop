using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Need to get from A to B? Not sure what sort of transport you'll need?");
            Console.WriteLine("Let's find the right vechical for your journey");

            Console.WriteLine("Where will your journey start from? Let me know the town, city or street name.");
            string pointA = Console.ReadLine();

            Console.WriteLine("Nice! And where do you need to get to?");
            string pointB = Console.ReadLine();

            Console.WriteLine("Great. How far is it from " + pointA + " and " + pointB + " in miles?");
            string distance = Console.ReadLine();
            double miles = Convert.ToDouble(distance);

            Console.WriteLine("How quickly do you need to get to " + pointB + "? Can state it in minutes?");
            string time = Console.ReadLine();
            double minutes = Convert.ToDouble(time);

            double calculation = 0;
            calculation = Mph(miles, minutes);

            Console.WriteLine("Ok, You'll need to be travelling at " + calculation + " miles per hour.");


                if (calculation < 4) 
                {
                    Console.WriteLine("You can manage that on foot. I suggest you walk");
                } 
                 else if (calculation >= 4.1 && calculation <= 16)
                {
                    Console.WriteLine("Thats a perfect pace for cycling. I suggest you take a bike");
                }
                else if (calculation >= 16.1 && calculation <= 30 ) 
                {
                    Console.WriteLine("The bus should do the trick. I suggest you take public transport");
                }
                 else if (calculation >= 30.1 && calculation <= 60)
                 {
                      Console.WriteLine("Seems like you're in a hurry. I suggest you take the car");
                  }
                else if (calculation >= 60.1 && calculation <= 90)
            {
                Console.WriteLine("You need to get there fast. I suggest you take a cab");
            }
            else
                {
                    Console.WriteLine("Thats a crazy speed. You're going to need a rocket!");
                }


            Console.WriteLine("Have a nice time in " + pointB + ". See you again soon!");
            Console.ReadKey();


        }

        static double Mph(double dist, double t)
        {
            double speed = 0;
            speed = 60 * (dist / t);
            return speed;

        }
    }
}
