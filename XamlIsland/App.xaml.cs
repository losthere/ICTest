using IC;

namespace XamlIsland
{
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            base.OnStartup(e);
            var app = new XamlIsland.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
