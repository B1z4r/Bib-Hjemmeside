namespace Librabry_ting_ting.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; } // "Available", "Reserved", "Loaned"

        // Konstruktør
        public Book()
        {
            Title = string.Empty; // Initialiserer Title
            Author = string.Empty; // Initialiserer Author
            Genre = string.Empty; // Initialiserer Genre
            Status = "Available"; // Initialiserer Status til en standardværdi
        }
    }
}