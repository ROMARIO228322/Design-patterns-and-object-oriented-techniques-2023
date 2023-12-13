using System;

// Printer class follows the Singleton pattern.
public class Printer
{
    private static Printer? _instance;

    private Printer() { }

    public static Printer Instance()
    {
        if (_instance == null)
        {
            _instance = new Printer();
        }
        return _instance;
    }

    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}

// Interface for all types of exams
public interface IExam
{
    void Conduct();
    void Evaluate();
    void PublishResults();
}

// Abstract factory for creating exams
public abstract class ExamFactory
{
    public abstract IExam CreateExam();
}

// MathExam class implementing IExam
public class MathExam : IExam
{
    public void Conduct() => Printer.Instance().Print("Conducting Math Exam");
    public void Evaluate() => Printer.Instance().Print("Evaluating Math Exam");
    public void PublishResults() => Printer.Instance().Print("Publishing Math Exam Results \n");
}

// Factory for creating MathExams
public class MathExamFactory : ExamFactory
{
    public override IExam CreateExam() => new MathExam();
}

// ScienceExam class implementing IExam
public class ScienceExam : IExam
{
    public void Conduct() => Printer.Instance().Print("Conducting Science Exam");
    public void Evaluate() => Printer.Instance().Print("Evaluating Science Exam");
    public void PublishResults() => Printer.Instance().Print("Publishing Science Exam Results \n");
}

// Factory for creating ScienceExams
public class ScienceExamFactory : ExamFactory
{
    public override IExam CreateExam() => new ScienceExam();
}

// ProgrammingExam class implementing IExam
public class ProgrammingExam : IExam
{
    public void Conduct() => Printer.Instance().Print("Conducting Programming Exam");
    public void Evaluate() => Printer.Instance().Print("Evaluating Programming Exam");
    public void PublishResults() => Printer.Instance().Print("Publishing Programming Exam Results \n");
}

// Factory for creating ProgrammingExams
public class ProgrammingExamFactory : ExamFactory
{
    public override IExam CreateExam() => new ProgrammingExam();
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Initialize Printer using Singleton pattern
        Printer p1 = Printer.Instance();

        // Test that the created Printer works
        p1.Print("This is a test message");

        // Ensure that only one Printer instance is used throughout the application
        Printer p2 = Printer.Instance();
        bool isSameInstance = ReferenceEquals(p1, p2);
        Console.WriteLine("It is the same instance: " + isSameInstance);

        // Use Abstract Factory to create different types of exams
        ExamFactory mathExamFactory = new MathExamFactory();
        IExam mathExam = mathExamFactory.CreateExam();
        mathExam.Conduct();
        mathExam.Evaluate();
        mathExam.PublishResults();

        ExamFactory scienceExamFactory = new ScienceExamFactory();
        IExam scienceExam = scienceExamFactory.CreateExam();
        scienceExam.Conduct();
        scienceExam.Evaluate();
        scienceExam.PublishResults();

        ExamFactory programmingExamFactory = new ProgrammingExamFactory();
        IExam progExam = programmingExamFactory.CreateExam();
        progExam.Conduct();
        progExam.Evaluate();
        progExam.PublishResults();
    }
}
