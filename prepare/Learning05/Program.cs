using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Sammuel Bennet");
        assignment.SetTopic("Multiplication");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetStudentName("Roberto Rodriguez");
        mathAssignment.SetTopic("Fractions");
        mathAssignment.SetTextBook("7.3");
        mathAssignment.SetProblems("8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.SetStudentName("Mary Waters");
        writingAssignment.SetTopic("European History");
        writingAssignment.SetTitle("The causes of World War II");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}