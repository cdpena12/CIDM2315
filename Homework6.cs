namespace Homework6;

class Program
{
    static void Main(string[] args)
    {

    // code for question 1 and 2 Professor

    class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string name, string course, double salaryAmount)
    {
        profName = name;
        classTeach = course;
        salary = salaryAmount;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Professor: {profName}, Teaches: {classTeach}, Salary: {salary}");
    }
}

// code for student 

class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string name, string course, double grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = grade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {studentName}, Enrolled in: {classEnroll}, Grade: {studentGrade}");
    }
}
        Console.WriteLine("Hello, World!");
    }
}


// code for question 2 

