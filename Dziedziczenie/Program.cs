
using Dziedziczenie;

class Program
{
    static void Main()
    {

        ExcelFile excelFile = new ExcelFile();

        excelFile.CreatedOn= DateTime.Now;
        excelFile.Size= 10.5;
        excelFile.FileName = "excel-file";

        excelFile.GenerateReport();

        WordDocumentFile wordDocumentFile = new WordDocumentFile();

        wordDocumentFile.CreatedOn= DateTime.Now;
        wordDocumentFile.Size = 4;
        wordDocumentFile.FileName = "word-file";

        wordDocumentFile.Print();

        PowerPointFile powerPointFile = new PowerPointFile();

        powerPointFile.CreatedOn= DateTime.Now;
        powerPointFile.Size = 16.8;
        powerPointFile.FileName = "powerpoint-file";

        powerPointFile.Present();
    }
}