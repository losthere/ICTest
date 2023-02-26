using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Toolkit.Wpf.UI.XamlHost;


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
        private bool isDragging = false;
        private Point startPoint;

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            startPoint = e.GetPosition(null);
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.LeftButton == MouseButtonState.Pressed)
            {
                Point currentPoint = e.GetPosition(null);
                var mainWindow = Window.GetWindow(this);
                mainWindow.Left += currentPoint.X - startPoint.X;
                mainWindow.Top += currentPoint.Y - startPoint.Y;
            }
        }

    }
}
