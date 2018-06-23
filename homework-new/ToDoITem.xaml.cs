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
    /// ToDoITem.xaml 的互動邏輯
    /// </summary>
    public partial class ToDoITem : UserControl
    {
        public event EventHandler DeleteItem;

        public ToDoITem()
        {
            InitializeComponent();
        }

        public string Time
        {
            get
            {
                return time.Text;

            }
            set
            {
                time.Text = value.ToString();
            }
        }


        public string ITEMname
        {
            get
            {
                return ITEMnameTb.Text;
            }
            set
            {
                ITEMnameTb.Text = value.ToString();
            }
        }
        public int OH
        {
            get
            {
                try
                {
                    return int.Parse(TEXXT.Text);
                }
                catch
                {
                    MessageBox.Show("必須輸入數字!!");
                    return 0;
                }
            }
            set
            {
                TEXXT.Text = value.ToString();
            }
        }
    }
}
