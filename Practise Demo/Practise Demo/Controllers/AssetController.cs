using DemoDataAccess;
using DemoDataAccess.Entity;
using DemoDataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practise_Demo.Attributes;
using Practise_Demo.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.Controllers
{
    [Authorize]
    public class AssetController : Controller
    {
        private IAsset _assetRepo;
        private ILogger<AssetController> _logger;
        private AppDbContext _dbContext;

        public AssetController(IAsset assetRepo, ILogger<AssetController> logger, AppDbContext dbContext)
        {
            _assetRepo = assetRepo;
            _logger = logger;
            _dbContext = dbContext;
        }
        private Asset MapDTO(AssetEntity data)
        {
            var ret = new Asset
            {
                Id = data.Id,
                Name = data.Name,
                Description = data.Description,
                TagNumber=data.TagNumber
            };
            return ret;
        }
        // GET: AssetController
        //[Route("createformat")]
        //[HttpGet("createformat")]
        public ActionResult Index()
        {
            try
            {
                var assetEntity = _assetRepo.GetAllAssets();
                var assetDTO = assetEntity.Select(x => MapDTO(x));
                return View("ListAssets", assetDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return View("CustomError");
            }
        }

        [HttpPost]
        public ActionResult CreateAsset(Asset postData)
        {
            var assetEntity = new AssetEntity();
            assetEntity.Description = postData.Description;
            assetEntity.Name = postData.Name;
            assetEntity.TagNumber = postData.TagNumber;
            assetEntity.CreatedOn = DateTime.UtcNow;

            _dbContext.Assets.Add(assetEntity);
            _dbContext.SaveChanges();

            ViewData["Entity"] = "Asset";
            return View("Success");
        }
        public ActionResult CheckTagUniquness(string tagNumber, int id = 0)
        {
            var entity = _dbContext.Assets.Find(id);
            if (entity != null && entity.TagNumber == tagNumber)
            {
                return Json(true);
            }
            var tagExist = _dbContext.Assets.Any(x => x.TagNumber == tagNumber);
            if(tagExist)
            {
                return Json($"Tag Number{tagNumber} Exist");
            }
            return Json(true);
        }

        public ActionResult Create()
        {
            return View("CreateAsset");
        }

        public async Task<IActionResult> EditAsset(int id)
        {
            var assetEntity = await _dbContext.Assets.FindAsync(id);
            var assetDTO = MapDTO(assetEntity);
            return View("EditAsset", assetDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsset(Asset data)
        {
            var entity = await _dbContext.Assets.FindAsync(data.Id);
            entity.Name = data.Name;
            entity.Description = data.Description;
            entity.TagNumber = data.TagNumber;
            _dbContext.Assets.Update(entity);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteAsset (int id)
        {
            var assetEntity = await _dbContext.Assets.FindAsync(id);
            _dbContext.Assets.Remove(assetEntity);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }   
    }
}
