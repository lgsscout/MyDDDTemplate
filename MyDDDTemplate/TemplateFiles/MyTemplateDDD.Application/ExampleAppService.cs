using $safeprojectname$.Interfaces;
using System;
using System.Collections.Generic;
using $ext_safeprojectname$.Domain.Entities;
using $ext_safeprojectname$.Domain.Validation;
using System.Linq.Expressions;
using $ext_safeprojectname$.Infra.Data.Context.Interfaces;
using $ext_safeprojectname$.Domain.Interfaces.Service;

namespace $safeprojectname$
{
    public class ExampleAppService : BaseAppService<Example, IExampleService>, IExampleAppService
    {
        public ExampleAppService(IUnitOfWork uow,
            IExampleService service) : base(uow, service)
        {
        }
    }
}