namespace EFCore.WebAPI.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DtInit { get; set; }
        public DateTime DtFinal { get; set; }
        public List<HeroBattle> HeroesBattles { get; set; }
    }
}
