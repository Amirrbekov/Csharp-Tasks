using System.Data.OleDb;
using System.Data;

namespace ExcelReportingProject;

public static class Program
{
    public static void Main(String[] args)
    {
        string filePath = @"C:\Users\Hp\Desktop\C# Tasks\ExcelReportingProject\ExcelReportingProject\Files\example_data.xlsx";
        string con = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= {filePath}; Extended Properties=\"Excel 12.0;HDR=YES;\"";

        using (OleDbConnection conn = new OleDbConnection(con))
        {
            conn.Open();
            OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter
            ("select * from [Sheet1$]", conn);
            DataSet excelDataSet = new DataSet();
            objDA.Fill(excelDataSet);
        }
    }
}