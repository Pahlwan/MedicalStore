using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Entity
{
    public class Person
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name is Required")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="Name must be between 2 to 20 characters long")]
        public string Name { get; set; }

        [Range(0,150,ErrorMessage ="Age must be between 0 to 150")]
        public int Age { get; set; }

        [Range(typeof(DateTime), "01/01/1901", "01/01/2021", ErrorMessage = "Date of birth should be less then current date")]
        public DateTime BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([+0-9]{2,3})?[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string EmailAddress { get; set; }
        public string Address { get; set; }
    }
}
