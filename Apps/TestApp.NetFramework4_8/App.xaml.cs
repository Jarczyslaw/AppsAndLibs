using System.Windows;

namespace TestApp.NetFramework4_8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var c1 = new Library.NetFramework4_8.Class1();
            var c2 = new Library.NetStandard2_0.Class1();

            base.OnStartup(e);
        }
    }
}