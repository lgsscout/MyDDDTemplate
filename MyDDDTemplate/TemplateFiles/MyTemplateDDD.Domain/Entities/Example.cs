using $safeprojectname$.Entities.Common;
using $safeprojectname$.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.Entities
{
    public class Example : EntitySelfValidated<ExampleValidation, Example>
    {
        public string Description{ get; set; }
        public bool Active { get; set; }
        public DateTime AddedDate { get; set; }
    }
}