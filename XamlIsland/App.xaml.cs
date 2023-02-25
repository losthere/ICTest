
using System.Windows;

namespace XamlIsland
{
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
           // var app = new XamlIsland.App();
            this.InitializeComponent();
           // app.Run();
        }

    }
}
