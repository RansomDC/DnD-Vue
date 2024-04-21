using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DnD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharachterSheetController : ControllerBase
    {
        [HttpGet]
        [Route("stuff-it")]
        public Object Get()
        {
            return new Dictionary<string, string>() { { "string", "gotten data" } };
        }
    }
}
