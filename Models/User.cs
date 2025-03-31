namespace Librabry_ting_ting.Models 
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Gemmer adgangskoden i klar tekst

        // Konstruktør
        public User()
        {
            Name = string.Empty; // Initialiserer Name
            Email = string.Empty; // Initialiserer Email
            Password = string.Empty; // Initialiserer Password
        }
    }
}