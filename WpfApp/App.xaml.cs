using PilotModule.Plugins;
using System.Windows;

namespace WpfApp
{
    public partial class App : Application
    {
        public new void Run()
        {
            var mainMenuPlugin = new MainMenuPlugin();
            mainMenuPlugin.ShowIconWindow();
        }
    }
}