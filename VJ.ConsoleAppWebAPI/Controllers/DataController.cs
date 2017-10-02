using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace VJ.ConsoleAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private Appsettings Appsettings { get; }

        public DataController(IOptions<Appsettings> settings)
        {
            Appsettings = settings.Value;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(new
            {
                one = "1",
                two = 2,
                three = true,
                four = Appsettings.CoolSetting
            });
        }

        [HttpGet("OtherData")]
        public IActionResult GetOtherData()
        {
            return Ok("Datas");
        }
    }
}
