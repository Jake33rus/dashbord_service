using DashboardHelper.Models.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardHelper.Models.Data
{
    public class InfoRepository : IInfoRepository
    {
        private readonly DashboardContext _context = null;

        public InfoRepository(IOptions<Settings> settings)
        {
            _context = new DashboardContext(settings);
        }
        public async Task AddInfo(FullInfo item)
        {
            await _context.Informations.InsertOneAsync(item);
        }

        public async Task<IEnumerable<FullInfo>> GetAllInfo()
        {
            return await _context.Informations.Find(_ => true).ToListAsync();
        }

        public async Task<FullInfo> GetInfo(string id)
        {
            var filter = Builders<FullInfo>.Filter.Eq("Id", id);
            return await _context.Informations.Find(filter).FirstOrDefaultAsync();
        }
    }
}
