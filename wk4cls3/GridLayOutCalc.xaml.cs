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
using System.Windows.Shapes;

namespace wk4cls3
{
    /// <summary>
    /// Interaction logic for GridLayOutCalc.xaml
    /// </summary>
    public partial class GridLayOutCalc : Window
    {
        bool numbers = false;
         double total = 0; // for working with only one input text
        // we need a global variable so that we can perform our
        // operation inside any method body and can update the values
        // to it. So, everytime we are going to perform operation
        // with the lasttime updated results

        // we need to make the total value static to make sure the value
        // updated last time will be stored properly.
        public GridLayOutCalc()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBoxOne.Clear();
            textBoxTwo.Clear();
            textBoxSingle.Text = "Insert New Numbers";
            Result.Content = "0";
            numbers = false;
            
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            /*
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse(textBoxTwo.Text);
            */

            /*
             * At the beginning, as we don't have any value for the 
             * first number, we need to put a check.If it is the first
             * time number entry, we know the numbers bool value will
             * be false. At that time, our global value will hold the 
             * entry directly. 
             * 
             * When numbers are true, they are going to perform the
             * mathematical operation on the given value and the value in 
             * total
             */
            if (numbers)
                total += double.Parse(textBoxSingle.Text);
            else
            {
                total = double.Parse(textBoxSingle.Text);
                numbers = true;
            }
            
            Result.Content = (total).ToString();
        }

        private void Substraction_Click(object sender, RoutedEventArgs e)
        {/*
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse (textBoxTwo.Text);
            */
            if (numbers)
                total -= double.Parse(textBoxSingle.Text);
            else
            {
                total = double.Parse(textBoxSingle.Text);
                numbers = true;
            }

            Result.Content = (total).ToString();

            //Result.Content = (a - b).ToString();


        }

        private void Multiplicaiton_Click(object sender, RoutedEventArgs e)
        {/*
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse(textBoxTwo.Text);

            Result.Content = (a * b).ToString();
            */

            if (numbers)
                total *= double.Parse(textBoxSingle.Text);
            else
            {
                total = double.Parse(textBoxSingle.Text);
                numbers = true;
            }

            Result.Content = (total).ToString();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {/*
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse(textBoxTwo.Text);

            Result.Content = (a / b).ToString();
            */
            if (numbers)
                total /= double.Parse(textBoxSingle.Text);
            else
            {
                total = double.Parse(textBoxSingle.Text);
                numbers = true;
            }

            Result.Content = (total).ToString();
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {/*
            double a = double.Parse(textBoxOne.Text);
            double b = double.Parse(textBoxTwo.Text);

            Result.Content = (a % b).ToString();
            */

            if (numbers)
                total %= double.Parse(textBoxSingle.Text);
            else
            {
                total = double.Parse(textBoxSingle.Text);
                numbers = true;
            }

            Result.Content = (total).ToString();
        }
    }
}
