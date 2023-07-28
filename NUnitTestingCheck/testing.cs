namespace NUnitTestingCheck { 
public class testing
{
    private static void Main(string[] args)
    {/*
        Console.WriteLine("Insert Number one:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Insert Number two:");
        double b = double.Parse(Console.ReadLine());

        // addition method calling
        addition(a, b);
        */
    }

    // Addition Method
    public double addition(double a, double b)
    {
        return a + b; // logically correct
    }

    // Substraction Method
    public double substraction(double a, double b)
    {
            //return a + b; // logically incorrect.. put plus
            return a - b;
        }

    // Multiplication metho
    public double multiplication(double a, double b)
    {
        return a * b; // logically corrent
    }
    
    // Division method
    public double division(double a, double b)
    {
        return a * b; // logically incorrent
    }
    }
}