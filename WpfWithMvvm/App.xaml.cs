using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfWithMvvm.Mvvm.ViewModels;

namespace WpfWithMvvm;
public partial class App : Application
{
    private static IHost? builder;

    public App()
    {
        builder = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainWindow> ();
            }).Build();
    }


    protected override void OnStartup(StartupEventArgs e)
    {

        builder!.Start();

        var mainWindow = builder!.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }
}
