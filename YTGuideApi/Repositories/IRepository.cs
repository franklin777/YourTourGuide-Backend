using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTGuideApi.Models;

namespace YTGuideApi.Repositories
{
   public interface IRepository
    {
        Task<IEnumerable<TourPackage>> GetAllPackages();
        Task<TourPackage> GetPackage(string id);
        Task Add(TourPackage Package);
    }
}
