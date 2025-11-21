using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalAPI.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car? Car { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        // CALCULATED PROPERTY – REQUIRED to FIX YOUR ERROR
        [NotMapped]
        public decimal TotalPrice
        {
            get
            {
                int days = (EndDate - StartDate).Days;
                return Car != null ? days * Car.PricePerDay : 0;
            }
        }
    }
}
