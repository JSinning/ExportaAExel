using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exportInforms.Class
{
    class ExportExcel
    {
        public Boolean ExportArchiveExcel(ListView listView)
        {

            using (SaveFileDialog Sfd = new SaveFileDialog() {Filter = "Excel Workbook|*.xls" , ValidateNames = true } )
            {
                if (Sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = application.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)application.ActiveSheet;
                    application.Visible = false;
                    ws.Cells[1, 1] = "ID";
                    ws.Cells[1, 2] = "Nombre";
                    ws.Cells[1, 3] = "Titulo";
                    ws.Cells[1, 4] = "Descripcion";
                    int i = 2;
                    foreach (ListViewItem item in listView.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(Sfd.FileName,
                              XlFileFormat.xlWorkbookDefault,
                              Type.Missing,
                              true,
                              false,
                              XlSaveConflictResolution.xlLocalSessionChanges,
                              XlSaveAsAccessMode.xlNoChange, 
                              Type.Missing,
                              Type.Missing);
                    application.Quit();
                    return true;
                }
                


            }
            return false;
        }
    }
}
