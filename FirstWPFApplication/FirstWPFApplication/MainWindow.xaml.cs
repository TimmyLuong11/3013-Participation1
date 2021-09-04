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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //One way
            //lblOutput.Content = String.Empty;

            lblOutput.Visibility = Visibility.Hidden;
        }
        
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Why you click me!");
            string name = txtName.Text;
            string dobValue = txtDOB.Text;
            DateTime dob = Convert.ToDateTime(dobValue);
            TimeSpan age = DateTime.Now - dob;
            int years = age.Days / 365;
            lblOutput.Content = $"Hey {name}, you are {years.ToString("G0")} years old!";
            lblOutput.Visibility = Visibility.Visible;
            
        }
        
    }
}
