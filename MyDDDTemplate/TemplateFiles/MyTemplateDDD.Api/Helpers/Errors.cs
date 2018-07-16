using $ext_safeprojectname$.Domain.Validation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace $safeprojectname$.Helpers
{
    public static class Errors
    {
        public static ModelStateDictionary AddErrosToModelState(IdentityResult identityResult,
            ModelStateDictionary modelState)
        {
            foreach (var e in identityResult.Errors) {

                modelState.TryAddModelError("validationError", e.Description);
            }

            return modelState;
        }

        public static ModelStateDictionary AddErrosToModelState(ValidationResult validationResult, ModelStateDictionary modelState)
        {
            foreach (var error in validationResult.Errors)
                modelState.AddModelError("validationError", error.Message);

            return modelState;
        }
    }
}
