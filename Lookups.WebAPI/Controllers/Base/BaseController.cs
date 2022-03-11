using Lookups.Service.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lookups.WebAPI.Controllers.Base
{
    /// <inheritdoc />
    [Route("api/[controller]/[action]")]
    [ApiController]
    ////for jwt token auth
    //[Authorize]

    //for Basic Auth username:admin password:Admin@123  
    [BasicAuth]
    public class BaseController : ControllerBase
    {
       
        /// <inheritdoc />
        public BaseController()
        {
        }
    }
}
