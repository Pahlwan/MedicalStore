using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Entity
{
    public class Employee:Person
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Employee id can't be empty")]
        public int ID { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Department Name is required")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="Department name between 2 to 20 character")]
        public string DepartmentName { get; set; }
        public string UanNumber { get; set; }
    }
}
