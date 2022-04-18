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

namespace WPF02_Task1
{
    /// <summary>
    /// Interaction logic for StartHere.xaml
    /// </summary>
    public partial class StartHere : Window
    {
        public StartHere()
        {
            InitializeComponent();
        }

        private void openWindow(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name.ToString())
            {
                case "task1":
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    break;
                case "task2":
                    Task02 task02 = new Task02();
                    task02.Show();
                    break;
                case "task3":
                    ButtonsToStyle buttonsToStyle = new ButtonsToStyle();
                    buttonsToStyle.Show();
                    break;
                case "task4":
                    LogInScreen logInScreen = new LogInScreen();
                    logInScreen.Show();
                    break;
            }
        }
    }
}
