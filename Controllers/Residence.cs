namespace AirBB.Models
{
    public class Residence
    {
        public int ResidenceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ResidencePicture { get; set; } = string.Empty;

        // FK + navigation
        public int LocationId { get; set; }
        public Location? Location { get; set; }

        public int GuestNumber { get; set; }
        public int BedroomNumber { get; set; }
        public int BathroomNumber { get; set; }
        public decimal PricePerNight { get; set; }

        // Optional: convenience property
        public string Display => $"{Name} – {Location?.Name}";
    }
}
