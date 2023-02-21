using MahApps.Metro.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace AleaIactaEst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            DataContext = App.AppHost?.Services.GetRequiredService<MainViewModel>();
            InitializeComponent();
        }
    }
}
