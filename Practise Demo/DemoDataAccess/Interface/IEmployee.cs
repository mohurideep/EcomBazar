using DemoDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDataAccess.Interface
{
    public interface IEmployee
    {
        IEnumerable<EmployeeEntity> GetEmployeeEntities();

        //IEnumerable<AssetEntity> GetAllAssets();
    }
}
