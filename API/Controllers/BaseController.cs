using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class BaseController : Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
