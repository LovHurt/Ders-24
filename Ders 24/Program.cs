using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            var result3 = Add3(4);
            int number3 = 20;
            int number4 = 100;
            var result4 = Add4(out number3, number4);

            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(number3);

            Console.WriteLine(result);
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(int x, int number1 = 20, int number2 = 30)
        {
            var result3 = number1 + number2;
            return result3;
        }
        static int Add4(out int number3, int number4)
        {
            number1 = 30;
            return number3 + number4;
            
        }
    }
}