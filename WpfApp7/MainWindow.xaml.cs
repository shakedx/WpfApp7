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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Stack<string> stack { get; set; }
        public MainWindow()
        {
            stack = new Stack<string>();
            stack.Push("Ш");
            stack.Push("2");
            stack.Push("sdf4");
            stack.Push("bye");
        }
        public string PrintStackoverview()
        {
            string Result = "";
            foreach (var item in stack)
            {
                Console.WriteLine(item);
                Result = Result + item + ", ";
            }
            return Result;
        }
        public string GetMaxString()
        {
            string maxstringitem = "";
            foreach (var item in stack)
            {
                if (item.Length > maxstringitem.Length)
                {
                    maxstringitem = item;
                }
            }
            return maxstringitem;
        }
  

        private void Button_Click(object sender, RoutedEventArgs e) //print
        {
            overview.Text = PrintStackoverview();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //print after pop
        {
            stack.Pop();
            overview.Text = PrintStackoverview();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //find
        {
            maxstring.Text = GetMaxString();
            
        }
        
    }
}
