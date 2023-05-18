using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demowk2cls2
{
    internal class loops
    {
        public void while_loop()
        {
            // Lets see a program which will take input a value and multiple it with inself 
            // for certain time, we can call it finding out power of that value

            // ie. given input 5, for a certain power 2, it will perform 5 * 5 for once, for
            // power 3, it will do 25 * 5 .

            Console.WriteLine("Enter the value you want to find the power");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for power");
            int power = int.Parse(Console.ReadLine());

            int counter = 2; // here the counter will work as power. If your power it 1
            // that means only one of the value is present, that means the value itself. 
            // other than that, the power shows the times of multiplying the value
            // by itself
            int result = input; // the reason of this line is to avoid input value * 1.
            // because the result of multiplying any value with 1 is the value it.
            
            // the while loop will check the condition and insert to the loop scope only
            // if the condition is true. Once entered, it will stay in the loop scope 
            // until the condition breaks/ becomes false
            while (counter <= power) {
                result = result * input; // this will multiply the value with its previous mul
                // tiplication results and will update it on the result variable

                // after performing the calculation statements, don't forget to increament
                // of decrement your counter.. otherwise, your condition will be true forever
                // and it will continue its execution

                counter = counter + 1; // counter++, which always increatment the present
                // value of the variable with 1
            }
             // we can concatenate string and any other datatype with + for string or 
             // insider the method which accepts string value
            Console.WriteLine("The power " + power + " of value " + input + "is: " + result);

        }

        public void do_while() {
            // do-while is the same as while loop, only difference is that the condition of the 
            // loop will be checked after the execution of the loop scope once.

            // for any program, if you need to exeute the loop code scope at least once
            // you should use do while, because it ensures that the code scope/statements
            // which execute at least once without any condition checking.

            Console.WriteLine("Enter the value for finding out power");
            int var = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for power");
            int power = int.Parse(Console.ReadLine());
            int counter = 2;
            int result = var;

            do
            {
                result = result * var;
                counter = counter + 1;
            } while (counter<=power);
            Console.WriteLine("The power " + power + " of value " + var + "is: " + result);
        }

        public void for_loop()
        {
            // in for loop, it helps us to put all the properties of the loop, say counter, condition
            // and counter increment/decrement in the same code space/in same line.. you don't 
            // need to track the loop properties/ code parts in different sections of the code

            Console.WriteLine("Enter the value for finding out power");
            int var = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for power");
            int power = int.Parse(Console.ReadLine());
            int result = var;


            for(int counter=2; counter<=power; counter++)
            {
                result = result * var;
            }
            Console.WriteLine("The power " + power + " of value " + var + "is: " + result);
        }

        public void for_each_loop()
        {
            // foreach loop is an iterator. It automatically iterator over any list or collection
            // it takes/holds an element of an array and then iterates over the array element
            // by element

            int[] array = new int[5] { 56,78,98,25,45};

            //foreach syntax: foreach(datatype element_holder_variable in collection_variable_name ) 
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
