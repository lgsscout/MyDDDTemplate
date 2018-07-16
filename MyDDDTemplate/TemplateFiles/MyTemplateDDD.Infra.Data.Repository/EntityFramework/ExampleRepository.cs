using $safeprojectname$.EntityFramework.Common;
using $ext_safeprojectname$.Domain.Entities;
using $ext_safeprojectname$.Domain.Interfaces.Repository;
using $ext_safeprojectname$.Infra.Data.Context;

namespace $safeprojectname$.EntityFramework
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(MyContext context) : base(context)
        {
           
        }
    }
}
