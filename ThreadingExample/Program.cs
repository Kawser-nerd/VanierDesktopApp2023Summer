using System.Threading;

// THis program only shows the inclass multithreading. You are going to make the class parallely executing
// different methods 
namespace ThreadingExample{ 
    internal class Program
    {
        private static void Main(string[] args)
        {
            BackGroundWorkerProcess workerProcess = new BackGroundWorkerProcess();
            workerProcess.background_start();
            /// Run the threads in the main program. Run means creating the instances as well as start/stop
            /// or kill the threads

            /*
             * To create and execute any thread, we first need to create the instances of the Thread class
             * and then for each instance, we need to pass one single logic/program/method
            */

            // Configure/creating the threads
            Thread thread1 = new Thread(ThreadOne) // you just need to pass the methodname without parameters
            {
                Name = "Thread 1"
            }; // this means you are setting the properties for your thread instead of creating any new class
            // it is similar to the interfacing in c#

            Thread thread2 = new Thread(threadTwo)
            {
                Name = "Thread 2"
            };

            Thread thread3 = new Thread(threadThree)
            {
                Name = "Thread 3"
            };

            // starting the Threads
            //thread1.Start(); // to start the threads, we need to call the instances of the threads and start them
            //thread2.Start();
            //thread3.Start();

            // Once all the threads are done with execution, they will be killed.
            //Console.WriteLine("All the threads are done/Executed");
            //ThreadOne();
            //threadTwo();
            //threadThree();
            Console.ReadKey();
            
         }

        /// First method for thread1: We are going to print from 1 to 10 with 0.1s delay with thread name
        
        private static void ThreadOne()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("We are in Thread One"+ Thread.CurrentThread.Name + " values "+i);
                Thread.Sleep(300); // this will make the thread wait for 0.1 sec. Ususally insider the 
                // sleep method, we pass the values in ms format. so, 100ms means 0.1 s.
            }
        }

        /// Second method for thread2: We are going to print from 1 to 10 with 0.5s delay with thread name
        private static void threadTwo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("We are in Thread Two " + Thread.CurrentThread.Name + " values " + i);
                Thread.Sleep(600); // this will make the thread wait for 0.5 sec. Ususally insider the 
                // sleep method, we pass the values in ms format. so, 500ms means 0.1 s.
            }
        }

        /// Third method for thread3: We are going to print from 1 to 10 with 1s delay with thread name
        private static void threadThree()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("We are in Thread Three " + Thread.CurrentThread.Name + " values " + i);
                Thread.Sleep(900); // this will make the thread wait for 1 sec. Ususally insider the 
                // sleep method, we pass the values in ms format. so, 1000ms means 0.1 s.
            }
        }
    }
}