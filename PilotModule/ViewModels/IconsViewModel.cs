using Ascon.Pilot.Theme;
using PilotModule.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PilotModule.ViewModels
{
    internal class IconsViewModel : ObservableObject
    {
        public ICommand GetIconFullNameToClipboardCommand { get; set; }

        public IEnumerable<DictionaryEntry> FilteredIcons { get; set; }

        public IconsViewModel()
        {
            FilteredIcons = Icons.Instance.Cast<DictionaryEntry>()
                                          .Where(p => p.Value.GetType() == typeof(DrawingImage));

            GetIconFullNameToClipboardCommand = new RelayCommand<object>(GetIconFullNameToClipboard);
        }

        private void GetIconFullNameToClipboard(object obj)
        {
            var keyValuePair = (DictionaryEntry)obj;

            var text = "Icons.Instance." + keyValuePair.Key;
            
            Clipboard.SetText(text);
        }
    }
}