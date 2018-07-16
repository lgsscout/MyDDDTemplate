using $safeprojectname$.Validation;

namespace $safeprojectname$.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}