using DemoDataAccess;
using DemoDataAccess.Entity;
using DemoDataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Practise_Demo.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practise_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private IHttpClientFactory _httpClientFactory;
        private IEmployee _employeeRepo;
        private AppDbContext _dbContext;

        public EmployeeController(IEmployee employeeRepo,AppDbContext dbContext, IHttpClientFactory httpClientFactory)
        {
            _employeeRepo = employeeRepo;
            _dbContext = dbContext;
            _httpClientFactory = httpClientFactory;
        }

        private Employee MapDTO(EmployeeEntity data)
        {
            var ret = new Employee
            {
                Emp_id = data.Id,
                Emp_name = data.Name,
                Pincode = data.Pincode,
            };
            return ret;
        }
        public ActionResult Index()
        {
            try
            {
                var employeeEntity = _employeeRepo.GetEmployeeEntities();
                var assetDTO = employeeEntity.Select(x => MapDTO(x));
                return View("ListEmployee", assetDTO);
            }
            catch (Exception ex)
            {
                return View("CustomError");
            }
        }

        [HttpPost]
        public ActionResult CreateEmployee(Employee postData)
        {
            var employeeEntity = new EmployeeEntity();
            employeeEntity.Name = postData.Emp_name;
            employeeEntity.Pincode = postData.Pincode;

            _dbContext.Employee.Add(employeeEntity);
            _dbContext.SaveChanges();

            ViewData["Entity"] = "Employee";
            return View("Success");
        }

        public ActionResult Create()
        {
            return View("CreateEmployee");
        }

        public ActionResult CheckNameUnique(string Emp_name)
        {
            var nameExist = _dbContext.Employee.Any(x => x.Name == Emp_name);
            if (nameExist == false)
            {
                return Json(true);
            }
            else
            {
                return Json($"Name {Emp_name} already exist.");
            }
        }

        public async Task<ActionResult> PinCodeValid(string pincode)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://api.postalpincode.in/pincode/{pincode}");
            var result = await response.Content.ReadAsStringAsync();
            var processReult = result.Trim('[', ']');
            var actualResult = JsonConvert.DeserializeObject<PincodeRes>(processReult);
            if (actualResult.Status == "Success")
            {
                return Json(true);
            }
            else
            {
                return Json($"Pincode {pincode} is not valid");
            }

        }
    }
}
