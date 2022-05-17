using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileDownloadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        public readonly string filePath;
        public DownloadController(string filePath)
        {
            this.filePath = filePath;
        }

        // GET: api/<DownloadController>
        [HttpGet]
        public FileContentResult Get()
        {
            // 1st method
            //var data = System.IO.File.ReadAllBytes(filePath);
            //var result = new FileContentResult(data, "application/octet-stream")
            //{
            //    FileDownloadName = "File.csv"
            //};

            //return result;

            // 2nd method
            return File(System.IO.File.ReadAllBytes(filePath), "application/octet-stream", "File.csv");
        }
    }
}
