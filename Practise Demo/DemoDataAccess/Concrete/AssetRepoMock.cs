using DemoDataAccess.Entity;
using DemoDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDataAccess.Concrete
{
    public class AssetRepoMock : IAsset
    {
        public IEnumerable<AssetEntity> GetAllAssets()
        {
            throw new NotImplementedException();
        }
    }
}
