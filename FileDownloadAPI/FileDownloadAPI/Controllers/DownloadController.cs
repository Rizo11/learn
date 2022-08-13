using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

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
        //[HttpGet]
        //public FileContentResult Get()
        //{
        //    //1st method
        //    //var data = System.IO.File.ReadAllBytes(filePath);
        //    //var result = new FileContentResult(data, "application/octet-stream")
        //    //{
        //    //    FileDownloadName = "File.csv"
        //    //};

        //    //return result;

        //    // 2nd method
        //    return File(System.IO.File.ReadAllBytes(filePath), "application/octet-stream", "File.csv");
        //}

        /// <summary>
        /// returens a .xlsx
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public FileContentResult GetXlsx()
        {
            MemoryStream content = new MemoryStream();
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Employee");
                //First add the headers
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Gender";
                worksheet.Cells[1, 4].Value = "Salary (in $)";

                //Add values
                worksheet.Cells["A2"].Value = 1000;
                worksheet.Cells["B2"].Value = "Jon";
                worksheet.Cells["C2"].Value = "M";
                worksheet.Cells["D2"].Value = 5000;

                worksheet.Cells["A3"].Value = 1001;
                worksheet.Cells["B3"].Value = "Graham";
                worksheet.Cells["C3"].Value = "M";
                worksheet.Cells["D3"].Value = 10000;

                worksheet.Cells["A4"].Value = 1002;
                worksheet.Cells["B4"].Value = "Jenny";
                worksheet.Cells["C4"].Value = "F";
                worksheet.Cells["D4"].Value = 5000;
                byte[] bytesXlsx = package.GetAsByteArray();

                //return new FileStreamResult(content, "application/octet-stream")
                //{
                //    FileDownloadName = "test.xlsx"
                //};

                //return File(bytesXlsx, "application/octet-stream", "File.xlsx");

                var result = new FileContentResult(bytesXlsx, "application/octet-stream")
                {
                    FileDownloadName = "File.xlsx"
                };

                return result;
            }
        }
    }
}
