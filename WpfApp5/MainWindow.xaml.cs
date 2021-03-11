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

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myMediaElement.Play();
        }

        private void panel_MouseEnter(object sender, MouseEventArgs e)
        {
            panel.Opacity = 0.8;
        }

        private void panel_MouseLeave(object sender, MouseEventArgs e)
        {
            panel.Opacity = 0.2;
        }

        private void myMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            myMediaElement.Position = new TimeSpan(0, 0, 1);
            myMediaElement.Play();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
