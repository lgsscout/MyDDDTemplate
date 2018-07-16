using $safeprojectname$.Entities.Specifications.ExampleSpecs;
using $safeprojectname$.Validation;

namespace $safeprojectname$.Entities.Validations
{
    public class ExampleValidation : Validation<Example>
    {
        public ExampleValidation()
        {
            base.AddRule(new ValidationRule<Example>(new ExampleDescriptionIsRequiredSpec(), ValidationMessages.DescriptionIsRequired));
        }
    }
}