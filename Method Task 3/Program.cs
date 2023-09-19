using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = SumOfTwoNumbers(num1, num2);

        Console.WriteLine($"The sum of two numbers is: {sum}");
    }
    static int SumOfTwoNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

   
}
