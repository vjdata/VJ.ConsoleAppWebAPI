using Microsoft.AspNetCore.Mvc;

namespace VJ.ConsoleAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new
            {
                one = "1",
                two = 2,
                three = true
            });
        }

        [HttpGet("OtherData")]
        public IActionResult GetOtherData()
        {
            return Ok("Datas");
        }
    }
}
