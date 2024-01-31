using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfWithMvvm.Mvvm.Models;

namespace WpfWithMvvm.Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private Customer _customerForm = new();

    [ObservableProperty]
    private ObservableCollection<Customer> _customerList = [];

    [RelayCommand]
    public void AddCustomerToList()
    {
        if(!string.IsNullOrWhiteSpace(CustomerForm.CompanyName) && !string.IsNullOrWhiteSpace(CustomerForm.ContactPerson))
        {
            CustomerList.Add(CustomerForm);
            CustomerList = new();
        }

    }
}
