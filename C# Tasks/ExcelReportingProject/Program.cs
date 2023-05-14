using System.Data.OleDb;
using System.Data;

namespace ExcelReportingProject;

public static class Program
{
    public static void Main(String[] args)
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\example.mdf;Integrated Security=True";

        string filePath = @"C:\Users\Hp\Desktop\C# Tasks\ExcelReportingProject\ExcelReportingProject\Files\example_data.xlsx";

        // Connect
        string ConnectionStringExcel = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";

        OleDbConnection excelConnection = new OleDbConnection(ConnectionStringExcel);
        excelConnection.Open();

        // Read data from Excel
        DataTable dataTable = new DataTable();
        OleDbCommand excelCommand = new OleDbCommand("SELECT * FROM [Sheet1$]", excelConnection);
        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(excelCommand);
        dataAdapter.Fill(dataTable);
    }
}