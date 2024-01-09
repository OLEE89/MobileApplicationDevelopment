
namespace MobileApplicationDevelopment.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Combine first name and last name in a single property
        public string FullName => $"{FirstName} {LastName}";

    }
}
