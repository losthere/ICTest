using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<string> MyItems { get; set; }
        private CoreApplicationView currentView;
        private Point initialPosition;
        private TranslateTransform transform;
        public MainPage()
        {
            this.InitializeComponent();
            MyItems = new ObservableCollection<string>
            {
                "ms-appx:///Assets/Person2.png",
                "ms-appx:///Assets/Person3.png",
                "ms-appx:///Assets/Person4.png",
                "ms-appx:///Assets/Person5.png",
            };

            DataContext = this;
            currentView = CoreApplication.GetCurrentView();
            currentView.TitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(AppTitleBar);
            Window.Current.Activate();
        }
        private void Open_Bar_P1(object sender, TappedRoutedEventArgs e)
        {
            if (BarP1.Visibility == Visibility.Collapsed)
            {
                BarP1.Visibility = Visibility.Visible;
            }
            else
            {
                BarP1.Visibility = Visibility.Collapsed;
            }
        }


        

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Flyout flyout = new Flyout();
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock1 = new TextBlock() { Text = "Option 1" };
            flyout.Content = stackPanel; FlyoutBase.SetAttachedFlyout(sender as FrameworkElement, flyout);
            FlyoutBase.ShowAttachedFlyout(sender as FrameworkElement);
        }

       /* private void ListViewItem_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            Flyout flyout = new Flyout();

            // Create the content grid
            Grid contentGrid = new Grid();
            contentGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });
            contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });

            // Create the PersonPicture control
            PersonPicture personPicture = new PersonPicture();
            personPicture.ProfilePicture = new BitmapImage(new Uri("ms-appx:///Assets/Person2.png"));
            personPicture.Height = 40;
            personPicture.Width = 40;
            contentGrid.Children.Add(personPicture);

            // Create the Image control
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/IC 49.png"));
            image.Width = 18;
            image.Height = 18;
            Grid.SetColumn(image, 1);
            //  Grid.SetMargin(image, new Thickness(4, 0, 0, 0));
            contentGrid.Children.Add(image);

            // Create the TextBlock control
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Tom Hank";
            textBlock.FontSize = 14;
            textBlock.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(textBlock, 2);
            contentGrid.Children.Add(textBlock);

            // Set the content of the flyout
            flyout.Content = contentGrid;
            flyout.ShowAt(listViewItem);

            // Subscribe to the PointerExited event of the ListViewItem
            *//* listViewItem.PointerExited += (s, args) =>
             {
                 // Hide the flyout when the pointer exits the ListViewItem
                 flyout.Hide();
             };*//*


        }*/


    }
    

    }

