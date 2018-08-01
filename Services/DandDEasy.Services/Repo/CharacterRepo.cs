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


    }
}
