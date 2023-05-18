using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoProjectwk2
{
    internal class Program
    {
        static int red = 9; // if we declare any varibale as static, the value of the that
        // variable is going to be updated inside the program and the last time the value
        // the variable got or updated will be its final value.
        static void Main(string[] args)
        {
            /*
             * operations on the Array
             */

            // create an array
            const int size = 5; // when you use const keyword with any variable, you are
                                // going to define that the variable is not going to be updated throught
                                // the program.

            
            //int[] var = new int[size] {1,2,3,4,5};
            /*
            Console.WriteLine("Before update the value of red: "+red);
            red = 25;
            Console.WriteLine("Before update the value of red: " + red);
            */
            //initialize the array
            /*
            int[] var1 = new int[]{ 1, 2, 3, 4, 5 };
            int[] var2 = { 1,2,3,4,5};

            int[] var3 = new int[size];// this kind of array creation is done when we*/
            // plan to initialize values in it in the later part of the code

            // to take input index by index, we can use a loop and access each of the index
            //position one by one
            /*
            for(int i = 0; i < size; i++)
                var3[i]= int.Parse(Console.ReadLine());

            // to print array values on the Console, we need a loop which will iterate over
            // the array, control each index position one by one and will access that index values

            for(int i=0; i<var3.Length; i++)
                Console.Write(var3[i]+" ");

            // another way of accessing the array elements: using foreach

            foreach(int i in var3)
                Console.Write(i + " ");
            */
            /*
             * two Dimensional Array:
             * 
             * Two dimensional Array is a table structure, that means it will have row and column
             * in its data
             * 
             * We need to control iterator to access the elements of a 2D array. THe outer control
             * iterator works as a row controller, whether the inner control iterator works
             * as a column controller.
             * 
             * lets create a two dimensional array
             * 1 2 3
             * 4 5 6 
             * 7 8 9
             */
            /*
            // int [rowsize,columnsize] = new int[rowsize,columnsize];
            int[,] array1 = new int[3, 3] { { 1, 2, 3 },{ 4,5,6}, { 7,8,9} };

            // to access the two dimensional array, we need a loop which will control the rows
            // and another loop(inner loop) which will control the values of each row, means
            // will control the columns

            for(int row=0; row<array1.GetLength(0); row++) // here GetLength(0) will point to 
                                                           //dimension One, which is row number
            {
                for(int col=0; col < array1.GetLength(1); col++) // here GetLength(1) wiill point
                                                           // to dimension two, which is col number
                {
                    Console.Write(array1[row, col] + " ");
                }
                Console.WriteLine();
            }

            int counter = 1;

            foreach (int i in array1)
            {
                Console.Write(i + " ");
                counter++;
                if (counter % 3 == 0) // the value 3 is the column size of the array
                    Console.WriteLine();
            }


            // Class Problem: create a 2D array with 4 rows and 2 columns 
            int[,] array2 = new int[4, 2] { { 1,2},{ 3,4}, { 5,6}, { 7,8} };
            counter = 2;// to define each row will have 2 values at most

            foreach(int i in array2)
            {
                Console.Write(i + " ");
                counter++;
                if(counter % 2 ==0)
                    Console.WriteLine();
            }


            // jagged array: column and row size can be anything, not a structed row and col

            /*
             * 1 2 3 4
             * 5 6
             * 7 8 9
             */
            /*
            int[][] array3 = new int[3][] { new int[4] {1,2,3,4 }, 
                                            new int[2] { 5,6}, 
                                            new int[3] { 7,8,9} }; 

            for(int row=0; row<array3.Length; row++) // outer loop
            {
                for(int col=0; col < array3[row].Length; col++) // inner loop
                {
                    Console.Write(array3[row][col]+ " ");
                }
                Console.WriteLine();
            }

            foreach (int[] outer in array3) // because the foreach loop will consider
                                            // the elements of the array3, which is an 
                                            // one-dimensional array
            {
                foreach(int i in outer) { // inner condition, going to print all the inner values
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }*/

            /*
             * 2.5 8.6 9.6 7.5
             * 2.1 5.8 8.6
             * 2.2 7.8 9.6 9.5 9.85
             * 2.2 3.5 4.7
             * 
             * 
             */
            /*
            decimal[][] array4 = new decimal[4][] { new decimal[4] { 2.5m,8.6m,9.6m,7.5m},
                                                    new decimal[3] { 2.1m,5.8m,8.6m},
                                                    new decimal[5] { 2.2m, 7.8m, 9.6m, 9.5m, 9.85m},
                                                    new decimal[3] { 2.5m,3.5m,4.7m} };
            for(int row=0; row<array4.Length; row++)
            {
                for (int col = 0; col < array4[row].Length; col++)
                {
                    Console.Write(array4[row][col] + " ");
                }
                Console.WriteLine();
            }
            */
            //List structure
            /*
            List<int> listVar1 = new List<int>();

            // to add any values to your list
            listVar1.Add(2); // index position 0
            listVar1.Add(3); // index position 1
            listVar1.Add(4); // index position 2
            foreach (int i in listVar1)
                Console.Write(i + " ");
            Console.WriteLine();
            // to add any specific position, let's say at position 1 want to add 9
            listVar1.Insert(1, 9);

            foreach (int i in listVar1)
                Console.Write(i + " ");
            Console.WriteLine();

            // to get/ access any position value in a C# list: we need to use get()
            for(int index=0; index<listVar1.Count; index++)
            {
                Console.Write(listVar1[index]+" ");
            }
            Console.WriteLine();
            // to remove a value from the list, we need to pass the value, i.e. we need to 
            // delete 3

            listVar1.Remove(3);
            
            foreach (int i in listVar1)
                Console.Write(i + " ");
            Console.WriteLine() ;
            // or your can pass the index position: now list is 2 9 4, we want to delete 9
            // which is position/index 1
            listVar1.RemoveAt(1);

            foreach (int i in listVar1)
                Console.Write(i + " ");
            Console.WriteLine();
            */
            listWork lw = new listWork(); // creating the instance of the class
            lw.AddValue(2);
            lw.AddValue(3);
            lw.AddValue(4);

            foreach(int i in lw.getList())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // add position 2
            lw.AddValuePosition(2, 9);
            foreach (int i in lw.getList())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(lw.getList());


            Console.ReadKey();  
        }
    }
}
