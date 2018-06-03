using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanovaTraining
{
    class Program
    {
        static void Main(string[] args)

        {
            int inputDays = int.Parse(Console.ReadLine());
            double kilometres = double.Parse(Console.ReadLine());

            double totalKM = kilometres;
            
            for (int i = 0; i < inputDays; i++)
            {
                double percentage = double.Parse(Console.ReadLine());
                kilometres = kilometres + (kilometres * (percentage / 100));
                totalKM += kilometres;    
            }       
                        
            if (totalKM >= 1000)
            {
                double bonus = totalKM - 1000;
                Console.WriteLine($"You've done a great job running {Math.Ceiling(bonus)} more kilometers! ");
            }
            else
            {
                double nedostig = 1000 - totalKM;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(nedostig)} more kilometers");
            }
        }
    }
}
