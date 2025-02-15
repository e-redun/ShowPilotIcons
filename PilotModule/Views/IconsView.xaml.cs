using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PilotModule.Views
{
    public partial class IconsView
    {
        public ICommand GetIconFullNameToClipboardCommand { get; set; }

        public IconsView()
        {
            InitializeComponent();
        }

        private void GetIconFullNameToClipboard_Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button == null)
            {
                return;
            }

            var d = (DictionaryEntry)button.DataContext;

            var text = "Icons.Instance." + d.Key;

            Clipboard.SetText(text);
        }
    }
}