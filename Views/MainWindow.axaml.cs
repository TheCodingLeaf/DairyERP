using Avalonia.Controls;
using DairyERP.ViewModels;

namespace DairyERP.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}