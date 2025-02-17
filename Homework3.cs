namespace Homework3;

class Program
{
    static void Main(string[] args)
    {   // code for Question 1
        Console.Write("Enter a number (N): ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 1)
        {
            if (IsPrime(N))
            {
                Console.WriteLine($"{N} is prime");
            }
            else
            {
                Console.WriteLine($"{N} is non-prime");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer greater than 1.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    // code for question 2. I had troublw with this one. 

    {
        Console.Write("Enter a number (N): ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Code for question 3 

        {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            PrintSquarePattern(N);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

    static void PrintSquarePattern(int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

}
