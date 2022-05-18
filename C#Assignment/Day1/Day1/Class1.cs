using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Class1
    {
        public static void main()
        {
            Console.WriteLine("Generate Hacker Name:");
            Console.WriteLine("Please enter your favorite color.");
            String color = Console.ReadLine();
            Console.WriteLine("Please enter your astrology sign.");
            String sign = Console.ReadLine(); 
            Console.WriteLine("Please enter your address number.");
            String num = Console.ReadLine();

            Console.WriteLine("Your hacker name is "+ color +" "+sign+" "+ num +".");
        }
        
    }
}
