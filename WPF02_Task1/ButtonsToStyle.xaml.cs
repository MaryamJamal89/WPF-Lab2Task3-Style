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
    /// Interaction logic for ButtonsToStyle.xaml
    /// </summary>
    public partial class ButtonsToStyle : Window
    {
        public ButtonsToStyle()
        {
            InitializeComponent();
        }

        private void changeStyle(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Style1":
                    btnOne.Style = (Style)Resources["firstStyle"];
                    btnTwo.Style = (Style)Resources["firstStyle"];
                    btnThree.Style = (Style)Resources["firstStyle"];
                    Style1.Style = (Style)Resources["firstStyle"];
                    break;
                case "Style2":
                    btnOne.Style = (Style)Resources["secStyle"];
                    btnTwo.Style = (Style)Resources["secStyle"];
                    btnThree.Style = (Style)Resources["secStyle"];
                    Style2.Style = (Style)Resources["secStyle"];
                    break;
                case "Style3":
                    btnOne.Style = (Style)Resources["thirdStyle"];
                    btnTwo.Style = (Style)Resources["thirdStyle"];
                    btnThree.Style = (Style)Resources["thirdStyle"];
                    Style3.Style = (Style)Resources["thirdStyle"];
                    break;
            }
        }
    }
}
