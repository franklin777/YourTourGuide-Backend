using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using YTGuideApi.Models;
using YTGuideApi.Repositories;

namespace YTGuideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourPackageController: ControllerBase
    {

        private readonly IRepository _repository;
        public TourPackageController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            var packages = await _repository.GetAllPackages();
            return JsonConvert.SerializeObject(packages);
        }

        [HttpGet ("{id}")]
        public async Task<string> GetPackage(string id)
        {
            var package = await _repository.GetPackage(id);
            return JsonConvert.SerializeObject(package);
        }


        [HttpPost]
        public string Post([FromBody] TourPackage package)
        {
             _repository.Add(package);
            return "";
        }
    }
}
