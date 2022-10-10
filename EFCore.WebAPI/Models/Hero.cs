namespace EFCore.WebAPI.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecretId Identity { get; set; }
        public List<Gun> Guns { get; set; }
        public List<HeroBattle> HeroesBattles { get; set; }
    }
}
