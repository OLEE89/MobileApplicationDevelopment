using MobileApplicationDevelopment.Views;




namespace MobileApplicationDevelopment;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainContactPage), typeof(MainContactPage));
        Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));
        Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
    }
}
