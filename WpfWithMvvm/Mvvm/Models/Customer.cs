namespace WpfWithMvvm.Mvvm.Models;

public class Customer
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string CompanyName { get; set; } = null!;
    public string ContactPerson {  get; set; } = null!;
}
