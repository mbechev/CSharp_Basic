using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourStart = int.Parse(Console.ReadLine());
            int minStart = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            int hourStarInMin = hourStart * 60;
            int totalStartMin = minStart + hourStarInMin;

            int hourArriveInMin = hourArrive * 60;
            int totalArriveMin = minArrive + hourArriveInMin;

            int result = totalStartMin - totalArriveMin;
            int min = 0;
            int hour = 0;

            if (result == 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                if (result > 0)
                {
                    if (result <= 30)
                    {
                        Console.WriteLine("On time");
                        Console.WriteLine($"{result} minutes before the start");
                    }
                    else
                    {
                        hour = result / 60;
                        min = result % 60;
                        Console.WriteLine("Early");
                    }
                    if (hour == 0)
                    {
                        Console.WriteLine($"{min} minutes before the start");
                    }
                    else
                    {

                        if (min < 10)
                        {
                            Console.WriteLine($"{hour}:0{min} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hour}:{min} hours before the start");
                        }
                    }
                }
                else if (result <= 0)
                {
                    Console.WriteLine("Late");
                    if (result >= -60)
                    {
                        min = Math.Abs(result % 60);
                        Console.WriteLine($"{min} minutes after the start");
                    }
                    else if (result <= -60)
                    {
                        min = Math.Abs(result % 60);
                        hour = Math.Abs(result / 60);
                        if (min < 10)
                        {
                            Console.WriteLine($"{hour}:0{min}hours after the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hour}:{min}hours after the start");
                        }
                    }
                }
            }
        }
    }
}
