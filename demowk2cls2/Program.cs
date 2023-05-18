using demowk2cls2;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Array Variables: Array is a kind of variable which can store multiple values
         * only under a single name.
         * 
         * You are supposed to use one variable name along with a list of empty spaces 
         * where you are going to store same type of values.
         * 
         * couple of restrictions on Array:
         * 1. the memory size of the array, means number of elements are fixed, You can not
         * update the size/ number of elements in an Array once it is created
         * 
         * 2. Array elements are pointed/accessed using index number. Index number always starts
         * from zero. You can not start from 1, if you, still index zero position will be 
         * there and null/garbage value will be there
         * 
         * 
         * 3. you can not reinitialize/recreate the same array in the prgram.If you recreate
         * it will be considered a new array variable
         * 
         * 4. you can copy the elements of an array to another array without defining the size
         * or number of elements of the later/newly copied array.
        * 
         * 5. usually, we use iterator/loops to traverse each elements of an array and access
         * the index number to get the values of the array (positional value)
         * 
         * 6. you can not resize the array once created, that means, array is a fixed
         * type variable, not a dynamic variable.
         */

        // Regular Array Creation

        //initialization
        // we can initialize array in two ways:

        // 1st way is the same line initialization
        int[] arrayVar = new int[5] { 2, 5, 9, 7, 6 }; // we need to use new to dynamically allocate the memory
                                     //int the program
                                     //[] this is the array size/number of elements

        // 2nd way initialization is to use a loop/iterator to traverse the array elements
        // and access each of the index one by one and put the values

        for(int counter=0; counter<arrayVar.Length; counter++ ) // arrayVar.Length will return
                                                                // the number of elements in the array
        {
            arrayVar[counter] = counter+2;
        }

        // the 2nd way of initialization will also be followed for printing any postional value
        // of the array variable.

        // You can create arrays for any kind of data types. You just need to tell/define 
        // the array datatype at the beginning to let the program know what type of data
        // the array is going to hold.

        //String Array
        /*
                string[] names= new string[2]; // we are going to take two names from user/console

                for(int index=0; index < names.Length; index++)
                {
                    Console.WriteLine("Enter the name for index: " + index);
                    names[index] = Console.ReadLine();
                }

                // to print the values from array

                for(int index = 0; index < names.Length; index++)
                {
                    Console.WriteLine(names[index]);
                }
        */

        // decision structure

        // Let us consider a program, which is going to find out whether a number is even 
        // or odd. Print it back to the user
        /*
        Console.WriteLine("Enter the number");
        double var1 = double.Parse(Console.ReadLine());

        if( var1 % 2 == 0 ) {
            Console.WriteLine("Even Number");
        
        } // using modulus, we get the reminder of a variable after
          // dividing it with any number

        else
        {
            Console.WriteLine("Odd Number");
        }*/

        // if only one line/statement remains after if/else keyword of condition, we can
        // drop the curly braces because the ide consider the next statement after if
        // block as its own/ related line.

        // 

        // Nested if-else
        // WE are going to develop a program which will check the salary and the year of job and
        // year of stay in Canada for pre-approving a loan application

        // To do this program, we are going to see whether the persons salary is more than
        // 50K, at least 2 years of Job experience and over 3 years stay in Canada.
        /*
        decimal salary, jobExp, stayCanada;

        Console.WriteLine("Enter your salary");
        salary = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Experience of Job");
        jobExp = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter your stay in Canada");
        stayCanada = decimal.Parse(Console.ReadLine()); 

        // first we are going to check the salary, if it is true, then we will check the 
        // stay in Canada and if that one is true as well, we will check the year of job experience

        if(salary >= 50000)
        {
            if(stayCanada > 3)
            {
                if (jobExp >= 2)
                {
                    Console.WriteLine("You are approved for the loan you are looking for");
                }
                else
                {
                    Console.WriteLine("You are having less than 2 years job experience in Canada");
                }
            }
            else
            {
                Console.WriteLine("You are staying less that 3 years in Canada");
            }
        }
        else
        {
            Console.WriteLine("Your salary is low, sorry we can not approve you");
        }


        // You can rewrite the whole nested if/else program with relational operator like 
        // &, || and !

        if(salary >= 50000 && stayCanada >3 && jobExp >= 2)
        {
            Console.WriteLine("You are approved for the loan");
        }
        else
        {
            Console.WriteLine("You are not approved for the loan");
        }*/

        /*
         * Lets do a program which will take temperature as input. If the temperature 
         * is less than -5 degree c, you can consider it as cold. If the temperature 
         * is in between -5 degree to 10 degree, we can call it modest temperature. Otherwise
         * we can call it warm.
         */
        /*
        decimal temperature;
        Console.WriteLine("Enter the temperature: ");
        temperature = decimal.Parse(Console.ReadLine());

        if (temperature < -5)
            Console.WriteLine("The temperature is cold");
        else if (temperature >= -5 && temperature <= 10)
            Console.WriteLine("The temperature is moderate");
        else
            Console.WriteLine("The temperature is warm");
        */

        loops lp = new loops(); // creating instance of loop class
        //lp.while_loop(); // using the loop class instance to access any public method/member
        // inside the loop class
        lp.for_each_loop();
    }
}