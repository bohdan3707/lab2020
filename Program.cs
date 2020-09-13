using System;

namespace lab1sys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть до якого числа Фібоначі рахувати");
            int n = Int32.Parse(Console.ReadLine());

            int perv = 1;
            Console.Write("{0} ", perv);
            int vtor = 1;
            Console.Write("{0} ", vtor);
            int sum = 0;

            while (n >= sum)
            {
                sum = perv + vtor;

                Console.Write("{0} ", sum);

                perv = vtor;
                vtor = sum;
            }
            Console.ReadKey();

        }
    }
}
