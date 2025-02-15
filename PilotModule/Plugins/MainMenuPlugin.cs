using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using Ascon.Pilot.Theme.Controls;
using System.Composition;

namespace PilotModule.Plugins
{
    [Export(typeof(IMenu<MainViewContext>))]
    public class MainMenuPlugin : IMenu<MainViewContext>
    {
        private const string SHOW_ICONS = "ShowIcons";

        [ImportingConstructor]
        public MainMenuPlugin()
        {
        }

        public void Build(IMenuBuilder builder, MainViewContext context)
        {
            builder.AddItem(SHOW_ICONS, builder.Count).WithHeader(SHOW_ICONS);
        }

        public void OnMenuItemClick(string name, MainViewContext context)
        {
            if (name == SHOW_ICONS)
            {
                var iconsView = new IconsView();

                var baseWindow = new DialogWindow();
                baseWindow.Content = iconsView;

                baseWindow.ShowDialog();
            }
        }
    }
}