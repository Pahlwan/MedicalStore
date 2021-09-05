using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Services.Common
{
    public class ModelValidation<TModel>
    {
        public void ValidateDataAnotation(TModel model)
        {
            ICollection<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(model, null, null);
            StringBuilder results = new StringBuilder();

            if (!Validator.TryValidateObject(model, validationContext, validationResults, validateAllProperties: true))
            {
                foreach(ValidationResult errors in validationResults)
                {
                    results.Append("*"+ errors.ErrorMessage).AppendLine();
                }
            }
            if(validationResults.Count>0)
            {
                throw new ArgumentException("Fix these Fields.\n\t"+results.ToString());
            }
        }
    }
}
