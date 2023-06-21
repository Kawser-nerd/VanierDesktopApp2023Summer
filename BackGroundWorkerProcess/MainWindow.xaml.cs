using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackGroundWorkerProcess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * Creating BackGroundWorker
         */

        BackgroundWorker bgworker = new BackgroundWorker();
        int counterMax =100;
        public MainWindow()
        {
            // we need to override the backgroundWorker interfaces with the custom methods we designed
            // over here

            bgworker.DoWork += bgworker_DoWork;
            bgworker.RunWorkerCompleted += bgworker_RunWorkerCompleted;
            bgworker.ProgressChanged += bgworker_ProgressChanged;

            // the following property will enable the cancellation property of bgworker
            // if you don't enable it, you can not stop the background worker once it started working
            bgworker.WorkerSupportsCancellation = true;
            
            // the following property enables the intermediate report system to our background worker
            // if you don't enable it, you can only see the worker has started and completed after 
            // execution, no internal states will be reported to you at any time.
            bgworker.WorkerReportsProgress = true;

            InitializeComponent();
        }

        //step 01: This method is the first method to create/active a background worker. In this method
        // we are going to send the works the worker is going to perform/work
        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int counter=1; counter <= counterMax; counter++)
            {
                Console.WriteLine(counter);
                //lbCounter.Content = counter;
                // going to update it to the program
                bgworker.ReportProgress(counter); // we need the percentage caculation at the 
                // time of reporting the progress.
                Thread.Sleep(200); // sleep the system for 0.5 s
                                   // if you stop the system, it will trigger the runcompleted method. Before performing
                                   // the full completion, we need to hault the worker. To do that, we need to set
                                   // background worker in workprogress pending state

                if (bgworker.CancellationPending)
                {
                    e.Cancel = true;
                    break; // to get out from the loop
                }
            }
        }

        // step 02: The following method gets invoked if the bgworker report any progress to the system
        // if the method gets invoked, it visualize the update it gets from the background event
        // ProgressChangedEventArgs just capture the trigger sends by the system and send it back to the
       // program.
        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // = e.ProgressPercentage;
            lbCounter.Content = e.ProgressPercentage;
            progressBarWorker.Value = e.ProgressPercentage;
            // previous line is going to update the progressBarWorker at the frontend section
        }

        // step 03: the following method will get invoked only if the back ground worker completes
        // its assigned job. I.E. if the worker gets a file download job, once the file downloaded 
        // properly from the remote server to the local machine, the background worker invokes the 
        // following method and executes it sequentially.

        private void bgworker_RunWorkerCompleted(object send, RunWorkerCompletedEventArgs e)
        {
            // if the worker get trigger to stop
            if (e.Cancelled)
                lbCounter.Content += "  \nStopped";// \n is the newline command
            else
                lbCounter.Content += "   \nCompleted";

            startBtn.Content = "Start";
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            /*
             * this will work as a start/stop button. This button will invoke the bgworker or cancel
             * its execution. If the worker is not busy, that means nobody has started it. So, we can 
             * start the bgworker and change the content of the button to Stop
             * 
             * If the bgworker is busy, that means the worker is already in progress. So, if the button
             * gets triggered, means the program needs to stop the worker and change the button content
             * to Start to bring the program in working/starting condition
             */

            if (!bgworker.IsBusy)
            {
                // start the background worker
                bgworker.RunWorkerAsync(); // we need to run the background worker asynchronously to 
                //execute it independently

                // button content change for next interaction
                startBtn.Content = "Stop";
            }
            else
            {
                // this will work for cancelling the bgworker
                bgworker.CancelAsync();
                startBtn.Content = "Start";
            }
        }
    }
}
