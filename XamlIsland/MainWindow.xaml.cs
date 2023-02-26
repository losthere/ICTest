using System.Windows;
using System.Windows.Input;

namespace XamlIsland
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //myXamlHost.Application = UWP.App.Current;
            myXamlHost.InitialTypeName = "IC.MainPage";


        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }


    }
    }
