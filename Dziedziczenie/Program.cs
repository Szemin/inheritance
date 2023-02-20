
using Dziedziczenie;

class Program
{
    static void Main()
    {

        ExcelFile excelFile = new ExcelFile();

        excelFile.CreatedOn= DateTime.Now;
        excelFile.FileName = "excel-file";

        excelFile.GenerateReport();
        
    }
}