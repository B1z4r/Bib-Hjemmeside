namespace Librabry_ting_ting.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; } // "Active", "Cancelled"

        // Konstruktør
        public Reservation()
        {
            ReservationDate = DateTime.Now; // Initialiserer ReservationDate til nuværende tidspunkt
            Status = "Active"; // Initialiserer Status til en standardværdi
        }
    }
}