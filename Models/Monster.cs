using System.ComponentModel.DataAnnotations;

namespace MyLittleRPG.Models
{
    public class Monster
    {
        [Key]
        public int idMonster { get; set; }
        public int pokemonId { get; set; }
        public string nom { get; set; }
        public int pointsVieBase { get; set; }
        public int forceBase { get; set; }
        public int defenseBase { get; set; }
        public int experienceBase { get; set; }
        public string spriteURL { get; set; }
        public string type1 { get; set; }
        public string type2 { get; set; }

        public Monster() { }

    }
}
