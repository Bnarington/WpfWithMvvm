using System.Windows;
using WpfWithMvvm.Mvvm.ViewModels;

namespace WpfWithMvvm;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}