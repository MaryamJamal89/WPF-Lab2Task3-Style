using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF02_Task1
{
    /// <summary>
    /// Interaction logic for LogInScreen.xaml
    /// </summary>
    public partial class LogInScreen : Window
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void changeStyle(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btnOne":
                    btnOne.Style = (Style)Resources["MyButtonImgStyle1"];
                    btnTwo.Style = (Style)Resources["MyButtonImgStyle1"];
                    btnThree.Style = (Style)Resources["MyButtonImgStyle1"];
                    btnFour.Style = (Style)Resources["MyButtonImgStyle1"];
                    Login.Style = (Style)Resources["MyButtonLoginStyle1"];
                    forget.Style = (Style)Resources["MyButtonForgetStyle1"];
                    NewUser.Style = (Style)Resources["MyButtonForgetStyle1"];                    
                    Background = new SolidColorBrush(Colors.Beige);
                    break;
                case "btnTwo":
                    btnOne.Style = (Style)Resources["MyButtonImgStyle2"];
                    btnTwo.Style = (Style)Resources["MyButtonImgStyle2"];
                    btnThree.Style = (Style)Resources["MyButtonImgStyle2"];
                    btnFour.Style = (Style)Resources["MyButtonImgStyle2"];
                    Login.Style = (Style)Resources["MyButtonLoginStyle2"];
                    forget.Style = (Style)Resources["MyButtonForgetStyle2"];
                    NewUser.Style = (Style)Resources["MyButtonForgetStyle2"];
                    Background = new SolidColorBrush(Colors.LightYellow);
                    break;
                case "btnThree":
                    btnOne.Style = (Style)Resources["MyButtonImgStyle3"];
                    btnTwo.Style = (Style)Resources["MyButtonImgStyle3"];
                    btnThree.Style = (Style)Resources["MyButtonImgStyle3"];
                    btnFour.Style = (Style)Resources["MyButtonImgStyle3"];
                    Login.Style = (Style)Resources["MyButtonLoginStyle3"];
                    forget.Style = (Style)Resources["MyButtonForgetStyle3"];
                    NewUser.Style = (Style)Resources["MyButtonForgetStyle3"];
                    Background = new SolidColorBrush(Colors.LightSteelBlue);
                    break;
                case "btnFour":
                    btnOne.Style = (Style)Resources["MyButtonImgStyle4"];
                    btnTwo.Style = (Style)Resources["MyButtonImgStyle4"];
                    btnThree.Style = (Style)Resources["MyButtonImgStyle4"];
                    btnFour.Style = (Style)Resources["MyButtonImgStyle4"];
                    Login.Style = (Style)Resources["MyButtonLoginStyle4"];
                    forget.Style = (Style)Resources["MyButtonForgetStyle4"];
                    NewUser.Style = (Style)Resources["MyButtonForgetStyle4"];
                    Background = new SolidColorBrush(Colors.LightSlateGray);
                    break;
            }
        }
    }
}
