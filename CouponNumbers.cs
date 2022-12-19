using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programing
{
    public class CouponNumbers
    {  
        public static void DisplayCouponNumber()
        {
            Console.WriteLine("enter the number of coupen");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arrayRandomNumber = new int[num];

            for (int i = 0; i < num; i++)
            {
                
                Random random = new Random();
                int RandomNum = 100 + random.Next(899);

                arrayRandomNumber[i] = RandomNum;
                for (int j = 0; j < i; j++)
                {
                    if (arrayRandomNumber[j] == arrayRandomNumber[(i)])
                    {
                        arrayRandomNumber[i] = arrayRandomNumber[i] + 1;
                    }
                }

            }

            for (int i = 0; i < arrayRandomNumber.Length; i++)
            {
                Console.WriteLine(arrayRandomNumber[i]);
            }

        }
    }
}