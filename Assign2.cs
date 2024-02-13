using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test your number with the given set I.");
        Console.WriteLine("I = [2,3[ U ] 0,1] U [-10, -2]");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Enter a real number: ");
            string input = Console.ReadLine();

            double x;
            if (!double.TryParse(input, out x))
            {
                Console.WriteLine("Invalid input. Please enter a valid real number.");
                continue;
            }

            if ((x >= -10 && x < -2) || (x >= 0 && x <= 1) || (x >= 2 && x < 3))
            {
                Console.WriteLine("x belongs to I");
            }
            else
            {
                Console.WriteLine("x does not belong to I");
            }
        }
    }
}
