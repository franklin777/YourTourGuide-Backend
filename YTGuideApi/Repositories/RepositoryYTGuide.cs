using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTGuideApi.DbModels;
using YTGuideApi.Models;

namespace YTGuideApi.Repositories
{
    public class RepositoryYTGuide : IRepository
    {
        private readonly ObjectContext _context = null;

        public RepositoryYTGuide(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

        public async Task Add(TourPackage package)
        {
            await _context.TourPackage.InsertOneAsync(package);
        }

        public async Task<IEnumerable<TourPackage>> GetAllPackages()
        {
            return await _context.TourPackage.Find(x => true).ToListAsync();
        }

        public async Task<TourPackage> GetPackage(string id)
        {
            var package = Builders<TourPackage>.Filter.Eq("id", id);
            return await _context.TourPackage.Find(package).FirstOrDefaultAsync();
        }
    }
}
