using DandDEasy.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Repo
{
    public class CharacterRepo
    {
        private readonly DnDEasyContext _db;

        public CharacterRepo(DnDEasyContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Character> GetCharactertable()
        {
            List<Character> character = _db.Character.ToList();
            return character;
        }

        public IEnumerable<Character> GetCharactertByID(string name, string password) // get all character of user
        {
            var user = _db.User.FirstOrDefault(x => x.FirstName == name && x.Password == password);
            var userid = user.Id;
            var character = _db.Character.Where(x => x.UserId == userid);
            return character;
        }

        public void DeleteCharacterByID(int id) // get all character of user
        {
            var character = _db.Character.Find(id);
            _db.Character.Remove(character);
            _db.SaveChanges();
        }

        public Character2 GetCharactertByID(int id) // get all character of user
        {
            var x = _db.Character.FirstOrDefault(y => y.Id == id);

            if (x == null)
            {
                return null;
            }
            else
            {
                Character2 thecharacter = new Character2
                {
                    UserId = x.UserId,
                    Id = x.Id,
                    Name = x.Name,
                    Alignment = x.Alignment,
                    ArmorClass = x.ArmorClass,
                    Background = x.Background,
                    CampaignId = x.CampaignId,
                    Charisma = x.Charisma,
                    Constitution = x.Constitution,
                    CreationDate = x.CreationDate,
                    Dexterity = x.Dexterity,
                    Experience = x.Experience,
                    HitPoints = x.HitPoints,
                    Intelligence = x.Intelligence,
                    Race = x.Race,
                    Strength = x.Strength,
                    Wisdom = x.Wisdom
                };
                return thecharacter;
            }
        }

    }
}
