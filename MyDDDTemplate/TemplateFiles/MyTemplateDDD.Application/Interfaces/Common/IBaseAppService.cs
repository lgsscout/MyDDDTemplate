using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace $safeprojectname$.Interfaces.Common
{
    public interface IBaseAppService<TEntity>: IWriteOnlyAppService<TEntity>, IReadOnlyAppService<TEntity>, IDisposable
        where TEntity: class
    {

    }
}