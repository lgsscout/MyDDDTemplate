using Microsoft.AspNetCore.Mvc;

namespace $safeprojectname$.Controllers.Common
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController:Controller
    {
        internal string GetUserName
        {
            get
            {
                return User.Identity.Name;
            }
        }
        internal string GetIdentificacaoId {
            get {
                return User.FindFirst("identificacaoId").Value;
            }
          }
    }
}
