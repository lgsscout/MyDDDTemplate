using $ext_safeprojectname$.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Interfaces.Common
{
    public interface IWriteOnlyAppService<in TEntity>
        where TEntity: class
    {
        ValidationResult Create(TEntity entity);
        ValidationResult Update(TEntity entity);
        ValidationResult Remove(TEntity entity);
    }
}