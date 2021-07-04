using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            string number = Console.ReadLine();
            int numb = int.Parse(number);
            int sum = 0;
            int[] arr_numb = new int[number.Length];
            for (int i = 0; i < arr_numb.Length; i++)
            {
                arr_numb[i] = numb % 10;
                numb = numb / 10;
                sum += arr_numb[i];
            }
            Console.WriteLine(sum);

        }
    }
}
