using DandDEasy.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Repo
{
    public class CampaignRepo
    {
        private readonly DnDEasyContext _db;

        public CampaignRepo(DnDEasyContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Campaign> GetCampaignTable()
        {
            var campaign = _db.Campaign.ToList();
            return campaign;
        }

        public void DeleteCampaign(int id)
        {
            var campaign = _db.Campaign.Find(id);
            _db.Campaign.Remove(campaign);
            _db.SaveChanges();

        }
    }
}
