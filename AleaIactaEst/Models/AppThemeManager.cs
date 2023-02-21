using AleaIactaEst.Core.Enums;
using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AleaIactaEst.Models
{
    public class AppThemeManager
    {
        #region Property
        public List<KeyValuePair<string, Color>> Colors { get; private set; }
        #endregion

        #region Constructors
        public AppThemeManager()
        {
            Colors = typeof(Colors).GetProperties()
                     .Where(prop => typeof(Color).IsAssignableFrom(prop.PropertyType))
                     .Select(prop => new KeyValuePair<string, Color>(prop.Name, (Color)prop.GetValue(null)!))
                     .ToList();

            var appTheme = ThemeManager.Current.DetectTheme(Application.Current);
            ThemeManager.Current.ChangeTheme(Application.Current, appTheme!);
        }
        #endregion

        #region Methods
        public void ChangedThemeColorScheme(Color color)
            => ThemeManager.Current.ChangeThemeColorScheme(Application.Current, color.ToString());

        public void ChangeThemeBaseColor(BaseTheme baseTheme)
            => ThemeManager.Current.ChangeThemeBaseColor(Application.Current, baseTheme.ToString());
        #endregion
    }
}
