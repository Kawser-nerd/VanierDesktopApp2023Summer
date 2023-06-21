using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;


namespace ThreadingExample
{
    internal class BackGroundWorkerProcess
    {
        
        /*
         * Each of the background worker/ individual worker system in c# consists of three different properties
         * or section. The properties are, the work to do, the working progress and the process to do after the
         * worker's work is completed.
         */

        public BackgroundWorker backgroundWorker = new BackgroundWorker();

        public void background_start()
        {
            backgroundWorker.RunWorkerAsync();
        }
        // The previous line only helps use to create and instance of the backgroundWorker

        // The following backgroundWorker_DoWork method consist the work which it is asked/assgined to do
        // we can call an external method to perform the job or we can implement the work we are going to 
        // pass to the worker in this method

        /*
         * we are going to execute a program that is going to print from 1 to 10 with 0.5 s gap
         */
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=1;i<=10; i++)
            {
                Console.WriteLine("The worker is printing " +i);

                Thread.Sleep(500);

                this.backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("The worker's work is finished");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // this progress changed section is used for informing the User Iterface.
            Console.WriteLine(e.ProgressPercentage);
        }

    }
}
