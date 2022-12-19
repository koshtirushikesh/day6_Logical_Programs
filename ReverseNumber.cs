using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class ReverseNumber
    {
        public static void Display()
        {
            int n = 0, reverse = 0, rem ;
            Console.WriteLine("Enter a Number");
            n=Convert.ToInt32(Console.ReadLine());

            while(n!= 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Nummber " + reverse);
        }
    }
}
