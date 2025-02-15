using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using System.ComponentModel.Composition;
using System.Windows;

namespace PilotModule.Plugins
{
    [Export(typeof(IMenu<ObjectsViewContext>))]
    public class Class1 : IMenu<ObjectsViewContext>
    {
        [ImportingConstructor]
        public Class1() 
        {
            MessageBox.Show("Class1 call");
        }

        public void Build(IMenuBuilder builder, ObjectsViewContext context)
        {
        }

        public void OnMenuItemClick(string name, ObjectsViewContext context)
        {
        }
    }
}
