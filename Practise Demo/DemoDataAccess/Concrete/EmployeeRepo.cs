using DemoDataAccess.Entity;
using DemoDataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDataAccess.Concrete
{
    public class EmployeeRepo : IEmployee
    {
        private AppDbContext _dbContext;

        public EmployeeRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<EmployeeEntity> GetEmployeeEntities()
        {
            return _dbContext.Employee.ToList();
        }
    }
}
