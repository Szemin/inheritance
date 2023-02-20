
using Dziedziczenie;

class Program
{
    static void Main()
    {

        ExcelFile excelFile = new ExcelFile();

        excelFile.CreatedOn= DateTime.Now;
        excelFile.FileName = "excel-file";

        excelFile.GenerateReport();

        WordDocumentFile wordDocumentFile = new WordDocumentFile();

        wordDocumentFile.CreatedOn= DateTime.Now;
        wordDocumentFile.FileName = "word-file";
        wordDocumentFile.Print();

        PowerPointFile powerPointFile = new PowerPointFile();

        powerPointFile.CreatedOn= DateTime.Now;
        powerPointFile.FileName = "powerpoint-file";
        powerPointFile.Present();
    }
}