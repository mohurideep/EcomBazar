using DemoDataAccess.Entity;
using DemoDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoDataAccess.Concrete
{
    public class AssetRepo : IAsset
    {
        private AppDbContext _dbContext;

        public AssetRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<AssetEntity> GetAllAssets()
        {
           return _dbContext.Assets.ToList();
        }
    }
}
