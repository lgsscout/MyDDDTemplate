using $safeprojectname$.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Entities.Specifications.ExampleSpecs
{
    class ExampleDescriptionIsRequiredSpec : ISpecification<Example>
    {
        public bool IsSatisfiedBy(Example entity)
        {
            return !string.IsNullOrEmpty(entity.Description);
        }
    }
}
