namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Gym { get; set; }
        public Country Country { get; set; }
    }
}
