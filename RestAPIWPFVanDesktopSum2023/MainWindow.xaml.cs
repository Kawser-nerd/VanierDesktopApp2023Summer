using Newtonsoft.Json;
using RestAPIWPFVanDesktopSum2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
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

        private async void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            // we are going to send the student information/ structure we are getting from 
            // the front-end. We need to create same Students.cs class in this application 
            // as well

            // Our Desktop application is going to communicate with the remote server 
            // through rest api. Once you use the rest API, each rest API will generate a
            // response for you which you need to catch in your program. Our rest API
            // generates the response message as we have designed it in the Response.cs 
            // class. So, we need the same structure/class in the WPF application as well
            // to capture the response properly.

            // create Students class instance to take the information from front-end

            Students student = new Students();
            student.name = Name.Text;
            student.id = int.Parse(Id.Text);
            student.email = email.Text;
            student.term = term.Text;

            // we need to pass this student instance to the remote server using restAPIs we 
            // have created. So, we need to call the restAPi and need to pass the student 
            // instance. We need to call the AddStudent API to pass the student value

            // to use the AddStudent API, we need to generate an http Post request using
            // the httpclient. Once the request is generated, we need to capture the response
            // of the remote server/apis with a Response class instance

            // generate http Post request
            /*
             * We need to use any http request as Asynchronous way to make sure our http 
             * communication is stateless and will wait for the server to response without 
             * expecting that the server will response with the generation of the request.
             * 
             * moreover, we need to use await subprocess to ensure that our httpclient instance
             * will wait for a certain time without keeping our present progress of the wpf
             * application, means it will make the program parallel executable
             */

            var response= await httpClient.PostAsJsonAsync("AddStudent", student);
            
            
            // once we get the response, our next step is to decrypt the response. we can 
            // use one label in the front-end section to get the message visible in the front-end

            /// decrypt the response message

            //responselbl.Visibility = Visibility.Visible; // to make the label visible in the front-end
            //responselbl.Content = response.Content;
            MessageBox.Show(response.StatusCode.ToString());
            //Response res = JsonConvert.DeserializeObject<Response>(response.Content.ToString());
            
            //responselbl.Content = res.statusCode + " " + res.message;

        }

        private async void search_Click(object sender, RoutedEventArgs e)
        {
            var response = await httpClient.GetStringAsync("GetStudentById/" + int.Parse(searchtxt.Text));
        
            Response res = JsonConvert.DeserializeObject<Response>(response);

            responselbl.Visibility = Visibility.Visible;
            responselbl.Content = res.statusCode + " " + res.message;
            Name.Text = res.student.name;
            Id.Text = res.student.id.ToString();
            email.Text = res.student.email;
            term.Text = res.student.term;

        }

        private async void showStudent_Click(object sender, RoutedEventArgs e)
        {
            var response = await httpClient.GetStringAsync("GetAllStudents");

            Response res = JsonConvert.DeserializeObject<Response>(response);

            responselbl.Visibility = Visibility.Visible;
            responselbl.Content = res.statusCode + " " + res.message;

            studentList.ItemsSource = res.students;
            DataContext = this;
        }

        private async void UpdateStudent_Click(object sender, RoutedEventArgs e)
        {
            Students student = new Students();

            student.name= Name.Text;
            //student.id = int.Parse(Id.Text);
            student.email= email.Text;
            student.term= term.Text;

            var response = await httpClient.PutAsJsonAsync("UpdateStudent/"+int.Parse(searchtxt.Text), student);

            MessageBox.Show(response.StatusCode.ToString());

        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            var response = await httpClient.DeleteAsync("DeleteStudentById/" + int.Parse(searchtxt.Text));
            MessageBox.Show(response.ToString());
        }
    }
}
