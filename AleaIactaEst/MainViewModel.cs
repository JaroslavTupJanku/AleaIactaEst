using AleaIactaEst.Core.Enums;
using AleaIactaEst.Models;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Windows.Media;

namespace AleaIactaEst
{
    internal class MainViewModel
    {
        #region Fields
        #endregion

        #region Property
        public ICommand ChangeWindowThemeColorCMD { get; }
        public ICommand ChangedBaseThemeColorCMD { get; }
        #endregion

        #region Constructors
        public MainViewModel(AppThemeManager themeManager)
        {
            ChangeWindowThemeColorCMD = new RelayCommand<Color>(x => themeManager.ChangedThemeColorScheme(x));
            ChangedBaseThemeColorCMD = new RelayCommand<BaseTheme>(x => themeManager.ChangeThemeBaseColor(x));
        }
        #endregion

        #region Methods
        #endregion

        #region Event
        #endregion
    }
}
