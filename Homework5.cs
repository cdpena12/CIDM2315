namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // code for question 1
        int maxNumber = GetLargestNumber();
        Console.WriteLine("The largest number is: " + maxNumber);
    }

    static int GetLargestNumber() {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        return (num1 > num2) ? num1 : num2;
    }


    static int GetLargestNumber()
    {
        Console.Write("Enter first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        
        return Math.Max(num1, num2);
    }

    // code for question 2
    static int GetLargestOfFour()
    {
        Console.Write("Enter first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third integer: ");
        int num3 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter fourth integer: ");
        int num4 = int.Parse(Console.ReadLine());
        
        int largestFirstPair = Math.Max(num1, num2);
        int largestSecondPair = Math.Max(num3, num4);
        
        return Math.Max(largestFirstPair, largestSecondPair);
    }

    static void Main()
    {
        int largest = GetLargestOfFour();
        Console.WriteLine("The largest number is: " + largest);
    }

     // Code for question 3 
    {
    static bool CheckAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        Console.Write("Re-enter password: ");
        string confirmPassword = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear;
        while (!int.TryParse(Console.ReadLine(), out birthYear))
        {
            Console.Write("Invalid input. Enter a valid birth year: ");
        }

        if (CheckAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

    static void Main()
    {
        CreateAccount();
    }
}
