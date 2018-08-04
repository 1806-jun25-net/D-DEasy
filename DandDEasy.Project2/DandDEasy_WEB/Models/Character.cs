using System;
using System.Collections.Generic;

namespace DandDEasy_WEB.Models
{
    public partial class Character
    {
        public Character()
        {
            CharacterClasses = new HashSet<CharacterClasses>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? CampaignId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int? Experience { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
        public int? HitPoints { get; set; }
        public int? ArmorClass { get; set; }

        public Campaign Campaign { get; set; }
        public User User { get; set; }
        public CampaignGraveyard CampaignGraveyard { get; set; }
        public ICollection<CharacterClasses> CharacterClasses { get; set; }
    }

    public enum Backgrounds
    {
        GuildMerchant,
        GuildArtisan,
        Hermit,
        Entertainer,
        FolkHero,
        Gladiator,
        Charlatan,
        Acolyte,
        Criminal,
        Noble,
        Outlander,
        Knight,
        Sailor,
        Soldier,
        Spy,
        Sage,
        Pirate,
        Urchin
    }

    public enum Races
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        HalfOrc,
        Halfling,
        Human,
        Tiefling
    }

    public enum Alignments
    {
        LawfulGood,
        ChaoticGood,
        NeutralGood,
        LawfulNeutral,
        TrueNeutral,
        ChaoticNeutral,
        NeutralEvil,
        LawfulEvil,
        ChaoticEvil
    }
}
