using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace without__
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputPass = Console.ReadLine();

            string correct;
            correct = "s3cr3t!P@ssw0rd";

            if (inputPass == correct)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
