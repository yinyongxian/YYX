using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace YYX.CSharp.Office
{
    /// <summary>
    /// Excel操作
    /// 尹永贤
    /// yinyongxian@qq.com
    /// 2016-1-22 13:23:07
    /// </summary>
    public class ExcelInterop
    {
        public static void Compare(string fileNameOne, string fileNameAnother)
        {
            Excel.Application ExcelApplication = new Excel.Application();
            try
            {
                //一个Excel
                Workbook workbookOne = ExcelApplication.Workbooks.Open(fileNameOne,
                            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                Worksheet worksheetOne = workbookOne.Worksheets[1];
                //另一个Excel
                Workbook workbookAnother = ExcelApplication.Workbooks.Open(fileNameAnother,
                            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                            Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                Worksheet worksheetAnother = workbookAnother.Worksheets[1];

                Worksheet worksheetNew = ExcelApplication.Workbooks.Add().Worksheets[1];

                #region 比较另个Excel内容，不一样的字体为红色、粗体
                for (int r = 1; r <= worksheetOne.UsedRange.Rows.Count; r++)
                {
                    for (int c = 1; c <= worksheetOne.UsedRange.Columns.Count; c++)
                    {
                        worksheetNew.Cells[r, c] = worksheetOne.UsedRange.Cells[r, c];
                        if (!((Excel.Range)worksheetOne.Cells[r, c]).Text.Equals(((Excel.Range)worksheetAnother.Cells[r, c]).Text))
                        {
                            Range range = worksheetOne.UsedRange.Cells[r, c];
                            range.Font.Color = Color.Red;
                            range.Font.Bold = true;
                        }
                    } 
                }
                #endregion 比较另个Excel内容，不一样的字体为红色、粗体

                #region 保存比较结果
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (DialogResult.OK == fbd.ShowDialog())
                {
                    string saveFileName = Path.Combine(fbd.SelectedPath, DateTime.Now.ToString("yyyyMMddHHmmss") + @".xls");
                    ExcelApplication.DisplayAlerts = false;
                    ExcelApplication.AlertBeforeOverwriting = false;
                    workbookOne.SaveAs(saveFileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                }
                #endregion 保存比较结果
            }
            finally
            {
                ExcelApplication.Quit();
                ExcelApplication = null;
            }
        }
    }
}
