namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Question 1
        Console.Write("Please input a letter grade (A, B, C, D, F): ");

         string input = Console.ReadLine().ToUpper();
        
        switch (input)
        {
            case "A":
                Console.WriteLine("GPA: 4");
                break;
            case "B":
                Console.WriteLine("GPA: 3");
                break;
            case "C":
                Console.WriteLine("GPA: 2");
                break;
            case "D":
                Console.WriteLine("GPA: 1");
                break;
            case "F":
                Console.WriteLine("GPA: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;

        // Code for question 2

     class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        
        int smallest = Math.Min(num1, Math.Min(num2, num3));
        
        Console.WriteLine("The smallest number is: " + smallest);
    }
}   




        

        }
    }
}


       



