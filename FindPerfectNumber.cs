using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public static class FindPerfectNumber
    {
        public static void DisplayFindNumber() 
        {
            int nmin = 0,  nmax = 0,n=0,i,sum;
            Console.WriteLine("Find the Perfect number within the given number ");
            Console.WriteLine("Enter the minimun number ");
            nmin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the maximum number ");
            nmax = Convert.ToInt32(Console.ReadLine());

            for (n=nmin;n<=nmax;n++) 
            {
                i = 1;
                sum = 0;

                while(i<n)
                {
                    if (n%i==0)
                        sum=sum+i;
                    i++;

                }
                if (sum == n)
                    Console.Write(" {0}", n);
            
            }

        }
    }
}
