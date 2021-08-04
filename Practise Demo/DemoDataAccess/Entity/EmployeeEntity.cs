using System.ComponentModel.DataAnnotations.Schema;

namespace DemoDataAccess.Entity
{
    public class EmployeeEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
