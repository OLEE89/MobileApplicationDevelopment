using MobileApplicationDevelopment.Models;

namespace MobileApplicationDevelopment.Views;

public partial class AddContactPage : ContentPage
{
    public AddContactPage()
    {
        InitializeComponent();
    }

    private void ControlCtrl_OnSave(object sender, EventArgs e)
    {
        var newContact = new Models.Contact()
        {
            FirstName = ContactCtrl.FirstName,
            LastName = ContactCtrl.LastName,
            Email = ContactCtrl.Email
        };

        ContactRepository.AddContact(newContact);
    }
}
