using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

namespace RestAPIWPFVanDesktopSum2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * before jumping to using the RESTAPIs we have created in the desktop application,
         * we need to configure our restAPI connection with the present wpf application
         * 
         * we know RESTAPIs are connected with the remote server with http communication 
         * protocol. So, to communicate with restAPI, we need to configure our Http Communication
         * as well
         */

        HttpClient httpClient = new HttpClient(); // this will help us to configure the HTTP connection
        // for the REMOTE rest APIs

        public MainWindow()
        {
            /*
             * We need to configure our wpf application to ensure proper connection
             * 
             * step 01: Setup the Base address for the REST APIs
             */

            httpClient.BaseAddress = new Uri("https://localhost:7024/api/Students/");

            // step 02: Configure the packets header
            // we first need to clear the present packet header
            httpClient.DefaultRequestHeaders.Accept.Clear();

            // setp 03: Add our customized header information
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            // we are sending request to the server in json format as well as the response
            // we have configured for our application is in JSON format as well. Thus, we need to
            // configure them at the beginning.

            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
