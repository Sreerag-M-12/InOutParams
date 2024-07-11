using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParam
{
    
    internal class Program
    {
       
        static void OutAddition(in int n1, in int n2, out int sum)
        {
            sum = n1 + n2;
            if (sum > 50)
                Console.WriteLine("your number is greater than 50 and sum is" + sum);
            else
                Console.WriteLine("your number is less than 50 and sum is" + sum);
            //modification of out parameter inside the function is compulsory

        }
       
        public static void InValue(in int myNumber)
        {
            // myNumber = 10; // This will generate an error
            Console.WriteLine("input"+myNumber);
        }

        public static int ParamAddition(params int[] ListNumbers)
        {
            int total = 0;

            // foreach loop 
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }



        static void Main(string[] args)
        {
            int myNumber1=26, myNumber2=25, sum;
            OutAddition(in myNumber1, in myNumber2, out sum);
            Console.WriteLine("value of sum after functioncall in main "+ sum);

            int myNumber3 = 23;
            InValue(in myNumber3);

            int total = ParamAddition(12, 43, 23, 55, 66);
            Console.WriteLine("sum after parameter addition is " + total);
        }
    }
}
