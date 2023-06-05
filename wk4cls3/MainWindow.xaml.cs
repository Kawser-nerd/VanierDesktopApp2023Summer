using System;
using System.Collections.Generic;
using System.Linq;
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

namespace wk4cls3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        /*
         * Any of the action Listner in C# wpf applicaitons are trigger based
         * That means, the action listner only becomes active when any trigger happens
         * 
         * Each of the action Listner method carries two parameters, one is the
         * object sender, which works as a data binder from the front-end interface
         * to the backend code. The second parameter is the behaviour of the 
         * triggered event, that means it will tell the program what kind of event
         * is going to be triggered/execute at the time of accessing that action
         * listner method. For example, RountedEventArgs is an event trigger class
         * which generates a communication from the front-end interface to the back-end
         * code, means it will load every time when you interact with the front-end control
         */
        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            // To get the text/ number from the textbox control, we need to provide the
            // textbox name and the variable text
            // anything we get from textBox control, always be in String Format
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse(textBoxTwo.Text);

            result.Content = (a + b).ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBoxOne.Clear();
            textBoxTwo.Clear();
            result.Content = ""; // it will put empty string on the result label
        }

        private void Substraction_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse (textBoxTwo.Text);

            result.Content = (a - b).ToString();
        }

        private void textBoxOne_TextChanged(object sender, EventArgs e)
        {
            textBoxOne.Clear();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            // to call another wpf class, we need to create the instance of that class
            GridLayOutCalc grC = new GridLayOutCalc();
            grC.Show();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            sp.Show();
        }

        private void WrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel wp = new WrapPanel();
            wp.Show();
        }

        // Now perform action listner for multiplication, division and modulus and 
        // show the result in the result label
    }
}
