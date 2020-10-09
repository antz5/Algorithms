using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        var x = Convert.ToInt32(Console.ReadLine());
        var result = IsPalindrome(x);
        Console.WriteLine(result);
    }

    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        int input = x;
        int result = 0;

        while (x != 0)
        {
            int pop = x % 10;
            x = x / 10;

            result = result * 10 + pop;
        }
        return (result == input);

    }
}