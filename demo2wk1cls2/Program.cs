internal class Program
{
    static int var11 = 0; // static is a global definition. THis means, the value of this
                          // variable might get updated in any place of the program
                          // and last time the value updated, that value will be fixed for that variable
                          // and you can access it from any method
    private static void Main(string[] args)
    {/*
        //Console.WriteLine("Hello, World!");

        Console.WriteLine("Enter integer value");
        int var1 = 0; // initialize the variable with value 0
        var1 = int.Parse( Console.ReadLine()); // using ReadLine() method we read the input from user
                                               // Console. We get the value in String format
                                               // SO we need to covert the String value to the desired
                                               // datatype of the variable
        // double
        Console.WriteLine("Enter double value");
        double var2 = 0;    
        var2 = double.Parse( Console.ReadLine());

        // decimal
        Console.WriteLine("Enter decimal value");
        decimal var3 = 3;
        var3 = decimal.Parse( Console.ReadLine());
        Console.WriteLine("The integer value is: " + var1);
        Console.WriteLine("The double value is: "+ var2);
        Console.WriteLine("The decimal value is: " + var3);
        
        //String Variable
        Console.WriteLine("Enter your name: " );
        string var4 = Console.ReadLine();
        Console.WriteLine("My name is: " + var4);
        Console.ReadKey();// you need to use ReadKey() method to allow the console screen
        //to hold until you press a key from your keyboard

        // inline type casting
        // we are going to transfer/reallocate the double value to integer variable
        // we are not doing any ASCII value conversation, we are just doing value 
        // reallocation from bigger size to smaller size
        //var1 = (int) var2;
        // decimal to double
        //var2 = (double)var3;

        // Arithmatic Operation
        /*
         * Addition: +
         * Substraction: -
         * Multiplication : *
         * division: -
         * Modulus : %
         */

        // Addition of variable 1 and two

        // 12 + 25.0 = 37.0

        // if we are trying to add two differnt datatype of values, we always need to 
        // assign that addion result to higher order datatype among the variables.
        // i.e. double is higher than int/decimal. If you are performing any kind of
        // arithmatic operations with these two type variable, we need to assign/hold it
        // inhigher order variable, which is double for this case
        /*double var5 = var1 + var2;
        Console.WriteLine("The addition of first two numbers are: " + var5);

        // substraction
        double var6 = var1 - var2;
        Console.WriteLine("The substraction of first two numbers are: " + var6);

        // multiplication
        double var7 = var1 * var2;
        Console.WriteLine("The multiplication of the first two numbers are: " + var7);

        // division
        double var8 = var1 / var2;
        Console.WriteLine("The division of the first two numbers are: " + var8);

        // Modules: Will always take the reminder 
        double var9 = var1 % var2;
        Console.WriteLine("The modulus of the first two numbers are: " + var9);

        // Exception Handling
        // WE perform the exception handling in the target that if any exception happens
        // to the program, it can give a warning and by-pass that code section/ method

        // lets say, we are going to divide a number with 0, which mathmatically we can't
        // if that happens, the program will generte an error and will stop execution,

        // to solve/avoid this kind of issue in program, we use dividebyzero exception
        */

        // whatever you are going to put inside the try block, it will be considered as their
        // local property and local scope variable.. operations or the variables declared in this 
        // try block scope will not visible to the other part of your program.

        double var2, var3;
        const int var10 = 10; // constant is a kind of variable which we are defining at the
        // declaration point that the value of this variable is not going to be changed
        // or updated any time or any place of the program/solution. It is fixed

      
        
        try
        {
           
            var2 = var10 / var11;
            var3 = var10 / var11;

        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        /*catch(Exception ex) // Exception class is the superclass, its going to catch all types of exception
        {
            Console.WriteLine(ex.StackTrace);
        }*/
        Console.WriteLine("Enter Name: ");
        string name=Console.ReadLine();
        Console.WriteLine(name);

    }
}