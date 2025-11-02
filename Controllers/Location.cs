namespace AirBB.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<Residence>? Residences { get; set; }
    }
}
