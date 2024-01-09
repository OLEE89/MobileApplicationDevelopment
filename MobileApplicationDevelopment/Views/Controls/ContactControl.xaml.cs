using System.Security.Cryptography.X509Certificates;

namespace MobileApplicationDevelopment.Views.Controls
{
    public partial class ContactControl : ContentView
    {
        public event EventHandler<string> OnError;
        public event EventHandler<EventArgs> OnSave;

        public ContactControl()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return Entry_First_Name.Text; }
            set { Entry_First_Name.Text = value; }
        }

        public string LastName
        {
            get { return Entry_Last_Name.Text; }
            set { Entry_Last_Name.Text = value; }
        }

        public string Email
        {
            get { return Entry_Email.Text; }
            set { Entry_Email.Text = value; }
        }

        private void BtnContactSave_Clicked(object sender, EventArgs e)
        {
            // Your save logic here
            // You can raise the OnSave event if needed
            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void BtnGoBack_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(MainContactPage)}");
        }
    }
}