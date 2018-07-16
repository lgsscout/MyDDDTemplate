using $safeprojectname$.Entities;
using $safeprojectname$.Interfaces.Repository;
using $safeprojectname$.Interfaces.Service;
using $safeprojectname$.Services.Common;
using $safeprojectname$.Validation;
using System;

namespace $safeprojectname$.Services
{
    public class ExampleService : Service<Example, IExampleRepository>, IExampleService
    {
        public ExampleService(IExampleRepository repository) : base(repository) { }

        public override ValidationResult Add(Example entity)
        {
            entity.AddedDate = DateTime.Now;
            return base.Add(entity);
        }
    }
}