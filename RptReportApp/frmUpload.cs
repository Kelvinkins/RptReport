using RptReportApp.DataTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RptReportApp
{


    public partial class frmUpload : Form
    {

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string sFileName;
        int iRow, iCol = 2;


        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Excel File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialog1.FileName;
                lblFile.Text = sFileName;
            }
        }

    
        // GET DATA FROM EXCEL AND POPULATE COMB0 BOX.
        private int readExcel(string sFile)
        {
            int result = 0;
            List<DataModel> dataModels = new List<DataModel>();
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);           // WORKBOOK TO OPEN THE EXCEL FILE.
            xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];      // NAME OF THE SHEET.

            for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
            {
                DataModel data = new DataModel();
                if (xlWorkSheet.Cells[iRow, 1].value != null)
                {
                    data.EnrolleeNumber = xlWorkSheet.Cells[iRow, 1].value;
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 2].value != null)
                {
                    data.Company = xlWorkSheet.Cells[iRow, 2].value;
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 3].value != null)
                {
                    data.Hospital = xlWorkSheet.Cells[iRow, 3].value;
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 4].value != null)
                {
                    data.LastName = xlWorkSheet.Cells[iRow, 4].value;
                }
                else
                {
                    break;
                }

                if (xlWorkSheet.Cells[iRow, 5].value != null)
                {
                    data.OtherName = xlWorkSheet.Cells[iRow, 5].value;
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 6].value != null)
                {
                    data.Plan = xlWorkSheet.Cells[iRow, 6].value;
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 7].value != null)
                {
                    data.FeeForService = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 7].value);
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 8].value != null)
                {
                    data.Capitation = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 8].value);
                }
                else
                {
                    break;
                }
                if (xlWorkSheet.Cells[iRow, 10].value != null)
                {
                    data.PremiumPerIndividual = Convert.ToDecimal(xlWorkSheet.Cells[iRow, 9].value);
                }
                else
                {
                    break;
                }

                if (xlWorkSheet.Cells[iRow, 10].value != null)
                {
                    data.CommissionPerIndividualPercentage = Convert.ToInt32(xlWorkSheet.Cells[iRow, 10].value);
                }
                else
                {
                    break;
                }
                data.Date = dteDate.Value;
                dataModels.Add(data);
            }

            xlWorkBook.Close();
            xlApp.Quit();

            DatasTableAdapter adapter = new DatasTableAdapter();
            foreach (var d in dataModels)
            {
               var r = adapter.Insert(d.EnrolleeNumber,d.Company,d.Hospital,d.LastName,d.OtherName,d.Plan,d.FeeForService,d.Capitation,d.PremiumPerIndividual,d.CommissionPerIndividualPercentage,d.Date);
                if(r>0)
                {
                    result = result + 1;
                }

            }
            return result;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (sFileName.Trim() != "")
            {
                progr.Visible = true;
               var result = readExcel(sFileName);
                progr.Visible = false;
                MessageBox.Show($"Uploaded {result} records successfully");

            }
        }

        public frmUpload()
        {
            InitializeComponent();
        }
    }
}
