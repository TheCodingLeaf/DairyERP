using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DairyERP.ViewModels;
using DairyERP.Views;

namespace DairyERP
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataTemplates =
                    {
                        new ViewLocator()
                    }
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}