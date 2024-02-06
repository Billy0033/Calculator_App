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
using System.Data;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        // public int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            //textBox.Text = "0";
            // if(i == 1){
            //     textBox.Clear();
            //     i = 0;
            // }
        }
        // private string currentExpression = "";
        public void Button_Click(object sender, RoutedEventArgs e){
            Button button = (Button)sender;
            string buttonText = button.Content.ToString();
            

            if (buttonText == "=")
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    var result = dataTable.Compute(textBox.Text, "");
                    textBox.Text = result.ToString();
                    
                }
                catch (Exception)
                {
                    textBox.Text = "Ошибка";
                }
                
            }
            else
            {
                textBox.Text += buttonText;
            }
        }
        public void Button_Clear(object sender, RoutedEventArgs e){
            textBox.Clear();
        }
    }
}
