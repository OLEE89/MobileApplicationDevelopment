using Microsoft.Maui.ApplicationModel.Communication;
using MobileApplicationDevelopment.Models;

namespace MobileApplicationDevelopment.Views;




[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Models.Contact contact;
    public EditContactPage()
    {
        InitializeComponent();
    }

    public string ContactId
    {
        set
        {
            contact = ContactRepository.GetContactById(int.Parse(value));
            if (contact != null)
            {
                ContactCtrl.FirstName = contact.FirstName;
                ContactCtrl.LastName = contact.LastName;
                ContactCtrl.Email = contact.Email;
            }
        }
    }

    private void ContactCtrl_OnSave(object sender, EventArgs e)
    {
        contact.FirstName = ContactCtrl.FirstName;
        contact.LastName = ContactCtrl.LastName;
        contact.Email =  ContactCtrl.Email;
        ContactRepository.UpdateContact(contact);
    }
}