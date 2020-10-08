using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = Convert.ToInt32(Console.ReadLine());
            var result = Reverse(x);

            Console.WriteLine(result);

        }
        public static int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int remove = x % 10;
                x = x / 10;

                if (result >= Int32.MaxValue / 10  && remove > 7)
                    return 0;
                if (result <= int.MinValue / 10 && result < -8)
                    return 0;
                result = result * 10 + remove;
            }
           
            return (int)result;

           
        }
    }
}
