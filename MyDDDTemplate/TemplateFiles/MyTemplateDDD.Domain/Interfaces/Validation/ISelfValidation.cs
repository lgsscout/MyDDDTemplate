using $safeprojectname$.Validation;

namespace $safeprojectname$.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}