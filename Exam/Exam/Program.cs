using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.On_time_for_the_Exam_Past_Paper
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourofexam = int.Parse(Console.ReadLine());
            var minofexam = int.Parse(Console.ReadLine());
            var hourofexamarr = int.Parse(Console.ReadLine());
            var minofexamarr = int.Parse(Console.ReadLine());
            var fromhourstominstart = hourofexam * 60;
            var sumofminstart = minofexam + fromhourstominstart;
            var fromhourstominarr = hourofexamarr * 60;
            var sumofminarr = minofexamarr + fromhourstominarr;
            var result = sumofminstart - sumofminarr;
            var hours = 0.0;
            var minutes = 0.0;

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
                        Console.WriteLine("{0} minutes before the start", result);
                    }
                    else
                    {
                        hours = result / 60;
                        minutes = result % 60;
                        Console.WriteLine("Early");
                    }
                    if (hours == 0)
                    {
                        Console.WriteLine("{0} minutes before the start", minutes);
                    }
                    else
                    {
                        if (true)
                        {
                            if (minutes < 10)
                            {
                                Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
                            }
                            else
                            {
                                Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
                            }
                        }
                    }
                }

                else if (result <= 0)
                {
                    Console.WriteLine("Late");
                    if (result >= -60)
                    {
                        int resultallpositive = Math.Abs(result);
                        minutes = resultallpositive % 60;
                        Console.WriteLine("{0} minutes after the start", minutes);
                    }
                    else if (result <= -60)
                    {
                        int resultallpositive = Math.Abs(result);
                        hours = resultallpositive / 60;
                        minutes = resultallpositive % 60;
                        Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
                    }
                }
            }
        }
    }
}