using $safeprojectname$.Interfaces.Validation;
using $safeprojectname$.Validation;
using System;

namespace $safeprojectname$.Entities.Common
{
    public class EntitySelfValidated<TValidation, TEntity> : Entity, ISelfValidation
        where TValidation : Validation<TEntity>, new()
        where TEntity : Entity
    {
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid
        {
            get
            {
                var selfValidation = new TValidation();
                ValidationResult = selfValidation.Valid(this as TEntity);
                return ValidationResult.IsValid;
            }
        }
    }
}