using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Themes.Utilities;

namespace Themes.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private int _themeIndex;
        public int ThemeIndex { get => _themeIndex; set { RaisePropertyChanged(ref _themeIndex, value); SetTheme(); } }

        public MainViewModel()
        {

        }

        public void SetTheme()
        {
            if (ThemeIndex == 0)
                MainWindow.SetTheme(MainWindow.Theme.Light);
            else if (ThemeIndex == 1)
                MainWindow.SetTheme(MainWindow.Theme.Dark);
        }
    }
}
