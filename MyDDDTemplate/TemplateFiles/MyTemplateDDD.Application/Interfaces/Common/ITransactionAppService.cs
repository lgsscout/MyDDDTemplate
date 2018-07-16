using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Interfaces.Common
{
    public interface ITransactionAppService
    {
        void BeginTransaction();
        void Commit();
    }
}