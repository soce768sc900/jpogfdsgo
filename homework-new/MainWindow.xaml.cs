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

namespace homework_new
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string A = @"C:\temp\data.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void VVV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ToDoITem ToDoList = new ToDoITem();
            ToDo.Children.Add(ToDoList);
        }

        private void ADDD_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ToDoITem ToDoList = new ToDoITem();
            ToDo.Children.Add(ToDoList);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                int a = 0;

                foreach (ToDoITem item in ToDo.Children)
                {

                    a += item.OH;
                }
                Money.Text = a.ToString();
            }
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            ToDo.Children.Remove((ToDoITem)sender);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> datas = new List<string>();

            foreach (ToDoITem item in ToDo.Children)
            {
                string line = "";
​                line += "|" + item.time.Text + "|" + item.ITEMnameTb.Text + "|" + item.OH.ToString();
                datas.Add(line);

            }

            System.IO.File.WriteAllLines(A, datas);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(A);
​
   
    foreach (string line in lines)
            {

                string[] parts = line.Split('|');

                ToDoITem item = new ToDoITem();
                item.ITEMname = parts[1];
                item.DeleteItem += new EventHandler(DeleteItem);
​
      
        ToDo.Children.Add(item);
            }
        }
        public static void Main()
        {
            string B = @"C:\temp\datt.txt";
            
            }

    }
    }

