using MobileApplicationDevelopment.Views;

namespace MobileApplicationDevelopment.Models
{
    public class ContactRepository
    {
        public static List<Contact> contactList = new List<Contact>()
        {
            new Contact() {Id = 1, FirstName="Andreea", LastName="Ivanciu", Email="andreeaivanciu@yahoo.com"},
            new Contact() {Id = 2, FirstName="George", LastName="Hancianu", Email="georgehancianu@yahoo.com"},
            new Contact() {Id = 3, FirstName="Cristi", LastName="Ursu", Email="cristiursu@yahoo.com"}
        };

        //Crud => Create,Read,Update,Detele
        //Create
        public static void AddContact(Contact contact)
        {
            if(contact != null)
            {
                var checkEmail = contactList.FirstOrDefault(x=> x.Email.Equals(contact.Email));
                if (checkEmail != null)
                {
                    Shell.Current.DisplayAlert("Error", "User already added", "Ok"); 
                    return;
                }
                int maxId = contactList.Max(x => x.Id);
                contact.Id = maxId + 1;
                contactList.Add(contact);
                Shell.Current.DisplayAlert("Succes", "User Added Done", "Ok");
                // absolute path
                Shell.Current.GoToAsync($"//{nameof(MainContactPage)}");
            }
        }

        // Read 1 (All)
        public static List<Contact> GetAllContacts() => contactList;

        // Read 2 (individual)

        public static Contact GetContactById(int id)
        {
            var result = contactList.FirstOrDefault(x => x.Id == id);
            return result;
        }

        //Update

        public static void UpdateContact(Contact contact)
        {
            var result = contactList.FirstOrDefault(x => x.Id == contact.Id);
            if (result != null)
            {
                result.FirstName = contact.FirstName;
                result.LastName = contact.LastName;
                result.Email = contact.Email;
                Shell.Current.DisplayAlert("Succes", "User Update Done", "Ok");
                Shell.Current.GoToAsync("..");

            }
        }
        //Delete
        public static void DeleteContact(int id)
        {
            var result = contactList.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                contactList.Remove(result);
                Shell.Current.DisplayAlert("Succes", "User Deleted Done", "Ok");

            }
        }

        //Search

        public static List<Contact> Searchcontacts(string filter)
        {
            var contacts = contactList.Where(x => !string.IsNullOrWhiteSpace(x.FirstName) && x.FirstName.ToLower().Contains(filter.ToLower())).ToList();
            if(contacts == null || contacts.Count <= 0)
                contacts = contactList.Where(x => !string.IsNullOrWhiteSpace(x.LastName) && x.LastName.ToLower().Contains(filter.ToLower())).ToList();
            else return contacts;
            if(contacts == null || contacts.Count <= 0)
                contacts = contactList.Where(x => !string.IsNullOrWhiteSpace(x.Email) && x.LastName.ToLower().Contains(filter.ToLower())).ToList(); 
            else return contacts;
            return contacts;
        }
    }
}
