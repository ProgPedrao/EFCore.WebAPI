namespace EFCore.WebAPI.Models
{
    public class SecretId
    {
        public int id { get; set; }
        public string RealName { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
