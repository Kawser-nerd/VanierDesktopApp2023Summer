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
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        // We want to send the values to the listBox from the backend code
        string[] nameofcities { set; get; }

        string[] nameofFruits { set; get; }
        public Controls()
        {
            InitializeComponent();

            nameofcities = new string[] { "Ottawa", "Toronto", "Halifax", "Quebec City", "Gatineou", "NewYork" };

            nameofFruits = new string[] { "Banana", "BlackBerry", "Tomato", "Red Apple", "Cantaloque" , "Papywa" };
            // In the following line, you need to define the source of the items you are going to add to the
            // listBox of your GUI controls, i.e. in my case, I added a string array contents as a source of
            // items to the listBox control
            listBox.ItemsSource = nameofcities;
            comboBox.ItemsSource = nameofFruits;
            DataContext = this; 
            /*
             * DataContext generates a binding from the backend to the front end program section. In this line
             * we used this to send all the class variables from the back-end code section to the front-end
             * XAML section.
             */
        }

        // Action Listner for Button
        private void lb_Selection_Click(object sender, RoutedEventArgs e)
        {
            /*
             * This code works only when the selection mode for listBox is single
             * 
             * 
            string selectedCity = listBox.SelectedItem.ToString();
            // System.Listbox : Value
            selectedCity = selectedCity.Split(':')[1];

            MessageBox.Show(selectedCity);
            */

            // The following code block will work if multiple items can be selected from the ListBox

            string selectedValues = "";

            // listBox items are actually a collection and we can run/iterate foreach method on top of the collection.
            foreach (ListBoxItem item in listBox.SelectedItems)
            {
                selectedValues += item.Content + "  ";
            }
            MessageBox.Show(selectedValues);

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
             * if you are going to work with any control which is going to trigger at the time of loading the class
             * or statring of the class, we need to see whether the control is loaded perfectly or not
             */
            
            if(IsLoaded) // if your program is loaded perfectly, it will return a true, which will make the condition true
            {
                string selectedValues = "";

                // listBox items are actually a collection and we can run/iterate foreach method on top of the collection.
                foreach (ListBoxItem item in listBox.SelectedItems)
                {
                    selectedValues += item.Content + "  ";
                }
                MessageBox.Show(selectedValues);
            }
        }

        private void cmBxSelection_Click(object sender, RoutedEventArgs e)
        {
            string selectedValue = comboBox.SelectedValue.ToString();
            /*
             * if you are sending any values from the code, means you are trying to bind the variable from the 
             * backend, you don't need to split the item/value you are receiving. Because, from the backend
             * you are directly sending/binding the value which actually creates a <item, value> map for the
             * collection of each comboBox/listBox. So, you can directly get the selected value for a comboBox
             * from frontend
             */
            //selectedValue = selectedValue.Split(':')[1];
            MessageBox.Show(selectedValue);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                string selectedValue = comboBox.SelectedValue.ToString();
                //selectedValue = selectedValue.Split(':')[1];
                MessageBox.Show(selectedValue);
            }
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkBoxOne.IsChecked) // IsChecked just try to find out whether the checkbox is checked or not, if
                                             //Not, it returns false, otherwise it returns true
                MessageBox.Show("This is Wrong");
            else if ((bool)checkBoxTwo.IsChecked)
                MessageBox.Show("This is Wrong");
            else if ((bool)checkBoxThird.IsChecked)
                MessageBox.Show("This is Corrent");
            else if ((bool)checkBoxFour.IsChecked)
                MessageBox.Show("This is Wrong");
            else
                MessageBox.Show("Check An Answer");
        }
        /*
         * for checkbox and the radiobutton, it is expected that everytime only one box should be checked
         * to do so, we need to add actionListner with each of the checkBox one by one and need to 
         * make the other checkboxes false
         */
        private void checkBoxOne_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxTwo.IsChecked = false;
            checkBoxThird.IsChecked = false;
            checkBoxFour.IsChecked = false;
        }

        private void checkBoxTwo_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxOne.IsChecked = false;
            checkBoxThird.IsChecked=false;
            checkBoxFour.IsChecked = false;
        }

        private void checkBoxThird_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxOne.IsChecked=false;
            checkBoxTwo.IsChecked=false;
            checkBoxFour.IsChecked=false;
        }

        private void checkBoxFour_Checked(object sender, RoutedEventArgs e)
        {
            checkBoxOne.IsChecked = false;
            checkBoxTwo.IsChecked=false;
            checkBoxThird.IsChecked = false;
        }
    }
}
