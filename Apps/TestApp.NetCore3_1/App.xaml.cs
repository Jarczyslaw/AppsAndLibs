using System.Windows;

namespace TestApp.NetCore3_1
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
            var c3 = new Library.NetStandard2_1.Class1();
            var c4 = new Library.NetCore3_1.Class1();

            base.OnStartup(e);
        }
    }
}