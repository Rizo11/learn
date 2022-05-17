using OfficeOpenXml;

namespace excel;

public class Program
{
    public static void Main(string[] args)
    {
         var excelPackage = new ExcelPackage();
          var excelWorkbook = excelPackage.Workbook;
            var workSheet = excelWorkbook.Worksheets.Add("PersonalSalarySettings");

            workSheet.OutLineSummaryBelow = false;

            workSheet.Cells.Style.Font.Name = "Calibri";
            workSheet.Cells.Style.Font.Size = 11;

            workSheet.Cells[1, 1].Value = "Personal Number";
            workSheet.Cells[1, 2].Value = "Name";
            workSheet.Cells[1, 3].Value = "USD IBAN";
            workSheet.Cells[1, 4].Value = "Percent";
    }
}